using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace NetBar
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////修改主题////////////////////////////////////////////////////
        /// <summary>
        /// 改变组合框的选项的触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //定义变量储存用户选择的主题名称
            string Skin = this.tscTheme.SelectedItem.ToString();
            //调用储存在/bin/Debug/Skin中的主题
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + Skin.ToString()+""+".ssk"+"";
        }

        ////////////////////////////////////////////////程序加载子窗体////////////////////////////////////////////////////
        /// <summary>
        /// 程序加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //调用默认的主题
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\信笺纸.ssk";

            //管理员登陆窗体
            //将控件储存在数组里面
            List<Control> l = new List<Control>();
            l.Add(mspMenu);
            l.Add(toolStrip1);
            l.Add(lblAdminId);
            frmAdminLogin frmA = new frmAdminLogin(l);
            frmA.Show();
            frmA.MdiParent = this;
        }

        ////////////////////////////////////////////////菜单选项单击加载子窗体////////////////////////////////////////////////////
        /// <summary>
        /// 单击菜单项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmPC frm1 = new frmPC();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void 会员卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCard frm2 = new frmCard();
            frm2.MdiParent = this;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void 营业记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecord frm3 = new frmRecord();
            frm3.MdiParent = this;
            frm3.Dock = DockStyle.Fill;
            frm3.Show();
        }

        ////////////////////////////////////////////////工具栏的各个功能////////////////////////////////////////////////////
        /// <summary>
        /// 单击菜单栏的上机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUp_Click(object sender, EventArgs e)
        {
            frmBegin frmUp = new frmBegin();
            frmUp.Show();
        }
        /// <summary>
        /// 单击菜单栏的下机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDown_Click(object sender, EventArgs e)
        {
            frmEnd frmDown = new frmEnd();
            frmDown.Show();
        }
        /// <summary>
        /// 单击菜单栏的换机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbChange_Click(object sender, EventArgs e)
        {
            frmChange frmC = new frmChange();
            frmC.Show();
        }
        /// <summary>
        /// 单击菜单栏的注册按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbReg_Click(object sender, EventArgs e)
        {
            frmRegVip frmZ = new frmRegVip();
            frmZ.Show();
        }
        /// <summary>
        /// 单击菜单栏的充值按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPay_Click(object sender, EventArgs e)
        {
            frmPay frmP = new frmPay();
            frmP.Show();
        }
        /// <summary>
        /// 单击退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExit_Click(object sender, EventArgs e)
        {
            //定义DialogResult类型的变量来获取message box的返回值
            DialogResult dr = MessageBox.Show("是否退出","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            //如果用户点击了确定 则退出程序
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 单击修改会员密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRePwd frmR = new frmRePwd();
            frmR.Show();
        }
        /// <summary>
        /// 单击管理员登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            //将空间储存在数组里面
            List<Control> l = new List<Control>();
            l.Add(mspMenu);
            l.Add(toolStrip1);
            l.Add(lblAdminId);
            frmAdminLogin frmA = new frmAdminLogin(l);
            frmA.Show();
            frmA.MdiParent = this;
        }

        ////////////////////////////////////////////////单击隐藏显示工具栏和状态栏////////////////////////////////////////////////////
        /// <summary>
        /// 单击工具栏选项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiToolBar_Click(object sender, EventArgs e)
        {
            //如果有勾勾,去掉
            if (this.tsmiToolBar.Checked == true)
            {
                this.tsmiToolBar.Checked = false;
            }
            //否则加上勾勾
            else
            {
                this.tsmiToolBar.Checked = true;
            }
        }
        /// <summary>
        /// 工具栏选项的checked值发生改变的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiToolBar_CheckedChanged(object sender, EventArgs e)
        {
            //如果有勾勾 则显示工具栏
            if (this.tsmiToolBar.Checked == true)
            {
                this.toolStrip1.Visible = true;
            }
            else
            {
                this.toolStrip1.Visible = false;
            }
        }
        /// <summary>
        /// 单击菜单栏的选项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLook_Click(object sender, EventArgs e)
        {
            //如果有勾勾 去掉
            if (this.tsmiLook.Checked == true)
            {
                this.tsmiLook.Checked = false;
            }
            else
            {
                this.tsmiLook.Checked = true;
            }
        }
        /// <summary>
        /// 菜单栏选项的checked值发生改变的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLook_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tsmiLook.Checked == true)
            {
                this.statusStrip1.Visible = true;
                this.lblAdminId.Visible = true;
                this.lblTime.Visible = true;
            }
            else
            {
                this.statusStrip1.Visible = false;
                this.lblAdminId.Visible = false;
                this.lblTime.Visible = false;
            }
        }
        /// <summary>
        /// 单击选项触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 联机帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "ryanc.cc");
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAb = new frmAbout();
            frmAb.Show();
        }
        /// <summary>
        /// 菜单栏上机按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBegin frmUp = new frmBegin();
            frmUp.Show();
        }
        /// <summary>
        /// 菜单栏下机按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnd frmDown = new frmEnd();
            frmDown.Show();
        }
        /// <summary>
        /// 菜单栏换机按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 换机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange frmG = new frmChange();
            frmG.Show();
        }
        /// <summary>
        /// 计时器事件s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void lblAdminId_TextChanged(object sender, EventArgs e)
        {
            this.tsdAdminLogin.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLock frmL = new frmLock();
            frmL.ShowDialog();
        }
    }
}
