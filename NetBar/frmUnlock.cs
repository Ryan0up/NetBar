using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace NetBar
{
    public partial class frmUnlock : Form
    {
        public frmUnlock()
        {
            InitializeComponent();
        }
        //获取挂机信息和密码
        public string infos;
        public string pwd;
        /// <summary>
        /// 传信息到解锁窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUnlock_Load(object sender, EventArgs e)
        {
            this.lblInfoA.Text = infos;
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (this.txtPwdU.Text == pwd)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// 禁止运行任务管理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcesses();//获取所有系统运行的进程
            foreach (Process p1 in p)//遍历进程
            {
                try
                {
                    //如果进程中存在名为“taskmgr”，则说明任务管理器已经打开   
                    if (p1.ProcessName.ToLower().Trim() == "taskmgr")
                    {
                        p1.Kill();//关掉任务管理器的进程
                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
