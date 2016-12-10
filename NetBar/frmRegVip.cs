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
    public partial class frmRegVip : Form
    {
        public frmRegVip()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单击关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //创建连接数据库的工具类对象
        DBUtil db = new DBUtil();
        private void btnOk_Click(object sender, EventArgs e)
        {
            //获取数据
            string Id = this.txtId.Text;
            string Pwd = this.txtPwd.Text;
            string RePwd = this.txtRePwd.Text;
            int Mon = int.Parse(this.nudMoney.Text);
            //判断用户信息是否输入完整
            if (Id == "" || Pwd == "" || RePwd == "" || Mon == 0)
            {
                MessageBox.Show("请填写完整信息","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //判断两次密码是否一致
            if (Pwd != RePwd)
            {
                MessageBox.Show("两次密码不一样","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //清空密码框
                this.txtPwd.Clear();
                this.txtRePwd.Clear();
                //使密码框获得焦点
                this.txtPwd.Focus();
                return;
            }
            if (Pwd.Count() <= 5)
            {
                MessageBox.Show("密码不能小于6位","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtPwd.Clear();
                this.txtRePwd.Clear();
                this.txtPwd.Focus();
                return;
            }
            //判断用户名是否重复
            string sql1 = "select cardNumber from cardInfo where cardNumber='"+Id+"'";
            DataTable dt = db.GetQuery(sql1);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("用户名已存在！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtId.Clear();
                return;
            }
            //定义变量储存sql执行语句
            string sql2 = "insert into CardInfo values('"+Id+"','"+Pwd+"','"+Mon+"',getdate())";
            int row = db.GetZSG(sql2);
            //如果有返回值
            if (row > 0)
            {
                MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            else
            {
                MessageBox.Show("注册失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
