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
            this.groupBoxPhotoProperties = new System.Windows.Forms.GroupBox();
            this.richTextBoxProperties = new System.Windows.Forms.RichTextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonShare = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExportToJPEG = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAutosave = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectedDir = new System.Windows.Forms.Label();
            this.buttonBrowseAutosaveFolder = new System.Windows.Forms.Button();
            this.checkBoxStartWithSystem = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxSocial = new System.Windows.Forms.GroupBox();
            this.tabControlSocialSettings = new System.Windows.Forms.TabControl();
            this.tabPageLT = new System.Windows.Forms.TabPage();
            this.panelSnapmaticLogin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSnapmaticLogin = new System.Windows.Forms.Label();
            this.labelSnapmaticPassword = new System.Windows.Forms.Label();
            this.textBoxSnapmaticLogin = new System.Windows.Forms.TextBox();
            this.textBoxSnapmaticPassword = new System.Windows.Forms.TextBox();
            this.buttonSubmitSnapmaticLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelCreateSnapmaticAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgotSnapmaticPassword = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSnapmaticIcon = new System.Windows.Forms.PictureBox();
            this.labelTitleSnapmatic = new System.Windows.Forms.Label();
            this.panelSnapmaticLoggedin = new System.Windows.Forms.Panel();
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
            this.groupBoxPhotoProperties.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxGeneralSettings.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxSocial.SuspendLayout();
            this.tabControlSocialSettings.SuspendLayout();
            this.tabPageLT.SuspendLayout();
            this.panelSnapmaticLogin.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapmaticIcon)).BeginInit();
            this.tDebug.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tDebug);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.listViewImages);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // listViewImages
            // 
            resources.ApplyResources(this.listViewImages, "listViewImages");
            this.listViewImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPic,
            this.columnHeaderName,
            this.columnHeaderIngameDate,
            this.columnHeaderRealDate});
            this.listViewImages.FullRowSelect = true;
            this.listViewImages.GridLines = true;
            this.listViewImages.HideSelection = false;
            this.listViewImages.MultiSelect = false;
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.ShowItemToolTips = true;
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
            resources.ApplyResources(this.columnHeaderPic, "columnHeaderPic");
            // 
            // columnHeaderName
            // 
            resources.ApplyResources(this.columnHeaderName, "columnHeaderName");
            // 
            // columnHeaderIngameDate
            // 
            resources.ApplyResources(this.columnHeaderIngameDate, "columnHeaderIngameDate");
            // 
            // columnHeaderRealDate
            // 
            resources.ApplyResources(this.columnHeaderRealDate, "columnHeaderRealDate");
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.groupBoxPhotoProperties, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxActions, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // groupBoxPhotoProperties
            // 
            resources.ApplyResources(this.groupBoxPhotoProperties, "groupBoxPhotoProperties");
            this.groupBoxPhotoProperties.Controls.Add(this.richTextBoxProperties);
            this.groupBoxPhotoProperties.Name = "groupBoxPhotoProperties";
            this.groupBoxPhotoProperties.TabStop = false;
            // 
            // richTextBoxProperties
            // 
            resources.ApplyResources(this.richTextBoxProperties, "richTextBoxProperties");
            this.richTextBoxProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProperties.Name = "richTextBoxProperties";
            this.richTextBoxProperties.ReadOnly = true;
            // 
            // groupBoxActions
            // 
            resources.ApplyResources(this.groupBoxActions, "groupBoxActions");
            this.groupBoxActions.Controls.Add(this.buttonShare);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.buttonExportToJPEG);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.TabStop = false;
            // 
            // buttonShare
            // 
            resources.ApplyResources(this.buttonShare, "buttonShare");
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExportToJPEG
            // 
            resources.ApplyResources(this.buttonExportToJPEG, "buttonExportToJPEG");
            this.buttonExportToJPEG.Name = "buttonExportToJPEG";
            this.buttonExportToJPEG.UseVisualStyleBackColor = true;
            this.buttonExportToJPEG.Click += new System.EventHandler(this.buttonExportToJPEG_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPageSettings, "tabPageSettings");
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.groupBoxGeneralSettings, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxSocial, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // groupBoxGeneralSettings
            // 
            resources.ApplyResources(this.groupBoxGeneralSettings, "groupBoxGeneralSettings");
            this.groupBoxGeneralSettings.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxGeneralSettings.Name = "groupBoxGeneralSettings";
            this.groupBoxGeneralSettings.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.checkBoxAutosave, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxStartWithSystem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox1, 0, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // checkBoxAutosave
            // 
            resources.ApplyResources(this.checkBoxAutosave, "checkBoxAutosave");
            this.checkBoxAutosave.Name = "checkBoxAutosave";
            this.checkBoxAutosave.UseVisualStyleBackColor = true;
            this.checkBoxAutosave.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.labelSelectedDir, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonBrowseAutosaveFolder, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // labelSelectedDir
            // 
            resources.ApplyResources(this.labelSelectedDir, "labelSelectedDir");
            this.labelSelectedDir.Name = "labelSelectedDir";
            // 
            // buttonBrowseAutosaveFolder
            // 
            resources.ApplyResources(this.buttonBrowseAutosaveFolder, "buttonBrowseAutosaveFolder");
            this.buttonBrowseAutosaveFolder.Name = "buttonBrowseAutosaveFolder";
            this.buttonBrowseAutosaveFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseAutosaveFolder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxStartWithSystem
            // 
            resources.ApplyResources(this.checkBoxStartWithSystem, "checkBoxStartWithSystem");
            this.checkBoxStartWithSystem.Name = "checkBoxStartWithSystem";
            this.checkBoxStartWithSystem.UseVisualStyleBackColor = true;
            this.checkBoxStartWithSystem.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSocial
            // 
            resources.ApplyResources(this.groupBoxSocial, "groupBoxSocial");
            this.groupBoxSocial.Controls.Add(this.tabControlSocialSettings);
            this.groupBoxSocial.Name = "groupBoxSocial";
            this.groupBoxSocial.TabStop = false;
            // 
            // tabControlSocialSettings
            // 
            resources.ApplyResources(this.tabControlSocialSettings, "tabControlSocialSettings");
            this.tabControlSocialSettings.Controls.Add(this.tabPageLT);
            this.tabControlSocialSettings.Controls.Add(this.tabPageInstagram);
            this.tabControlSocialSettings.Controls.Add(this.tabPageTwitter);
            this.tabControlSocialSettings.Name = "tabControlSocialSettings";
            this.tabControlSocialSettings.SelectedIndex = 0;
            // 
            // tabPageLT
            // 
            this.tabPageLT.Controls.Add(this.panelSnapmaticLogin);
            this.tabPageLT.Controls.Add(this.panelSnapmaticLoggedin);
            resources.ApplyResources(this.tabPageLT, "tabPageLT");
            this.tabPageLT.Name = "tabPageLT";
            this.tabPageLT.UseVisualStyleBackColor = true;
            // 
            // panelSnapmaticLogin
            // 
            resources.ApplyResources(this.panelSnapmaticLogin, "panelSnapmaticLogin");
            this.panelSnapmaticLogin.Controls.Add(this.tableLayoutPanel6);
            this.panelSnapmaticLogin.Name = "panelSnapmaticLogin";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonSubmitSnapmaticLogin, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel6.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.labelSnapmaticLogin, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelSnapmaticPassword, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxSnapmaticLogin, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxSnapmaticPassword, 3, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // labelSnapmaticLogin
            // 
            resources.ApplyResources(this.labelSnapmaticLogin, "labelSnapmaticLogin");
            this.labelSnapmaticLogin.Name = "labelSnapmaticLogin";
            // 
            // labelSnapmaticPassword
            // 
            resources.ApplyResources(this.labelSnapmaticPassword, "labelSnapmaticPassword");
            this.labelSnapmaticPassword.Name = "labelSnapmaticPassword";
            // 
            // textBoxSnapmaticLogin
            // 
            resources.ApplyResources(this.textBoxSnapmaticLogin, "textBoxSnapmaticLogin");
            this.textBoxSnapmaticLogin.Name = "textBoxSnapmaticLogin";
            // 
            // textBoxSnapmaticPassword
            // 
            resources.ApplyResources(this.textBoxSnapmaticPassword, "textBoxSnapmaticPassword");
            this.textBoxSnapmaticPassword.Name = "textBoxSnapmaticPassword";
            // 
            // buttonSubmitSnapmaticLogin
            // 
            resources.ApplyResources(this.buttonSubmitSnapmaticLogin, "buttonSubmitSnapmaticLogin");
            this.buttonSubmitSnapmaticLogin.Name = "buttonSubmitSnapmaticLogin";
            this.buttonSubmitSnapmaticLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.linkLabelCreateSnapmaticAccount, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.linkLabelForgotSnapmaticPassword, 1, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // linkLabelCreateSnapmaticAccount
            // 
            resources.ApplyResources(this.linkLabelCreateSnapmaticAccount, "linkLabelCreateSnapmaticAccount");
            this.linkLabelCreateSnapmaticAccount.Name = "linkLabelCreateSnapmaticAccount";
            this.linkLabelCreateSnapmaticAccount.TabStop = true;
            this.linkLabelCreateSnapmaticAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelForgotSnapmaticPassword
            // 
            resources.ApplyResources(this.linkLabelForgotSnapmaticPassword, "linkLabelForgotSnapmaticPassword");
            this.linkLabelForgotSnapmaticPassword.Name = "linkLabelForgotSnapmaticPassword";
            this.linkLabelForgotSnapmaticPassword.TabStop = true;
            this.linkLabelForgotSnapmaticPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.pictureBoxSnapmaticIcon, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelTitleSnapmatic, 1, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // pictureBoxSnapmaticIcon
            // 
            resources.ApplyResources(this.pictureBoxSnapmaticIcon, "pictureBoxSnapmaticIcon");
            this.pictureBoxSnapmaticIcon.Image = global::RAGEPhotoManager.Properties.Resources.SnapmaticLogo;
            this.pictureBoxSnapmaticIcon.Name = "pictureBoxSnapmaticIcon";
            this.pictureBoxSnapmaticIcon.TabStop = false;
            // 
            // labelTitleSnapmatic
            // 
            resources.ApplyResources(this.labelTitleSnapmatic, "labelTitleSnapmatic");
            this.labelTitleSnapmatic.Name = "labelTitleSnapmatic";
            // 
            // panelSnapmaticLoggedin
            // 
            resources.ApplyResources(this.panelSnapmaticLoggedin, "panelSnapmaticLoggedin");
            this.panelSnapmaticLoggedin.Name = "panelSnapmaticLoggedin";
            // 
            // tabPageInstagram
            // 
            resources.ApplyResources(this.tabPageInstagram, "tabPageInstagram");
            this.tabPageInstagram.Name = "tabPageInstagram";
            this.tabPageInstagram.UseVisualStyleBackColor = true;
            // 
            // tabPageTwitter
            // 
            resources.ApplyResources(this.tabPageTwitter, "tabPageTwitter");
            this.tabPageTwitter.Name = "tabPageTwitter";
            this.tabPageTwitter.UseVisualStyleBackColor = true;
            // 
            // tDebug
            // 
            this.tDebug.Controls.Add(this.textBoxDebugLog);
            resources.ApplyResources(this.tDebug, "tDebug");
            this.tDebug.Name = "tDebug";
            this.tDebug.UseVisualStyleBackColor = true;
            // 
            // textBoxDebugLog
            // 
            this.textBoxDebugLog.AcceptsReturn = true;
            resources.ApplyResources(this.textBoxDebugLog, "textBoxDebugLog");
            this.textBoxDebugLog.Name = "textBoxDebugLog";
            this.textBoxDebugLog.ReadOnly = true;
            this.textBoxDebugLog.VisibleChanged += new System.EventHandler(this.TextBoxDebugLog_VisibleChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            resources.ApplyResources(this.fichierToolStripMenuItem, "fichierToolStripMenuItem");
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            resources.ApplyResources(this.minimizeToolStripMenuItem, "minimizeToolStripMenuItem");
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            resources.ApplyResources(this.aProposToolStripMenuItem, "aProposToolStripMenuItem");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
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
            resources.ApplyResources(this.contextMenuStripTray, "contextMenuStripTray");
            this.contextMenuStripTray.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTray_Opening);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            resources.ApplyResources(this.ouvrirToolStripMenuItem, "ouvrirToolStripMenuItem");
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.OuvrirToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            resources.ApplyResources(this.paramètresToolStripMenuItem, "paramètresToolStripMenuItem");
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.ParamètresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList, "imageList");
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxPhotoProperties.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxGeneralSettings.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBoxSocial.ResumeLayout(false);
            this.tabControlSocialSettings.ResumeLayout(false);
            this.tabPageLT.ResumeLayout(false);
            this.panelSnapmaticLogin.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapmaticIcon)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxPhotoProperties;
        private System.Windows.Forms.GroupBox groupBoxActions;
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
        private GroupBox groupBoxGeneralSettings;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBoxAutosave;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelSelectedDir;
        private Button buttonBrowseAutosaveFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GroupBox groupBoxSocial;
        private TabControl tabControlSocialSettings;
        private TabPage tabPageLT;
        private TabPage tabPageInstagram;
        private TabPage tabPageTwitter;
        private CheckBox checkBoxStartWithSystem;
        private ImageList imageList;
        private ListView listViewImages;
        private ColumnHeader columnHeaderPic;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderIngameDate;
        private ColumnHeader columnHeaderRealDate;
        private Panel panelSnapmaticLogin;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label labelSnapmaticLogin;
        private Label labelSnapmaticPassword;
        private TextBox textBoxSnapmaticLogin;
        private TextBox textBoxSnapmaticPassword;
        private Panel panelSnapmaticLoggedin;
        private Button buttonSubmitSnapmaticLogin;
        private TableLayoutPanel tableLayoutPanel8;
        private LinkLabel linkLabelCreateSnapmaticAccount;
        private LinkLabel linkLabelForgotSnapmaticPassword;
        private Button buttonShare;
        private Button buttonDelete;
        private Button buttonExportToJPEG;
        private RichTextBox richTextBoxProperties;
        private TableLayoutPanel tableLayoutPanel9;
        private PictureBox pictureBoxSnapmaticIcon;
        private Label labelTitleSnapmatic;
        private CheckBox checkBox1;
    }
}

