using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RAGEPhotoManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Debug.WriteLine("Closing : " + e.CloseReason);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }


        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.columnHeaderPic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIngameDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRealDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxProperties = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShare = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExportToJPEG = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectedDir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBoxSocial = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLT = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSnapmaticLoggedin = new System.Windows.Forms.Panel();
            this.panelSnapmaticLogin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSubmitSnapmaticLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabPageInstagram = new System.Windows.Forms.TabPage();
            this.tabPageTwitter = new System.Windows.Forms.TabPage();
            this.tDebug = new System.Windows.Forms.TabPage();
            this.textBoxDebugLog = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxSocial.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLT.SuspendLayout();
            this.panelSnapmaticLogin.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tDebug.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tDebug);
            this.tabControlMain.Location = new System.Drawing.Point(12, 36);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1482, 754);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1474, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Photos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.78307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.21693F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1462, 709);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listViewImages);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photos";
            // 
            // listViewImages
            // 
            this.listViewImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPic,
            this.columnHeaderName,
            this.columnHeaderIngameDate,
            this.columnHeaderRealDate});
            this.listViewImages.FullRowSelect = true;
            this.listViewImages.GridLines = true;
            this.listViewImages.HideSelection = false;
            this.listViewImages.LabelWrap = false;
            this.listViewImages.Location = new System.Drawing.Point(6, 25);
            this.listViewImages.MultiSelect = false;
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.ShowItemToolTips = true;
            this.listViewImages.Size = new System.Drawing.Size(987, 672);
            this.listViewImages.TabIndex = 0;
            this.listViewImages.TileSize = new System.Drawing.Size(200, 113);
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.View = System.Windows.Forms.View.Details;
            this.listViewImages.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewImages_ColumnClick);
            this.listViewImages.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewImages_ColumnWidthChanging);
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            this.listViewImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewImages_KeyDown);
            // 
            // columnHeaderPic
            // 
            this.columnHeaderPic.Text = "Photo";
            this.columnHeaderPic.Width = 200;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Location";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderIngameDate
            // 
            this.columnHeaderIngameDate.Text = "Ingame time";
            this.columnHeaderIngameDate.Width = 120;
            // 
            // columnHeaderRealDate
            // 
            this.columnHeaderRealDate.Text = "Real time";
            this.columnHeaderRealDate.Width = 120;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1005, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(457, 709);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBoxProperties);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 543);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // richTextBoxProperties
            // 
            this.richTextBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProperties.Location = new System.Drawing.Point(6, 25);
            this.richTextBoxProperties.Name = "richTextBoxProperties";
            this.richTextBoxProperties.ReadOnly = true;
            this.richTextBoxProperties.Size = new System.Drawing.Size(439, 512);
            this.richTextBoxProperties.TabIndex = 0;
            this.richTextBoxProperties.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonShare);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.buttonExportToJPEG);
            this.groupBox3.Location = new System.Drawing.Point(3, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 154);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // buttonShare
            // 
            this.buttonShare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShare.Enabled = false;
            this.buttonShare.Location = new System.Drawing.Point(6, 107);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(439, 35);
            this.buttonShare.TabIndex = 2;
            this.buttonShare.Text = "Share to social media";
            this.buttonShare.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(6, 66);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(439, 35);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExportToJPEG
            // 
            this.buttonExportToJPEG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportToJPEG.Enabled = false;
            this.buttonExportToJPEG.Location = new System.Drawing.Point(6, 25);
            this.buttonExportToJPEG.Name = "buttonExportToJPEG";
            this.buttonExportToJPEG.Size = new System.Drawing.Size(439, 35);
            this.buttonExportToJPEG.TabIndex = 0;
            this.buttonExportToJPEG.Text = "Export to JPEG";
            this.buttonExportToJPEG.UseVisualStyleBackColor = true;
            this.buttonExportToJPEG.Click += new System.EventHandler(this.buttonExportToJPEG_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tableLayoutPanel3);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 29);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1474, 721);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55856F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44144F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxSocial, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1462, 709);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(703, 703);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General Settings";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBox2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 11;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(691, 678);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto save JPEGs to folder :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.labelSelectedDir, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(691, 30);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // labelSelectedDir
            // 
            this.labelSelectedDir.AutoSize = true;
            this.labelSelectedDir.Location = new System.Drawing.Point(3, 0);
            this.labelSelectedDir.Name = "labelSelectedDir";
            this.labelSelectedDir.Size = new System.Drawing.Size(0, 20);
            this.labelSelectedDir.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(591, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Start with system";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBoxSocial
            // 
            this.groupBoxSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSocial.Controls.Add(this.tabControl1);
            this.groupBoxSocial.Location = new System.Drawing.Point(712, 3);
            this.groupBoxSocial.Name = "groupBoxSocial";
            this.groupBoxSocial.Size = new System.Drawing.Size(747, 703);
            this.groupBoxSocial.TabIndex = 1;
            this.groupBoxSocial.TabStop = false;
            this.groupBoxSocial.Text = "Social";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageLT);
            this.tabControl1.Controls.Add(this.tabPageInstagram);
            this.tabControl1.Controls.Add(this.tabPageTwitter);
            this.tabControl1.Location = new System.Drawing.Point(6, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLT
            // 
            this.tabPageLT.Controls.Add(this.tableLayoutPanel9);
            this.tabPageLT.Controls.Add(this.panelSnapmaticLoggedin);
            this.tabPageLT.Controls.Add(this.panelSnapmaticLogin);
            this.tabPageLT.Location = new System.Drawing.Point(4, 29);
            this.tabPageLT.Name = "tabPageLT";
            this.tabPageLT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLT.Size = new System.Drawing.Size(727, 639);
            this.tabPageLT.TabIndex = 0;
            this.tabPageLT.Text = "Snapmatic";
            this.tabPageLT.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(715, 627);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // panelSnapmaticLoggedin
            // 
            this.panelSnapmaticLoggedin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSnapmaticLoggedin.Location = new System.Drawing.Point(6, 6);
            this.panelSnapmaticLoggedin.Name = "panelSnapmaticLoggedin";
            this.panelSnapmaticLoggedin.Size = new System.Drawing.Size(715, 627);
            this.panelSnapmaticLoggedin.TabIndex = 1;
            this.panelSnapmaticLoggedin.Visible = false;
            // 
            // panelSnapmaticLogin
            // 
            this.panelSnapmaticLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSnapmaticLogin.Controls.Add(this.tableLayoutPanel6);
            this.panelSnapmaticLogin.Location = new System.Drawing.Point(6, 6);
            this.panelSnapmaticLogin.Name = "panelSnapmaticLogin";
            this.panelSnapmaticLogin.Size = new System.Drawing.Size(715, 565);
            this.panelSnapmaticLogin.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonSubmitSnapmaticLogin, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel6.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(709, 262);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(703, 54);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(63, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(434, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(266, 26);
            this.textBox2.TabIndex = 3;
            // 
            // buttonSubmitSnapmaticLogin
            // 
            this.buttonSubmitSnapmaticLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubmitSnapmaticLogin.Location = new System.Drawing.Point(3, 123);
            this.buttonSubmitSnapmaticLogin.Name = "buttonSubmitSnapmaticLogin";
            this.buttonSubmitSnapmaticLogin.Size = new System.Drawing.Size(703, 54);
            this.buttonSubmitSnapmaticLogin.TabIndex = 1;
            this.buttonSubmitSnapmaticLogin.Text = "Submit";
            this.buttonSubmitSnapmaticLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.linkLabel2, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(703, 76);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(105, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create an account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(441, 28);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(171, 20);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot your password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tabPageInstagram
            // 
            this.tabPageInstagram.Location = new System.Drawing.Point(4, 29);
            this.tabPageInstagram.Name = "tabPageInstagram";
            this.tabPageInstagram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstagram.Size = new System.Drawing.Size(727, 639);
            this.tabPageInstagram.TabIndex = 1;
            this.tabPageInstagram.Text = "Instagram";
            this.tabPageInstagram.UseVisualStyleBackColor = true;
            // 
            // tabPageTwitter
            // 
            this.tabPageTwitter.Location = new System.Drawing.Point(4, 29);
            this.tabPageTwitter.Name = "tabPageTwitter";
            this.tabPageTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTwitter.Size = new System.Drawing.Size(727, 639);
            this.tabPageTwitter.TabIndex = 2;
            this.tabPageTwitter.Text = "Twitter";
            this.tabPageTwitter.UseVisualStyleBackColor = true;
            // 
            // tDebug
            // 
            this.tDebug.Controls.Add(this.textBoxDebugLog);
            this.tDebug.Location = new System.Drawing.Point(4, 29);
            this.tDebug.Name = "tDebug";
            this.tDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tDebug.Size = new System.Drawing.Size(1474, 721);
            this.tDebug.TabIndex = 2;
            this.tDebug.Text = "Debug";
            this.tDebug.UseVisualStyleBackColor = true;
            // 
            // textBoxDebugLog
            // 
            this.textBoxDebugLog.AcceptsReturn = true;
            this.textBoxDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDebugLog.Location = new System.Drawing.Point(6, 6);
            this.textBoxDebugLog.Multiline = true;
            this.textBoxDebugLog.Name = "textBoxDebugLog";
            this.textBoxDebugLog.ReadOnly = true;
            this.textBoxDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDebugLog.Size = new System.Drawing.Size(1110, 563);
            this.textBoxDebugLog.TabIndex = 0;
            this.textBoxDebugLog.VisibleChanged += new System.EventHandler(this.TextBoxDebugLog_VisibleChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1506, 33);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fichierToolStripMenuItem.Text = "&File";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.quitterToolStripMenuItem.Text = "Exit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 29);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aProposToolStripMenuItem.Text = "About";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RAGE Photo manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ouvrirToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(270, 138);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 32);
            this.toolStripMenuItem2.Text = "RAGE Photo Manager";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.ouvrirToolStripMenuItem.Text = "Open";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.OuvrirToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.paramètresToolStripMenuItem.Text = "Settings";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.ParamètresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select output folder";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 802);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainWindow";
            this.Text = "RAGE Photo Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBoxSocial.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLT.ResumeLayout(false);
            this.panelSnapmaticLogin.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tDebug.ResumeLayout(false);
            this.tDebug.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        public TabPage tDebug;
        private ToolStripSeparator toolStripSeparator2;
        public TextBox textBoxDebugLog;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelSelectedDir;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GroupBox groupBoxSocial;
        private TabControl tabControl1;
        private TabPage tabPageLT;
        private TabPage tabPageInstagram;
        private TabPage tabPageTwitter;
        private CheckBox checkBox2;
        private ImageList imageList;
        private ListView listViewImages;
        private ColumnHeader columnHeaderPic;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderIngameDate;
        private ColumnHeader columnHeaderRealDate;
        private Panel panelSnapmaticLogin;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panelSnapmaticLoggedin;
        private Button buttonSubmitSnapmaticLogin;
        private TableLayoutPanel tableLayoutPanel8;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button buttonShare;
        private Button buttonDelete;
        private Button buttonExportToJPEG;
        private TableLayoutPanel tableLayoutPanel9;
        private RichTextBox richTextBoxProperties;
    }
}

