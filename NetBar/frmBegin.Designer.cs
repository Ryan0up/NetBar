namespace NetBar
{
    partial class frmBegin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBegin));
            this.lblPcNumber = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblIdPwd = new System.Windows.Forms.Label();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.cboPcNumber = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtBeginTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPcNumber
            // 
            this.lblPcNumber.AutoSize = true;
            this.lblPcNumber.Location = new System.Drawing.Point(71, 31);
            this.lblPcNumber.Name = "lblPcNumber";
            this.lblPcNumber.Size = new System.Drawing.Size(65, 12);
            this.lblPcNumber.TabIndex = 0;
            this.lblPcNumber.Text = "机器编号：";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(71, 104);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(53, 12);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "会员号：";
            // 
            // lblIdPwd
            // 
            this.lblIdPwd.AutoSize = true;
            this.lblIdPwd.Location = new System.Drawing.Point(71, 177);
            this.lblIdPwd.Name = "lblIdPwd";
            this.lblIdPwd.Size = new System.Drawing.Size(41, 12);
            this.lblIdPwd.TabIndex = 0;
            this.lblIdPwd.Text = "密码：";
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(71, 250);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(65, 12);
            this.lblBeginTime.TabIndex = 0;
            this.lblBeginTime.Text = "开始时间：";
            // 
            // cboPcNumber
            // 
            this.cboPcNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPcNumber.FormattingEnabled = true;
            this.cboPcNumber.Location = new System.Drawing.Point(142, 28);
            this.cboPcNumber.Name = "cboPcNumber";
            this.cboPcNumber.Size = new System.Drawing.Size(177, 20);
            this.cboPcNumber.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(142, 174);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(177, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(142, 101);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(177, 21);
            this.txtIdNumber.TabIndex = 2;
            // 
            // txtBeginTime
            // 
            this.txtBeginTime.Location = new System.Drawing.Point(142, 247);
            this.txtBeginTime.Name = "txtBeginTime";
            this.txtBeginTime.ReadOnly = true;
            this.txtBeginTime.Size = new System.Drawing.Size(177, 21);
            this.txtBeginTime.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBeginTime);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.cboPcNumber);
            this.groupBox1.Controls.Add(this.lblBeginTime);
            this.groupBox1.Controls.Add(this.lblIdPwd);
            this.groupBox1.Controls.Add(this.lblIdNumber);
            this.groupBox1.Controls.Add(this.lblPcNumber);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 311);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(85, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBegin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员上机";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPcNumber;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblIdPwd;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.ComboBox cboPcNumber;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtBeginTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
    }
}