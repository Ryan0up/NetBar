namespace NetBar
{
    partial class frmUnlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnlock));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPwdU = new System.Windows.Forms.TextBox();
            this.lblPwdU = new System.Windows.Forms.Label();
            this.lblInfoA = new System.Windows.Forms.Label();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPwdU
            // 
            this.txtPwdU.Location = new System.Drawing.Point(607, 347);
            this.txtPwdU.Name = "txtPwdU";
            this.txtPwdU.PasswordChar = '*';
            this.txtPwdU.Size = new System.Drawing.Size(195, 21);
            this.txtPwdU.TabIndex = 2;
            // 
            // lblPwdU
            // 
            this.lblPwdU.AutoSize = true;
            this.lblPwdU.BackColor = System.Drawing.Color.Transparent;
            this.lblPwdU.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwdU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPwdU.Location = new System.Drawing.Point(532, 348);
            this.lblPwdU.Name = "lblPwdU";
            this.lblPwdU.Size = new System.Drawing.Size(69, 20);
            this.lblPwdU.TabIndex = 1;
            this.lblPwdU.Text = "密码：";
            // 
            // lblInfoA
            // 
            this.lblInfoA.AutoSize = true;
            this.lblInfoA.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoA.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfoA.ForeColor = System.Drawing.Color.Red;
            this.lblInfoA.Location = new System.Drawing.Point(562, 274);
            this.lblInfoA.Name = "lblInfoA";
            this.lblInfoA.Size = new System.Drawing.Size(39, 20);
            this.lblInfoA.TabIndex = 0;
            this.lblInfoA.Text = "Txt";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(651, 406);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(132, 39);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "解锁";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // frmUnlock
            // 
            this.AcceptButton = this.btnUnlock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 729);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.lblInfoA);
            this.Controls.Add(this.lblPwdU);
            this.Controls.Add(this.txtPwdU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "稍后回来";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUnlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPwdU;
        private System.Windows.Forms.Label lblPwdU;
        private System.Windows.Forms.Label lblInfoA;
        private System.Windows.Forms.Button btnUnlock;
    }
}