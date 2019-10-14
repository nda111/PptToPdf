namespace System.Windows.Forms.Extensions
{
    partial class FloatingAlert
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PPT to PDF";
            this.titleLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseClick);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.BackColor = System.Drawing.Color.Transparent;
            this.pathLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.pathLabel.Location = new System.Drawing.Point(11, 26);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(143, 17);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Fullpath without name";
            this.pathLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::System.Windows.Forms.Extensions.Properties.Resources.Close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.Location = new System.Drawing.Point(229, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(15, 15);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.nameLabel.Location = new System.Drawing.Point(11, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Filename";
            this.nameLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseClick);
            // 
            // FloatingAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::System.Windows.Forms.Extensions.Properties.Resources.RoundedBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 70);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloatingAlert";
            this.ShowInTaskbar = false;
            this.Text = "FloatingAlert";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Panel closeBtn;
        private System.Windows.Forms.Label nameLabel;
    }
}