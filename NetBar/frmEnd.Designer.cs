namespace NetBar
{
    partial class frmEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAllTime = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAllTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtBeginTime = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.cboPcNumber = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblPcNumber = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtAllTime);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblAllTime);
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.txtBeginTime);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.cboPcNumber);
            this.groupBox1.Controls.Add(this.lblEndTime);
            this.groupBox1.Controls.Add(this.lblBeginTime);
            this.groupBox1.Controls.Add(this.lblIdNumber);
            this.groupBox1.Controls.Add(this.lblPcNumber);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(280, 249);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(61, 21);
            this.txtPrice.TabIndex = 4;
            // 
            // txtAllTime
            // 
            this.txtAllTime.Location = new System.Drawing.Point(142, 249);
            this.txtAllTime.Name = "txtAllTime";
            this.txtAllTime.ReadOnly = true;
            this.txtAllTime.Size = new System.Drawing.Size(61, 21);
            this.txtAllTime.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(233, 252);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "费用：";
            // 
            // lblAllTime
            // 
            this.lblAllTime.AutoSize = true;
            this.lblAllTime.Location = new System.Drawing.Point(95, 252);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(41, 12);
            this.lblAllTime.TabIndex = 3;
            this.lblAllTime.Text = "用时：";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(142, 190);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(199, 21);
            this.txtEndTime.TabIndex = 2;
            // 
            // txtBeginTime
            // 
            this.txtBeginTime.Location = new System.Drawing.Point(142, 136);
            this.txtBeginTime.Name = "txtBeginTime";
            this.txtBeginTime.ReadOnly = true;
            this.txtBeginTime.Size = new System.Drawing.Size(199, 21);
            this.txtBeginTime.TabIndex = 2;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(142, 82);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.ReadOnly = true;
            this.txtIdNumber.Size = new System.Drawing.Size(199, 21);
            this.txtIdNumber.TabIndex = 2;
            // 
            // cboPcNumber
            // 
            this.cboPcNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPcNumber.FormattingEnabled = true;
            this.cboPcNumber.Location = new System.Drawing.Point(142, 28);
            this.cboPcNumber.Name = "cboPcNumber";
            this.cboPcNumber.Size = new System.Drawing.Size(199, 20);
            this.cboPcNumber.TabIndex = 1;
            this.cboPcNumber.SelectedIndexChanged += new System.EventHandler(this.cboPcNumber_SelectedIndexChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(71, 193);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(65, 12);
            this.lblEndTime.TabIndex = 0;
            this.lblEndTime.Text = "下机时间：";
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(71, 139);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(65, 12);
            this.lblBeginTime.TabIndex = 0;
            this.lblBeginTime.Text = "上机时间：";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(71, 85);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(53, 12);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "会员号：";
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(86, 330);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
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
            // frmEnd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员下机";
            this.Load += new System.EventHandler(this.frmEnd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBeginTime;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.ComboBox cboPcNumber;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblPcNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAllTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAllTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
    }
}