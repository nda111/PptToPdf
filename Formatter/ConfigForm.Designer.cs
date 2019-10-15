namespace PptToPdf
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.tabPanel = new System.Windows.Forms.Panel();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.alertPreviewBox = new System.Windows.Forms.Extensions.OpacityPictureBox();
            this.alertOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.alertOpacityLabel = new System.Windows.Forms.Label();
            this.directionPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bottomRightUp = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.bottomRightLeft = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.topLeftRight = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.topRightDown = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.topRightLeft = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.topLeftDown = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.bottomLeftRight = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.bottomLeftUp = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alertLabel = new System.Windows.Forms.Label();
            this.toastPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.toastPreviewBox = new System.Windows.Forms.Extensions.OpacityPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.middleBtn = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.bottomBtn = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.topBtn = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.toastOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.toastOpacityLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toastLabel = new System.Windows.Forms.Label();
            this.genericPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.driveTextBox = new System.Windows.Forms.TextBox();
            this.fontLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.drivesLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genericLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.defaultBtn = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.toastMenuButton = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.alertMenuButton = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.genericMenuButton = new System.Windows.Forms.Extensions.ImageRadioButton();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.showTipsCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPanel.SuspendLayout();
            this.alertPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertOpacityTrackBar)).BeginInit();
            this.directionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toastPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastOpacityTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.genericPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPanel.Controls.Add(this.alertPanel);
            this.tabPanel.Controls.Add(this.toastPanel);
            this.tabPanel.Controls.Add(this.genericPanel);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(394, 441);
            this.tabPanel.TabIndex = 0;
            // 
            // alertPanel
            // 
            this.alertPanel.Controls.Add(this.panel5);
            this.alertPanel.Controls.Add(this.panel2);
            this.alertPanel.Location = new System.Drawing.Point(482, 28);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(425, 464);
            this.alertPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.alertPreviewBox);
            this.panel5.Controls.Add(this.alertOpacityTrackBar);
            this.panel5.Controls.Add(this.alertOpacityLabel);
            this.panel5.Controls.Add(this.directionPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(425, 432);
            this.panel5.TabIndex = 5;
            // 
            // alertPreviewBox
            // 
            this.alertPreviewBox.Image = global::PptToPdf.Properties.Resources.AlertOpacityPreview;
            this.alertPreviewBox.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPreviewBox.ImageOpacity = 1D;
            this.alertPreviewBox.Location = new System.Drawing.Point(13, 274);
            this.alertPreviewBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alertPreviewBox.Name = "alertPreviewBox";
            this.alertPreviewBox.Size = new System.Drawing.Size(300, 84);
            this.alertPreviewBox.TabIndex = 8;
            // 
            // alertOpacityTrackBar
            // 
            this.alertOpacityTrackBar.Location = new System.Drawing.Point(13, 223);
            this.alertOpacityTrackBar.Maximum = 100;
            this.alertOpacityTrackBar.Name = "alertOpacityTrackBar";
            this.alertOpacityTrackBar.Size = new System.Drawing.Size(300, 45);
            this.alertOpacityTrackBar.TabIndex = 7;
            this.alertOpacityTrackBar.Value = 100;
            this.alertOpacityTrackBar.Scroll += new System.EventHandler(this.alertOpacityTrackBar_Scroll);
            this.alertOpacityTrackBar.ValueChanged += new System.EventHandler(this.alertOpacityTrackBar_Scroll);
            // 
            // alertOpacityLabel
            // 
            this.alertOpacityLabel.AutoSize = true;
            this.alertOpacityLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alertOpacityLabel.Location = new System.Drawing.Point(13, 203);
            this.alertOpacityLabel.Name = "alertOpacityLabel";
            this.alertOpacityLabel.Size = new System.Drawing.Size(98, 17);
            this.alertOpacityLabel.TabIndex = 2;
            this.alertOpacityLabel.Text = "Opacity: 100%";
            // 
            // directionPanel
            // 
            this.directionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.directionPanel.Controls.Add(this.panel11);
            this.directionPanel.Controls.Add(this.panel10);
            this.directionPanel.Controls.Add(this.panel9);
            this.directionPanel.Controls.Add(this.panel8);
            this.directionPanel.Controls.Add(this.bottomRightUp);
            this.directionPanel.Controls.Add(this.bottomRightLeft);
            this.directionPanel.Controls.Add(this.topLeftRight);
            this.directionPanel.Controls.Add(this.topRightDown);
            this.directionPanel.Controls.Add(this.topRightLeft);
            this.directionPanel.Controls.Add(this.topLeftDown);
            this.directionPanel.Controls.Add(this.bottomLeftRight);
            this.directionPanel.Controls.Add(this.bottomLeftUp);
            this.directionPanel.Location = new System.Drawing.Point(13, 13);
            this.directionPanel.Name = "directionPanel";
            this.directionPanel.Size = new System.Drawing.Size(300, 168);
            this.directionPanel.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(275, 143);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(20, 20);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(275, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 20);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 20);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 143);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 20);
            this.panel8.TabIndex = 1;
            // 
            // bottomRightUp
            // 
            this.bottomRightUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomRightUp.Checked = false;
            this.bottomRightUp.Location = new System.Drawing.Point(275, 116);
            this.bottomRightUp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bottomRightUp.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomRightUp.MarkupHeight = 0.1D;
            this.bottomRightUp.MarkupWidth = 0.8D;
            this.bottomRightUp.Name = "bottomRightUp";
            this.bottomRightUp.NormalBackgroundImage = global::PptToPdf.Properties.Resources.UpArrow;
            this.bottomRightUp.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._UpArrow;
            this.bottomRightUp.Size = new System.Drawing.Size(20, 20);
            this.bottomRightUp.TabIndex = 0;
            this.bottomRightUp.ThemeColor = System.Drawing.Color.Empty;
            this.bottomRightUp.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // bottomRightLeft
            // 
            this.bottomRightLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomRightLeft.Checked = false;
            this.bottomRightLeft.Location = new System.Drawing.Point(249, 143);
            this.bottomRightLeft.Margin = new System.Windows.Forms.Padding(3, 33, 3, 33);
            this.bottomRightLeft.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomRightLeft.MarkupHeight = 0.1D;
            this.bottomRightLeft.MarkupWidth = 0.8D;
            this.bottomRightLeft.Name = "bottomRightLeft";
            this.bottomRightLeft.NormalBackgroundImage = global::PptToPdf.Properties.Resources.LeftArrow;
            this.bottomRightLeft.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._LeftArrow;
            this.bottomRightLeft.Size = new System.Drawing.Size(20, 20);
            this.bottomRightLeft.TabIndex = 0;
            this.bottomRightLeft.ThemeColor = System.Drawing.Color.Empty;
            this.bottomRightLeft.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // topLeftRight
            // 
            this.topLeftRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topLeftRight.Checked = false;
            this.topLeftRight.Location = new System.Drawing.Point(29, 3);
            this.topLeftRight.Margin = new System.Windows.Forms.Padding(3, 23, 3, 23);
            this.topLeftRight.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.topLeftRight.MarkupHeight = 0.1D;
            this.topLeftRight.MarkupWidth = 0.8D;
            this.topLeftRight.Name = "topLeftRight";
            this.topLeftRight.NormalBackgroundImage = global::PptToPdf.Properties.Resources.RightArrow;
            this.topLeftRight.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._RightArrow;
            this.topLeftRight.Size = new System.Drawing.Size(20, 20);
            this.topLeftRight.TabIndex = 0;
            this.topLeftRight.ThemeColor = System.Drawing.Color.Empty;
            this.topLeftRight.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // topRightDown
            // 
            this.topRightDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topRightDown.Checked = false;
            this.topRightDown.Location = new System.Drawing.Point(275, 29);
            this.topRightDown.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.topRightDown.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.topRightDown.MarkupHeight = 0.1D;
            this.topRightDown.MarkupWidth = 0.8D;
            this.topRightDown.Name = "topRightDown";
            this.topRightDown.NormalBackgroundImage = global::PptToPdf.Properties.Resources.DownArrow;
            this.topRightDown.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._DownArrow;
            this.topRightDown.Size = new System.Drawing.Size(20, 20);
            this.topRightDown.TabIndex = 0;
            this.topRightDown.ThemeColor = System.Drawing.Color.Empty;
            this.topRightDown.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // topRightLeft
            // 
            this.topRightLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topRightLeft.Checked = false;
            this.topRightLeft.Location = new System.Drawing.Point(249, 3);
            this.topRightLeft.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.topRightLeft.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.topRightLeft.MarkupHeight = 0.1D;
            this.topRightLeft.MarkupWidth = 0.8D;
            this.topRightLeft.Name = "topRightLeft";
            this.topRightLeft.NormalBackgroundImage = global::PptToPdf.Properties.Resources.LeftArrow;
            this.topRightLeft.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._LeftArrow;
            this.topRightLeft.Size = new System.Drawing.Size(20, 20);
            this.topRightLeft.TabIndex = 0;
            this.topRightLeft.ThemeColor = System.Drawing.Color.Empty;
            this.topRightLeft.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // topLeftDown
            // 
            this.topLeftDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topLeftDown.Checked = false;
            this.topLeftDown.Location = new System.Drawing.Point(3, 29);
            this.topLeftDown.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.topLeftDown.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.topLeftDown.MarkupHeight = 0.1D;
            this.topLeftDown.MarkupWidth = 0.8D;
            this.topLeftDown.Name = "topLeftDown";
            this.topLeftDown.NormalBackgroundImage = global::PptToPdf.Properties.Resources.DownArrow;
            this.topLeftDown.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._DownArrow;
            this.topLeftDown.Size = new System.Drawing.Size(20, 20);
            this.topLeftDown.TabIndex = 0;
            this.topLeftDown.ThemeColor = System.Drawing.Color.Empty;
            this.topLeftDown.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // bottomLeftRight
            // 
            this.bottomLeftRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomLeftRight.Checked = false;
            this.bottomLeftRight.Location = new System.Drawing.Point(29, 143);
            this.bottomLeftRight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bottomLeftRight.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLeftRight.MarkupHeight = 0.1D;
            this.bottomLeftRight.MarkupWidth = 0.8D;
            this.bottomLeftRight.Name = "bottomLeftRight";
            this.bottomLeftRight.NormalBackgroundImage = global::PptToPdf.Properties.Resources.RightArrow;
            this.bottomLeftRight.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._RightArrow;
            this.bottomLeftRight.Size = new System.Drawing.Size(20, 20);
            this.bottomLeftRight.TabIndex = 0;
            this.bottomLeftRight.ThemeColor = System.Drawing.Color.Empty;
            this.bottomLeftRight.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // bottomLeftUp
            // 
            this.bottomLeftUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomLeftUp.Checked = false;
            this.bottomLeftUp.Location = new System.Drawing.Point(3, 116);
            this.bottomLeftUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bottomLeftUp.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLeftUp.MarkupHeight = 0.1D;
            this.bottomLeftUp.MarkupWidth = 0.8D;
            this.bottomLeftUp.Name = "bottomLeftUp";
            this.bottomLeftUp.NormalBackgroundImage = global::PptToPdf.Properties.Resources.UpArrow;
            this.bottomLeftUp.SelectedBackgroundImage = global::PptToPdf.Properties.Resources._UpArrow;
            this.bottomLeftUp.Size = new System.Drawing.Size(20, 20);
            this.bottomLeftUp.TabIndex = 0;
            this.bottomLeftUp.ThemeColor = System.Drawing.Color.Empty;
            this.bottomLeftUp.CheckedChanged += new System.EventHandler(this.alertPosition_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.alertLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 32);
            this.panel2.TabIndex = 2;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alertLabel.Location = new System.Drawing.Point(3, 5);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(46, 21);
            this.alertLabel.TabIndex = 0;
            this.alertLabel.Text = "Alert";
            // 
            // toastPanel
            // 
            this.toastPanel.Controls.Add(this.panel6);
            this.toastPanel.Controls.Add(this.panel3);
            this.toastPanel.Location = new System.Drawing.Point(51, 386);
            this.toastPanel.Name = "toastPanel";
            this.toastPanel.Size = new System.Drawing.Size(425, 407);
            this.toastPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.toastPreviewBox);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.toastOpacityTrackBar);
            this.panel6.Controls.Add(this.toastOpacityLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(425, 375);
            this.panel6.TabIndex = 6;
            // 
            // toastPreviewBox
            // 
            this.toastPreviewBox.Image = global::PptToPdf.Properties.Resources.ToastPreview;
            this.toastPreviewBox.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toastPreviewBox.ImageOpacity = 1D;
            this.toastPreviewBox.Location = new System.Drawing.Point(13, 271);
            this.toastPreviewBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toastPreviewBox.Name = "toastPreviewBox";
            this.toastPreviewBox.Size = new System.Drawing.Size(300, 42);
            this.toastPreviewBox.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.middleBtn);
            this.panel7.Controls.Add(this.bottomBtn);
            this.panel7.Controls.Add(this.topBtn);
            this.panel7.Location = new System.Drawing.Point(13, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 168);
            this.panel7.TabIndex = 2;
            // 
            // middleBtn
            // 
            this.middleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.middleBtn.Checked = false;
            this.middleBtn.Location = new System.Drawing.Point(113, 74);
            this.middleBtn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.middleBtn.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.middleBtn.MarkupHeight = 0.1D;
            this.middleBtn.MarkupWidth = 0.8D;
            this.middleBtn.Name = "middleBtn";
            this.middleBtn.NormalBackgroundImage = global::PptToPdf.Properties.Resources.ToastPosition;
            this.middleBtn.SelectedBackgroundImage = ((System.Drawing.Image)(resources.GetObject("middleBtn.SelectedBackgroundImage")));
            this.middleBtn.Size = new System.Drawing.Size(70, 18);
            this.middleBtn.TabIndex = 0;
            this.middleBtn.ThemeColor = System.Drawing.Color.Empty;
            this.middleBtn.CheckedChanged += new System.EventHandler(this.toastPosition_CheckedChanged);
            // 
            // bottomBtn
            // 
            this.bottomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomBtn.Checked = false;
            this.bottomBtn.Location = new System.Drawing.Point(113, 131);
            this.bottomBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bottomBtn.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBtn.MarkupHeight = 0.1D;
            this.bottomBtn.MarkupWidth = 0.8D;
            this.bottomBtn.Name = "bottomBtn";
            this.bottomBtn.NormalBackgroundImage = global::PptToPdf.Properties.Resources.ToastPosition;
            this.bottomBtn.SelectedBackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomBtn.SelectedBackgroundImage")));
            this.bottomBtn.Size = new System.Drawing.Size(70, 18);
            this.bottomBtn.TabIndex = 0;
            this.bottomBtn.ThemeColor = System.Drawing.Color.Empty;
            this.bottomBtn.CheckedChanged += new System.EventHandler(this.toastPosition_CheckedChanged);
            // 
            // topBtn
            // 
            this.topBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBtn.Checked = false;
            this.topBtn.Location = new System.Drawing.Point(113, 16);
            this.topBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topBtn.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.topBtn.MarkupHeight = 0.1D;
            this.topBtn.MarkupWidth = 0.8D;
            this.topBtn.Name = "topBtn";
            this.topBtn.NormalBackgroundImage = global::PptToPdf.Properties.Resources.ToastPosition;
            this.topBtn.SelectedBackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBtn.SelectedBackgroundImage")));
            this.topBtn.Size = new System.Drawing.Size(70, 18);
            this.topBtn.TabIndex = 0;
            this.topBtn.ThemeColor = System.Drawing.Color.Empty;
            this.topBtn.CheckedChanged += new System.EventHandler(this.toastPosition_CheckedChanged);
            // 
            // toastOpacityTrackBar
            // 
            this.toastOpacityTrackBar.Location = new System.Drawing.Point(10, 219);
            this.toastOpacityTrackBar.Maximum = 100;
            this.toastOpacityTrackBar.Name = "toastOpacityTrackBar";
            this.toastOpacityTrackBar.Size = new System.Drawing.Size(300, 45);
            this.toastOpacityTrackBar.TabIndex = 7;
            this.toastOpacityTrackBar.Value = 100;
            this.toastOpacityTrackBar.Scroll += new System.EventHandler(this.toastOpacityTrackBar_Scroll);
            this.toastOpacityTrackBar.ValueChanged += new System.EventHandler(this.toastOpacityTrackBar_Scroll);
            // 
            // toastOpacityLabel
            // 
            this.toastOpacityLabel.AutoSize = true;
            this.toastOpacityLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toastOpacityLabel.Location = new System.Drawing.Point(10, 199);
            this.toastOpacityLabel.Name = "toastOpacityLabel";
            this.toastOpacityLabel.Size = new System.Drawing.Size(98, 17);
            this.toastOpacityLabel.TabIndex = 2;
            this.toastOpacityLabel.Text = "Opacity: 100%";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toastLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 32);
            this.panel3.TabIndex = 2;
            // 
            // toastLabel
            // 
            this.toastLabel.AutoSize = true;
            this.toastLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toastLabel.Location = new System.Drawing.Point(3, 5);
            this.toastLabel.Name = "toastLabel";
            this.toastLabel.Size = new System.Drawing.Size(51, 21);
            this.toastLabel.TabIndex = 0;
            this.toastLabel.Text = "Toast";
            // 
            // genericPanel
            // 
            this.genericPanel.Controls.Add(this.panel4);
            this.genericPanel.Controls.Add(this.panel1);
            this.genericPanel.Location = new System.Drawing.Point(51, 28);
            this.genericPanel.Name = "genericPanel";
            this.genericPanel.Size = new System.Drawing.Size(425, 352);
            this.genericPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.showTipsCheckBox);
            this.panel4.Controls.Add(this.driveTextBox);
            this.panel4.Controls.Add(this.fontLinkedLabel);
            this.panel4.Controls.Add(this.drivesLabel);
            this.panel4.Controls.Add(this.fontLabel);
            this.panel4.Controls.Add(this.languageLabel);
            this.panel4.Controls.Add(this.langComboBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(425, 320);
            this.panel4.TabIndex = 4;
            // 
            // driveTextBox
            // 
            this.driveTextBox.Location = new System.Drawing.Point(17, 157);
            this.driveTextBox.Name = "driveTextBox";
            this.driveTextBox.Size = new System.Drawing.Size(258, 25);
            this.driveTextBox.TabIndex = 6;
            this.driveTextBox.Text = "C";
            this.driveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driveTextBox_KeyPress);
            // 
            // fontLinkedLabel
            // 
            this.fontLinkedLabel.ActiveLinkColor = System.Drawing.Color.Gray;
            this.fontLinkedLabel.AutoSize = true;
            this.fontLinkedLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fontLinkedLabel.Location = new System.Drawing.Point(13, 29);
            this.fontLinkedLabel.Name = "fontLinkedLabel";
            this.fontLinkedLabel.Size = new System.Drawing.Size(70, 19);
            this.fontLinkedLabel.TabIndex = 5;
            this.fontLinkedLabel.TabStop = true;
            this.fontLinkedLabel.Text = "linkLabel1";
            this.fontLinkedLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fontLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fontLinkedLabel_LinkClicked);
            // 
            // drivesLabel
            // 
            this.drivesLabel.AutoSize = true;
            this.drivesLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drivesLabel.Location = new System.Drawing.Point(13, 135);
            this.drivesLabel.Name = "drivesLabel";
            this.drivesLabel.Size = new System.Drawing.Size(47, 17);
            this.drivesLabel.TabIndex = 2;
            this.drivesLabel.Text = "Drives";
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fontLabel.Location = new System.Drawing.Point(13, 10);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(36, 17);
            this.fontLabel.TabIndex = 2;
            this.fontLabel.Text = "Font";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageLabel.Location = new System.Drawing.Point(13, 66);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(68, 17);
            this.languageLabel.TabIndex = 2;
            this.languageLabel.Text = "Language";
            // 
            // langComboBox
            // 
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Location = new System.Drawing.Point(17, 91);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(121, 25);
            this.langComboBox.TabIndex = 3;
            this.langComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.langComboBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.genericLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 32);
            this.panel1.TabIndex = 1;
            // 
            // genericLabel
            // 
            this.genericLabel.AutoSize = true;
            this.genericLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genericLabel.Location = new System.Drawing.Point(3, 5);
            this.genericLabel.Name = "genericLabel";
            this.genericLabel.Size = new System.Drawing.Size(68, 21);
            this.genericLabel.TabIndex = 0;
            this.genericLabel.Text = "Generic";
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.panel12);
            this.menuPanel.Controls.Add(this.panel13);
            this.menuPanel.Controls.Add(this.toastMenuButton);
            this.menuPanel.Controls.Add(this.alertMenuButton);
            this.menuPanel.Controls.Add(this.genericMenuButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(394, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(60, 441);
            this.menuPanel.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.defaultBtn);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 319);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(58, 60);
            this.panel12.TabIndex = 6;
            // 
            // defaultBtn
            // 
            this.defaultBtn.BackColor = System.Drawing.Color.White;
            this.defaultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.defaultBtn.Checked = false;
            this.defaultBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultBtn.Location = new System.Drawing.Point(0, 0);
            this.defaultBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.defaultBtn.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.defaultBtn.MarkupHeight = 0.1D;
            this.defaultBtn.MarkupWidth = 0.8D;
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.NormalBackgroundImage = global::PptToPdf.Properties.Resources.Default;
            this.defaultBtn.SelectedBackgroundImage = global::PptToPdf.Properties.Resources.DefaultHover;
            this.defaultBtn.Size = new System.Drawing.Size(58, 60);
            this.defaultBtn.TabIndex = 8;
            this.defaultBtn.ThemeColor = System.Drawing.Color.Empty;
            this.defaultBtn.CheckedChanged += new System.EventHandler(this.uncheckable_CheckedChanged);
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.saveBtn);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 379);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(58, 60);
            this.panel13.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Checked = false;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Location = new System.Drawing.Point(0, 0);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.MarkupDock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.MarkupHeight = 0.1D;
            this.saveBtn.MarkupWidth = 0.8D;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NormalBackgroundImage = global::PptToPdf.Properties.Resources.Save;
            this.saveBtn.SelectedBackgroundImage = global::PptToPdf.Properties.Resources.SaveHover;
            this.saveBtn.Size = new System.Drawing.Size(58, 60);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.ThemeColor = System.Drawing.Color.Empty;
            this.saveBtn.CheckedChanged += new System.EventHandler(this.uncheckable_CheckedChanged);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toastMenuButton
            // 
            this.toastMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toastMenuButton.Checked = false;
            this.toastMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.toastMenuButton.Location = new System.Drawing.Point(0, 118);
            this.toastMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.toastMenuButton.MarkupDock = System.Windows.Forms.DockStyle.Right;
            this.toastMenuButton.MarkupHeight = 0.8D;
            this.toastMenuButton.MarkupWidth = 0.07D;
            this.toastMenuButton.Name = "toastMenuButton";
            this.toastMenuButton.NormalBackgroundImage = global::PptToPdf.Properties.Resources.Toast;
            this.toastMenuButton.SelectedBackgroundImage = global::PptToPdf.Properties.Resources.ToastHover;
            this.toastMenuButton.Size = new System.Drawing.Size(58, 59);
            this.toastMenuButton.TabIndex = 2;
            this.toastMenuButton.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.toastMenuButton.CheckedChanged += new System.EventHandler(this.TapMenu_CheckedChanged);
            // 
            // alertMenuButton
            // 
            this.alertMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertMenuButton.Checked = false;
            this.alertMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertMenuButton.Location = new System.Drawing.Point(0, 59);
            this.alertMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.alertMenuButton.MarkupDock = System.Windows.Forms.DockStyle.Right;
            this.alertMenuButton.MarkupHeight = 0.8D;
            this.alertMenuButton.MarkupWidth = 0.07D;
            this.alertMenuButton.Name = "alertMenuButton";
            this.alertMenuButton.NormalBackgroundImage = global::PptToPdf.Properties.Resources.Alert;
            this.alertMenuButton.SelectedBackgroundImage = global::PptToPdf.Properties.Resources.AlertHover;
            this.alertMenuButton.Size = new System.Drawing.Size(58, 59);
            this.alertMenuButton.TabIndex = 1;
            this.alertMenuButton.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.alertMenuButton.CheckedChanged += new System.EventHandler(this.TapMenu_CheckedChanged);
            // 
            // genericMenuButton
            // 
            this.genericMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genericMenuButton.Checked = true;
            this.genericMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.genericMenuButton.Location = new System.Drawing.Point(0, 0);
            this.genericMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.genericMenuButton.MarkupDock = System.Windows.Forms.DockStyle.Right;
            this.genericMenuButton.MarkupHeight = 0.8D;
            this.genericMenuButton.MarkupWidth = 0.07D;
            this.genericMenuButton.Name = "genericMenuButton";
            this.genericMenuButton.NormalBackgroundImage = global::PptToPdf.Properties.Resources.Setting;
            this.genericMenuButton.SelectedBackgroundImage = global::PptToPdf.Properties.Resources.SettingHover;
            this.genericMenuButton.Size = new System.Drawing.Size(58, 59);
            this.genericMenuButton.TabIndex = 0;
            this.genericMenuButton.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.genericMenuButton.CheckedChanged += new System.EventHandler(this.TapMenu_CheckedChanged);
            // 
            // showTipsCheckBox
            // 
            this.showTipsCheckBox.AutoSize = true;
            this.showTipsCheckBox.Location = new System.Drawing.Point(13, 284);
            this.showTipsCheckBox.Name = "showTipsCheckBox";
            this.showTipsCheckBox.Size = new System.Drawing.Size(159, 23);
            this.showTipsCheckBox.TabIndex = 4;
            this.showTipsCheckBox.Text = "Show tips on startup";
            this.showTipsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 441);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.menuPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.VisibleChanged += new System.EventHandler(this.ConfigForm_VisibleChanged);
            this.tabPanel.ResumeLayout(false);
            this.alertPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertOpacityTrackBar)).EndInit();
            this.directionPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toastPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastOpacityTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.genericPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Extensions.ImageRadioButton genericMenuButton;
        private System.Windows.Forms.Extensions.ImageRadioButton alertMenuButton;
        private System.Windows.Forms.Extensions.ImageRadioButton toastMenuButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel genericPanel;
        private System.Windows.Forms.Panel alertPanel;
        private System.Windows.Forms.Panel toastPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label genericLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label toastLabel;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label drivesLabel;
        private System.Windows.Forms.Panel directionPanel;
        private System.Windows.Forms.TrackBar alertOpacityTrackBar;
        private System.Windows.Forms.Label alertOpacityLabel;
        private System.Windows.Forms.Extensions.OpacityPictureBox alertPreviewBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Extensions.ImageRadioButton bottomRightUp;
        private System.Windows.Forms.Extensions.ImageRadioButton bottomRightLeft;
        private System.Windows.Forms.Extensions.ImageRadioButton topLeftRight;
        private System.Windows.Forms.Extensions.ImageRadioButton topRightDown;
        private System.Windows.Forms.Extensions.ImageRadioButton topRightLeft;
        private System.Windows.Forms.Extensions.ImageRadioButton topLeftDown;
        private System.Windows.Forms.Extensions.ImageRadioButton bottomLeftRight;
        private System.Windows.Forms.Extensions.ImageRadioButton bottomLeftUp;
        private System.Windows.Forms.LinkLabel fontLinkedLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TrackBar toastOpacityTrackBar;
        private System.Windows.Forms.Label toastOpacityLabel;
        private System.Windows.Forms.Extensions.ImageRadioButton bottomBtn;
        private System.Windows.Forms.Extensions.ImageRadioButton topBtn;
        private System.Windows.Forms.Extensions.ImageRadioButton middleBtn;
        private System.Windows.Forms.Extensions.OpacityPictureBox toastPreviewBox;
        private System.Windows.Forms.TextBox driveTextBox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Extensions.ImageRadioButton defaultBtn;
        private System.Windows.Forms.Extensions.ImageRadioButton saveBtn;
        private System.Windows.Forms.CheckBox showTipsCheckBox;
    }
}