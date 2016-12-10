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
    public partial class frmPay : Form
    {
        public frmPay()
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
        //////////////////////////////////////////实现充值及显示余额///////////////////////////////////////
        /// <summary>
        /// 单击确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //获取数据
            string cardNumber =this.cboFrom.Text;
            int Money=int.Parse(this.nudMoney.Text);
            //创建sql执行语句
            string sql = "update CardInfo set cardBalance+='"+Money+"' where cardNumber='"+cardNumber+"'";
            string sql1 = "select cardBalance from CardInfo where cardNumber='" + cardNumber + "'";
            //调用
            int row = db.GetZSG(sql);
            DataTable dt = db.GetQuery(sql1);
            //定义sum设置要输出的值
            string sum = string.Format("充值成功,充值后的余额为{0}", dt.Rows[0]["cardBalance"]);
            //如果有返回值 则弹框输出
            if (row > 0)
            {
                MessageBox.Show(sum,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// ////////////////////////////////////////加载卡号///////////////////////////////////////
        /// </summary>
        DBUtil db = new DBUtil();
        /// <summary>
        /// 加载卡号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPay_Load(object sender, EventArgs e)
        {
            //创建sql执行语句
            string sql = "select cardNumber from CardInfo";
            DataTable dt = db.GetQuery(sql);
            //绑定数据源
            this.cboFrom.DataSource = dt.DefaultView;
            this.cboFrom.DisplayMember = "cardNumber";
        }
    }
}
