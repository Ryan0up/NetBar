namespace NetBar
{
    partial class frmRePwd
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
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblIdPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblReNewPwd = new System.Windows.Forms.Label();
            this.cboIdNumber = new System.Windows.Forms.ComboBox();
            this.txtIdPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtReNewPwd = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(64, 41);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(53, 12);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "会员号：";
            // 
            // lblIdPwd
            // 
            this.lblIdPwd.AutoSize = true;
            this.lblIdPwd.Location = new System.Drawing.Point(64, 114);
            this.lblIdPwd.Name = "lblIdPwd";
            this.lblIdPwd.Size = new System.Drawing.Size(65, 12);
            this.lblIdPwd.TabIndex = 0;
            this.lblIdPwd.Text = "会员密码：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(64, 187);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(53, 12);
            this.lblNewPwd.TabIndex = 0;
            this.lblNewPwd.Text = "新密码：";
            // 
            // lblReNewPwd
            // 
            this.lblReNewPwd.AutoSize = true;
            this.lblReNewPwd.Location = new System.Drawing.Point(64, 260);
            this.lblReNewPwd.Name = "lblReNewPwd";
            this.lblReNewPwd.Size = new System.Drawing.Size(65, 12);
            this.lblReNewPwd.TabIndex = 0;
            this.lblReNewPwd.Text = "确定密码：";
            // 
            // cboIdNumber
            // 
            this.cboIdNumber.FormattingEnabled = true;
            this.cboIdNumber.Location = new System.Drawing.Point(147, 38);
            this.cboIdNumber.Name = "cboIdNumber";
            this.cboIdNumber.Size = new System.Drawing.Size(184, 20);
            this.cboIdNumber.TabIndex = 1;
            // 
            // txtIdPwd
            // 
            this.txtIdPwd.Location = new System.Drawing.Point(147, 111);
            this.txtIdPwd.Name = "txtIdPwd";
            this.txtIdPwd.PasswordChar = '*';
            this.txtIdPwd.Size = new System.Drawing.Size(184, 21);
            this.txtIdPwd.TabIndex = 2;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(147, 184);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(184, 21);
            this.txtNewPwd.TabIndex = 2;
            // 
            // txtReNewPwd
            // 
            this.txtReNewPwd.Location = new System.Drawing.Point(147, 257);
            this.txtReNewPwd.Name = "txtReNewPwd";
            this.txtReNewPwd.PasswordChar = '*';
            this.txtReNewPwd.Size = new System.Drawing.Size(184, 21);
            this.txtReNewPwd.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(76, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRePwd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReNewPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtIdPwd);
            this.Controls.Add(this.cboIdNumber);
            this.Controls.Add(this.lblReNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblIdPwd);
            this.Controls.Add(this.lblIdNumber);
            this.Name = "frmRePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员密码修改";
            this.Load += new System.EventHandler(this.frmRePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblIdPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblReNewPwd;
        private System.Windows.Forms.ComboBox cboIdNumber;
        private System.Windows.Forms.TextBox txtIdPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtReNewPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}