using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAGEPhotoManager.Model;

namespace RAGEPhotoManager
{
    public partial class MainWindow : Form
    {
        private static MainWindow _Instance;

        public delegate void AddLogEntry(String str);
        public AddLogEntry AddLogEntryDelegate;

        public delegate void AddImageEntry(Photo photo);
        public AddImageEntry AddImageEntryDelegate;

        public static MainWindow Instance { get => _Instance; }

        public MainWindow()
        {
            _Instance = this;
            InitializeComponent();
            AddLogEntryDelegate = new AddLogEntry(AddLogEntryMethod);
            AddImageEntryDelegate = new AddImageEntry(AddViewImageMethod);
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.ProfileManager.KillAllThreads();
            Application.Exit();
        }

        private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.ProfileManager.KillAllThreads();
            Application.Exit();
        }

        private void MinimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ParamètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.tabControlMain.SelectedTab = tabPageSettings;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
#if !DEBUG
            tabControlMain.TabPages.Remove(tDebug);
#endif

            Thread backgroundThread = new Thread(Model.BackgroundTasks.Run);
            backgroundThread.Start();

            // Load settings

            Model.Settings.Load();

            checkBox1.Checked = Model.Settings.SaveToMyPictures;
            labelSelectedDir.Text = Model.Settings.MyPicturesPath;
            folderBrowserDialog1.SelectedPath = Model.Settings.MyPicturesPath;

            checkBox2.Checked = Model.Settings.LaunchAtStartup;

#if !DEBUG
            ShowInTaskbar = false;
            Visible = false;
            ShowInTaskbar = true;
#endif

            imageList.ImageSize = new Size(200, 113);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listViewImages.Margin = new Padding(0);
            listViewImages.SmallImageList = imageList;
        }

        private void TextBoxDebugLog_VisibleChanged(object sender, EventArgs e)
        {
            if (textBoxDebugLog.Visible)
            {
                textBoxDebugLog.SelectionStart = textBoxDebugLog.TextLength;
                textBoxDebugLog.ScrollToCaret();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Model.Settings.SaveToMyPictures = checkBox1.Checked;
            Model.Settings.Save();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Model.Settings.MyPicturesPath = folderBrowserDialog1.SelectedPath;
                labelSelectedDir.Text = folderBrowserDialog1.SelectedPath;
                Model.Settings.Save();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Model.Settings.LaunchAtStartup = checkBox2.Checked;
        }

        public void AddLogEntryMethod(String str)
        {
            textBoxDebugLog.AppendText(str);
        }

        private void AddViewImageMethod(Photo photo)
        {
            imageList.Images.Add(photo.Meta.uid.ToString("X"), photo.Thumb);
            ListViewItem listViewitemRow = new ListViewItem();
            listViewitemRow.IndentCount = 0;

            ListViewItem.ListViewSubItem listViewitemCol1 = new ListViewItem.ListViewSubItem();
            listViewitemCol1.Text = photo.Title;
            listViewitemRow.SubItems.Add(listViewitemCol1);

            ListViewItem.ListViewSubItem listViewitemCol2 = new ListViewItem.ListViewSubItem();
            listViewitemCol2.Text = photo.IngameDate.ToString();
            listViewitemRow.SubItems.Add(listViewitemCol2);

            ListViewItem.ListViewSubItem listViewitemCol3 = new ListViewItem.ListViewSubItem();
            listViewitemCol3.Text = photo.RealDate.ToString();
            listViewitemRow.SubItems.Add(listViewitemCol3);

            listViewitemRow.ImageIndex = imageList.Images.IndexOfKey(photo.Meta.uid.ToString("X"));

            listViewitemRow.Tag = photo;

            ListViewGroup listViewGroup = null;
            foreach (ListViewGroup listViewGroup1 in listViewImages.Groups)
            {
                if (listViewGroup1.Name == photo.Profile.GameType + "_" + photo.Profile.Name)
                {
                    listViewGroup = listViewGroup1;
                    break;
                }
            }
            if (listViewGroup == null)
            {
                listViewGroup = new ListViewGroup(photo.Profile.GameType + "_" + photo.Profile.Name, "Profile " + photo.Profile.Name + " (" + photo.GameType.DisplayName() + ")");
            }

            listViewImages.ListViewItemSorter = new ListViewItemComparer(3, SortOrder.Descending);

            listViewImages.Groups.Add(listViewGroup);

            listViewitemRow.Group = listViewGroup;

            listViewImages.Items.Add(listViewitemRow);
        }

        private void listViewImages_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listViewImages.Columns[e.ColumnIndex].Width;
            if (e.ColumnIndex == 0) e.Cancel = true;
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                Photo photo = (Photo)listViewImages.SelectedItems[0].Tag;

                buttonExportToJPEG.Enabled = true;
                buttonDelete.Enabled = true;
                buttonShare.Enabled = true;
                richTextBoxProperties.Lines = photo.Meta.Display();
            }
            else
            {
                buttonExportToJPEG.Enabled = false;
                buttonDelete.Enabled = false;
                buttonShare.Enabled = false;
                richTextBoxProperties.Lines = new string[0];
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://snapmatic.liberty-tree.net/register");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://snapmatic.liberty-tree.net/password/reset");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to permanently delete " + Path.GetFileName(((Photo)listViewImages.SelectedItems[0].Tag).Path) + "?";
            String windowTitle = "Delete confirmation";
            if (MessageBox.Show(message, windowTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Photo photo = (Photo)listViewImages.SelectedItems[0].Tag;
                photo.Profile.DeletePhoto(photo);
                listViewImages.SelectedItems[0].Remove();
            }
        }

        private void listViewImages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonDelete_Click(sender, e);
            }
        }

        private void buttonExportToJPEG_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPEG image file (*.jpg)|*.jpg";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    ((Photo)listViewImages.SelectedItems[0].Tag).SaveImageToFile(myStream);
                    myStream.Close();
                }
            }
        }

        private void listViewImages_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer currentListViewItemComparer = (ListViewItemComparer)listViewImages.ListViewItemSorter;

            if (currentListViewItemComparer != null && currentListViewItemComparer.Col == e.Column)
            {
                if (currentListViewItemComparer.SortOrder == SortOrder.Ascending)
                {
                    listViewImages.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Descending);
                }
                else
                {
                    listViewImages.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
                }
            }
            else
            {
                listViewImages.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
            }
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int _Col;
        private SortOrder _SortOrder;

        public SortOrder SortOrder { get => _SortOrder; }
        public int Col { get => _Col; }

        public ListViewItemComparer()
        {
            _Col = 0;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            _Col = column;
            _SortOrder = order;
        }

        public ListViewItemComparer(int column)
        {
            _Col = column;
            _SortOrder = SortOrder.Ascending;
        }

        public int Compare(object x, object y)
        {
            Photo photoX;
            Photo photoY;
            if (_SortOrder == SortOrder.Ascending)
            {
                photoX = (Photo)((ListViewItem)x).Tag;
                photoY = (Photo)((ListViewItem)y).Tag;
            }
            else
            {
                photoY = (Photo)((ListViewItem)x).Tag;
                photoX = (Photo)((ListViewItem)y).Tag;
            }
            switch (_Col)
            {
                case 1:
                    return String.Compare(photoX.Title, photoY.Title);
                case 2:
                    return DateTime.Compare(photoX.IngameDate, photoY.IngameDate);
                case 3:
                    return DateTime.Compare(photoX.RealDate, photoY.RealDate);
                default:
                    return 0;
            }

        }
    }
}
