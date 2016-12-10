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
    public partial class frmAdminLogin : Form
    {
        List<Control> all;
        public frmAdminLogin(List<Control> arr)
        {
            all = arr;
            InitializeComponent();
        }
        /// <summary>
        /// 单击关闭窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 单击管理员登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        DBUtil db = new DBUtil();
        private void btnOk_Click(object sender, EventArgs e)
        {
            string admin = this.txtAdmin.Text;
            string pwd = this.txtAdminPwd.Text;
            if (admin == "" || pwd == "")
            {
                MessageBox.Show("请输入完整信息！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //构建sql语句
            string sql = "select * from userinfo where userName='"+admin+"'and userPwd='"+pwd+"'";
            //调用方法查询
            DataTable dt = db.GetQuery(sql);
            if (dt.Rows.Count > 0)
            {
                //关闭此窗体
                this.Close();
                //循环改变控件的值
                foreach(Control s in all)
                {
                    all[0].Enabled = true;
                    all[1].Enabled = true;
                    all[2].Text = string.Format("{0}", admin);
                }
                MessageBox.Show("登陆成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("用户名或密码错误！请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAdminPwd.Clear();
                this.txtAdmin.Clear();
                //得到焦点
                this.txtAdmin.Focus();
            }
        }
    }
}
