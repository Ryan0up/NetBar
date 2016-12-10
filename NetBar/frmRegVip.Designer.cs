namespace NetBar
{
    partial class frmRegVip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegVip));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblBeginPay = new System.Windows.Forms.Label();
            this.lblIdRePwd = new System.Windows.Forms.Label();
            this.lblIdPwdVip = new System.Windows.Forms.Label();
            this.lblIdNumberVip = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMoney);
            this.groupBox1.Controls.Add(this.txtRePwd);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblBeginPay);
            this.groupBox1.Controls.Add(this.lblIdRePwd);
            this.groupBox1.Controls.Add(this.lblIdPwdVip);
            this.groupBox1.Controls.Add(this.lblIdNumberVip);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // nudMoney
            // 
            this.nudMoney.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMoney.Location = new System.Drawing.Point(153, 248);
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(193, 21);
            this.nudMoney.TabIndex = 4;
            this.nudMoney.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(153, 174);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(193, 21);
            this.txtRePwd.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(153, 101);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(193, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 21);
            this.txtId.TabIndex = 1;
            // 
            // lblBeginPay
            // 
            this.lblBeginPay.AutoSize = true;
            this.lblBeginPay.Location = new System.Drawing.Point(71, 250);
            this.lblBeginPay.Name = "lblBeginPay";
            this.lblBeginPay.Size = new System.Drawing.Size(65, 12);
            this.lblBeginPay.TabIndex = 0;
            this.lblBeginPay.Text = "初始充值：";
            // 
            // lblIdRePwd
            // 
            this.lblIdRePwd.AutoSize = true;
            this.lblIdRePwd.Location = new System.Drawing.Point(71, 177);
            this.lblIdRePwd.Name = "lblIdRePwd";
            this.lblIdRePwd.Size = new System.Drawing.Size(65, 12);
            this.lblIdRePwd.TabIndex = 0;
            this.lblIdRePwd.Text = "重复密码：";
            // 
            // lblIdPwdVip
            // 
            this.lblIdPwdVip.AutoSize = true;
            this.lblIdPwdVip.Location = new System.Drawing.Point(71, 104);
            this.lblIdPwdVip.Name = "lblIdPwdVip";
            this.lblIdPwdVip.Size = new System.Drawing.Size(41, 12);
            this.lblIdPwdVip.TabIndex = 0;
            this.lblIdPwdVip.Text = "密码：";
            // 
            // lblIdNumberVip
            // 
            this.lblIdNumberVip.AutoSize = true;
            this.lblIdNumberVip.Location = new System.Drawing.Point(71, 31);
            this.lblIdNumberVip.Name = "lblIdNumberVip";
            this.lblIdNumberVip.Size = new System.Drawing.Size(65, 12);
            this.lblIdNumberVip.TabIndex = 0;
            this.lblIdNumberVip.Text = "会员卡号：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(92, 322);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // frmRegVip
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegVip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册会员";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBeginPay;
        private System.Windows.Forms.Label lblIdRePwd;
        private System.Windows.Forms.Label lblIdPwdVip;
        private System.Windows.Forms.Label lblIdNumberVip;
        private System.Windows.Forms.NumericUpDown nudMoney;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}