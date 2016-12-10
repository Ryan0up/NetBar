namespace NetBar
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.tsmItems = new System.Windows.Forms.ToolStripMenuItem();
            this.sADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.计算机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.营业记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.联机帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUp = new System.Windows.Forms.ToolStripButton();
            this.tsbDown = new System.Windows.Forms.ToolStripButton();
            this.tsbChange = new System.Windows.Forms.ToolStripButton();
            this.tsbReg = new System.Windows.Forms.ToolStripButton();
            this.tsbPay = new System.Windows.Forms.ToolStripButton();
            this.tslTheme = new System.Windows.Forms.ToolStripLabel();
            this.tscTheme = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsdAdminLogin = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mspMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Enabled = false;
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItems,
            this.tsmUser,
            this.tsmVisual,
            this.tsmHelp,
            this.tsmExit});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(1140, 25);
            this.mspMenu.TabIndex = 0;
            this.mspMenu.Text = "menuStrip1";
            // 
            // tsmItems
            // 
            this.tsmItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sADToolStripMenuItem,
            this.下机ToolStripMenuItem,
            this.换机ToolStripMenuItem});
            this.tsmItems.Name = "tsmItems";
            this.tsmItems.ShortcutKeyDisplayString = "0";
            this.tsmItems.Size = new System.Drawing.Size(62, 21);
            this.tsmItems.Text = "业务(&Q)";
            // 
            // sADToolStripMenuItem
            // 
            this.sADToolStripMenuItem.Name = "sADToolStripMenuItem";
            this.sADToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sADToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sADToolStripMenuItem.Text = "上机";
            this.sADToolStripMenuItem.Click += new System.EventHandler(this.sADToolStripMenuItem_Click);
            // 
            // 下机ToolStripMenuItem
            // 
            this.下机ToolStripMenuItem.Name = "下机ToolStripMenuItem";
            this.下机ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.下机ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.下机ToolStripMenuItem.Text = "下机";
            this.下机ToolStripMenuItem.Click += new System.EventHandler(this.下机ToolStripMenuItem_Click);
            // 
            // 换机ToolStripMenuItem
            // 
            this.换机ToolStripMenuItem.Name = "换机ToolStripMenuItem";
            this.换机ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.换机ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.换机ToolStripMenuItem.Text = "换机";
            this.换机ToolStripMenuItem.Click += new System.EventHandler(this.换机ToolStripMenuItem_Click);
            // 
            // tsmUser
            // 
            this.tsmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem});
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.ShortcutKeyDisplayString = "";
            this.tsmUser.Size = new System.Drawing.Size(61, 21);
            this.tsmUser.Text = "用户(&U)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // tsmVisual
            // 
            this.tsmVisual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolBar,
            this.tsmiLook,
            this.toolStripSeparator1,
            this.计算机ToolStripMenuItem,
            this.会员卡ToolStripMenuItem,
            this.营业记录ToolStripMenuItem});
            this.tsmVisual.Name = "tsmVisual";
            this.tsmVisual.Size = new System.Drawing.Size(61, 21);
            this.tsmVisual.Text = "视图(&H)";
            // 
            // tsmiToolBar
            // 
            this.tsmiToolBar.Checked = true;
            this.tsmiToolBar.CheckOnClick = true;
            this.tsmiToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolBar.Name = "tsmiToolBar";
            this.tsmiToolBar.Size = new System.Drawing.Size(135, 22);
            this.tsmiToolBar.Text = "工具栏";
            this.tsmiToolBar.CheckedChanged += new System.EventHandler(this.tsmiToolBar_CheckedChanged);
            // 
            // tsmiLook
            // 
            this.tsmiLook.Checked = true;
            this.tsmiLook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLook.Name = "tsmiLook";
            this.tsmiLook.Size = new System.Drawing.Size(135, 22);
            this.tsmiLook.Text = "状态栏";
            this.tsmiLook.CheckedChanged += new System.EventHandler(this.tsmiLook_CheckedChanged);
            this.tsmiLook.Click += new System.EventHandler(this.tsmiLook_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // 计算机ToolStripMenuItem
            // 
            this.计算机ToolStripMenuItem.Name = "计算机ToolStripMenuItem";
            this.计算机ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.计算机ToolStripMenuItem.Text = "&1 计算机";
            this.计算机ToolStripMenuItem.Click += new System.EventHandler(this.计算机ToolStripMenuItem_Click);
            // 
            // 会员卡ToolStripMenuItem
            // 
            this.会员卡ToolStripMenuItem.Name = "会员卡ToolStripMenuItem";
            this.会员卡ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.会员卡ToolStripMenuItem.Text = "&2 会员卡";
            this.会员卡ToolStripMenuItem.Click += new System.EventHandler(this.会员卡ToolStripMenuItem_Click);
            // 
            // 营业记录ToolStripMenuItem
            // 
            this.营业记录ToolStripMenuItem.Name = "营业记录ToolStripMenuItem";
            this.营业记录ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.营业记录ToolStripMenuItem.Text = "&3 营业记录";
            this.营业记录ToolStripMenuItem.Click += new System.EventHandler(this.营业记录ToolStripMenuItem_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联机帮助ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmHelp.Text = "帮助(&H)";
            // 
            // 联机帮助ToolStripMenuItem
            // 
            this.联机帮助ToolStripMenuItem.Name = "联机帮助ToolStripMenuItem";
            this.联机帮助ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.联机帮助ToolStripMenuItem.Text = "联机帮助 (&I)";
            this.联机帮助ToolStripMenuItem.Click += new System.EventHandler(this.联机帮助ToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.关于AToolStripMenuItem.Text = "关于 (&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(59, 21);
            this.tsmExit.Text = "退出(&E)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUp,
            this.tsbDown,
            this.tsbChange,
            this.tsbReg,
            this.tsbPay,
            this.tslTheme,
            this.toolStripButton1,
            this.tscTheme});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1140, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUp
            // 
            this.tsbUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbUp.Image")));
            this.tsbUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUp.Name = "tsbUp";
            this.tsbUp.Size = new System.Drawing.Size(36, 37);
            this.tsbUp.Text = "上机";
            this.tsbUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUp.Click += new System.EventHandler(this.tsbUp_Click);
            // 
            // tsbDown
            // 
            this.tsbDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbDown.Image")));
            this.tsbDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDown.Name = "tsbDown";
            this.tsbDown.Size = new System.Drawing.Size(36, 37);
            this.tsbDown.Text = "下机";
            this.tsbDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDown.Click += new System.EventHandler(this.tsbDown_Click);
            // 
            // tsbChange
            // 
            this.tsbChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange.Image")));
            this.tsbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange.Name = "tsbChange";
            this.tsbChange.Size = new System.Drawing.Size(36, 37);
            this.tsbChange.Text = "换机";
            this.tsbChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbChange.Click += new System.EventHandler(this.tsbChange_Click);
            // 
            // tsbReg
            // 
            this.tsbReg.Image = ((System.Drawing.Image)(resources.GetObject("tsbReg.Image")));
            this.tsbReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReg.Name = "tsbReg";
            this.tsbReg.Size = new System.Drawing.Size(60, 37);
            this.tsbReg.Text = "注册会员";
            this.tsbReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbReg.Click += new System.EventHandler(this.tsbReg_Click);
            // 
            // tsbPay
            // 
            this.tsbPay.Image = ((System.Drawing.Image)(resources.GetObject("tsbPay.Image")));
            this.tsbPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPay.Name = "tsbPay";
            this.tsbPay.Size = new System.Drawing.Size(60, 37);
            this.tsbPay.Text = "会员充值";
            this.tsbPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPay.Click += new System.EventHandler(this.tsbPay_Click);
            // 
            // tslTheme
            // 
            this.tslTheme.Image = ((System.Drawing.Image)(resources.GetObject("tslTheme.Image")));
            this.tslTheme.Name = "tslTheme";
            this.tslTheme.Size = new System.Drawing.Size(56, 37);
            this.tslTheme.Text = "主题界面";
            this.tslTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tscTheme
            // 
            this.tscTheme.Items.AddRange(new object[] {
            "信笺纸",
            "MacOS",
            "炫酷",
            "暖色调",
            "Win XP"});
            this.tscTheme.Name = "tscTheme";
            this.tscTheme.Size = new System.Drawing.Size(121, 40);
            this.tscTheme.Text = "信笺纸";
            this.tscTheme.SelectedIndexChanged += new System.EventHandler(this.tscTheme_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdAdminLogin,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1140, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsdAdminLogin
            // 
            this.tsdAdminLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdAdminLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsdAdminLogin.Image")));
            this.tsdAdminLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAdminLogin.Name = "tsdAdminLogin";
            this.tsdAdminLogin.Size = new System.Drawing.Size(81, 21);
            this.tsdAdminLogin.Text = "管理员登录";
            this.tsdAdminLogin.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1010, 625);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAdminId
            // 
            this.lblAdminId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(78, 625);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 12);
            this.lblAdminId.TabIndex = 6;
            this.lblAdminId.TextChanged += new System.EventHandler(this.lblAdminId_TextChanged);
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Location = new System.Drawing.Point(90, 625);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(0, 12);
            this.lblAdminLogin.TabIndex = 8;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton1.Text = "锁屏";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 642);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网吧计费系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmItems;
        private System.Windows.Forms.ToolStripMenuItem sADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmVisual;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUp;
        private System.Windows.Forms.ToolStripButton tsbDown;
        private System.Windows.Forms.ToolStripButton tsbChange;
        private System.Windows.Forms.ToolStripButton tsbReg;
        private System.Windows.Forms.ToolStripButton tsbPay;
        private System.Windows.Forms.ToolStripComboBox tscTheme;
        private System.Windows.Forms.ToolStripLabel tslTheme;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 计算机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 营业记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsdAdminLogin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 联机帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

