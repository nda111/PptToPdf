namespace PptToPdf
{
    partial class ToastForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PPT To PDF";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(155, 108);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.preferencesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.restartToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // ToastForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(249, 31);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToastForm";
            this.ShowInTaskbar = false;
            this.Text = "ToastForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoreForm_MouseClick);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}