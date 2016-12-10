namespace NetBar
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.gboAbout = new System.Windows.Forms.GroupBox();
            this.linkLblBlog = new System.Windows.Forms.LinkLabel();
            this.linkLblGithub = new System.Windows.Forms.LinkLabel();
            this.lblBlog = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblAbout1 = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pboAbout = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // gboAbout
            // 
            this.gboAbout.Controls.Add(this.linkLblBlog);
            this.gboAbout.Controls.Add(this.linkLblGithub);
            this.gboAbout.Controls.Add(this.lblBlog);
            this.gboAbout.Controls.Add(this.lblGithub);
            this.gboAbout.Controls.Add(this.lblAbout1);
            this.gboAbout.Controls.Add(this.lblAbout);
            this.gboAbout.Controls.Add(this.pboAbout);
            this.gboAbout.Location = new System.Drawing.Point(12, 12);
            this.gboAbout.Name = "gboAbout";
            this.gboAbout.Size = new System.Drawing.Size(352, 127);
            this.gboAbout.TabIndex = 0;
            this.gboAbout.TabStop = false;
            // 
            // linkLblBlog
            // 
            this.linkLblBlog.AutoSize = true;
            this.linkLblBlog.Location = new System.Drawing.Point(148, 92);
            this.linkLblBlog.Name = "linkLblBlog";
            this.linkLblBlog.Size = new System.Drawing.Size(53, 12);
            this.linkLblBlog.TabIndex = 6;
            this.linkLblBlog.TabStop = true;
            this.linkLblBlog.Text = "Ryanc.cc";
            this.linkLblBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblBlog_LinkClicked);
            // 
            // linkLblGithub
            // 
            this.linkLblGithub.AutoSize = true;
            this.linkLblGithub.Location = new System.Drawing.Point(160, 68);
            this.linkLblGithub.Name = "linkLblGithub";
            this.linkLblGithub.Size = new System.Drawing.Size(113, 12);
            this.linkLblGithub.TabIndex = 5;
            this.linkLblGithub.TabStop = true;
            this.linkLblGithub.Text = "Github.com/Ryan0up";
            this.linkLblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblGithub_LinkClicked);
            // 
            // lblBlog
            // 
            this.lblBlog.AutoSize = true;
            this.lblBlog.Location = new System.Drawing.Point(112, 92);
            this.lblBlog.Name = "lblBlog";
            this.lblBlog.Size = new System.Drawing.Size(41, 12);
            this.lblBlog.TabIndex = 4;
            this.lblBlog.Text = "博客：";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Location = new System.Drawing.Point(112, 68);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(53, 12);
            this.lblGithub.TabIndex = 3;
            this.lblGithub.Text = "Github：";
            // 
            // lblAbout1
            // 
            this.lblAbout1.AutoSize = true;
            this.lblAbout1.Location = new System.Drawing.Point(112, 44);
            this.lblAbout1.Name = "lblAbout1";
            this.lblAbout1.Size = new System.Drawing.Size(95, 12);
            this.lblAbout1.TabIndex = 2;
            this.lblAbout1.Text = "V1.0 2016开发版";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(112, 20);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(89, 12);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "XX网吧计费系统";
            // 
            // pboAbout
            // 
            this.pboAbout.Image = ((System.Drawing.Image)(resources.GetObject("pboAbout.Image")));
            this.pboAbout.Location = new System.Drawing.Point(6, 20);
            this.pboAbout.Name = "pboAbout";
            this.pboAbout.Size = new System.Drawing.Size(100, 101);
            this.pboAbout.TabIndex = 0;
            this.pboAbout.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "确定";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 220);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboAbout);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.gboAbout.ResumeLayout(false);
            this.gboAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboAbout;
        private System.Windows.Forms.PictureBox pboAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblBlog;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.Label lblAbout1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkLblBlog;
        private System.Windows.Forms.LinkLabel linkLblGithub;
    }
}