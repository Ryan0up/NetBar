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
    public partial class frmRePwd : Form
    {
        public frmRePwd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单击关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DBUtil db = new DBUtil();
        /// <summary>
        /// //////////////////////////程序加载时加载数据////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRePwd_Load(object sender, EventArgs e)
        {
            //定义变量储存sql执行语句
            string sql = "select * from CardInfo";
            //调用
            DataTable dt = db.GetQuery(sql);
            //绑定数据源
            this.cboIdNumber.DataSource = dt.DefaultView;
            //指定显示的数据
            this.cboIdNumber.DisplayMember = "cardNumber";
        }

        /// <summary>
        ///////////////////////////////////修改密码功能实现///////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //获取控件的值
            string Id = this.cboIdNumber.Text;
            string pwd = this.txtIdPwd.Text;
            string NewPwd = this.txtNewPwd.Text;
            string reNewPwd = this.txtReNewPwd.Text;
            //判断是否输入完整信息
            if (Id == "" || pwd == "" || NewPwd == "" || reNewPwd == "")
            {
                MessageBox.Show("请输入完整信息！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (NewPwd != reNewPwd)
            {
                MessageBox.Show("两次密码不一致","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtNewPwd.Clear();
                this.txtReNewPwd.Clear();
                this.txtNewPwd.Focus();
                return;
            }
            if (NewPwd.Count() <= 5)
            {
                MessageBox.Show("密码不能低于6位","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtNewPwd.Clear();
                this.txtReNewPwd.Clear();
                this.txtNewPwd.Focus();
                return;
            }
            //定义变量储存sql执行语句
            string sql = "select * from CardInfo where cardNumber='" + Id + "' and cardPassWord='"+pwd+"'";
            //调用
            DataTable dt = db.GetQuery(sql);
            //判断密码是否输入错误
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("密码输入错误","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtIdPwd.Clear();
                this.txtIdPwd.Focus();
                return;
            }
            //定义变量储存sql执行语句(修改密码)
            string sqlFix = "update CardInfo set cardPassWord='" + NewPwd + "' where cardNumber='" + Id + "'";
            //调用执行
            int Fix = db.GetZSG(sqlFix);
            //判断是否修改成功
            if (Fix > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("未知错误","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
