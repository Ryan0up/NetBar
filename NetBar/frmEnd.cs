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
    public partial class frmEnd : Form
    {
        public frmEnd()
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
        /// ////////////////////////////////////////////获取正在上机的机器编号////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEnd_Load(object sender, EventArgs e)
        {
            //定义变量储存sql执行语句
            string sql = "select * from PCInfo where PCUse=1";
            //调用方法查询
            DataTable dt = db.GetQuery(sql);
            //绑定数据源
            this.cboPcNumber.DataSource = dt.DefaultView;
            this.cboPcNumber.DisplayMember = "PCID";
            //判断是否由数据
            if (dt.Rows.Count == 0)
            {
                this.btnOk.Enabled = false;
            }
            //将下机时间显示为系统当前时间
            this.txtEndTime.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //动态更新
            this.txtEndTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// /////////////////////////////////////////////改变cbo的值 获取数据////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPcNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取各个控件的值
            int pcId = int.Parse(this.cboPcNumber.Text);
            //查询该计算机正在上机的记录
            string sql = "select * from RecordInfo ri inner join CardInfo ci on ri.cardId=ci.cardID where ri.PCId=" + pcId + " and ri.endtime is null";
            //调用方法查询数据
            DataTable dt = db.GetQuery(sql);
            //判断
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有找到这个电脑上机的记录");
                return;
            }
            //计算用时和费用
            DateTime bt = Convert.ToDateTime(dt.Rows[0]["begintime"]);
            DateTime et = DateTime.Now;
            TimeSpan ts = Convert.ToDateTime(et).Subtract(bt);
            int seconds = (int)ts.TotalSeconds;
            int minutes = seconds / 60;
            if (seconds % 60 > 0)
            {
                //60以下按一分钟算
                minutes++;
            }
            int hours = minutes / 60;
            if (minutes % 60 > 0)
            {
                //60分钟以内按一小时算
                hours++;
            }
            int fee = hours * 2;
            //输出值
            this.txtBeginTime.Text = dt.Rows[0]["begintime"].ToString();
            this.txtIdNumber.Text = dt.Rows[0]["cardNumber"].ToString();
            this.txtAllTime.Text = hours.ToString();
            this.txtPrice.Text = fee.ToString();
        }
        /// <summary>
        /// ////////////////////////////////////单击确定以修改各个表的数据//////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            int pcID = int.Parse(this.cboPcNumber.Text);
            string cardId = this.txtIdNumber.Text;
            int fee=int.Parse(this.txtPrice.Text);
            //修改计算机的状态
            string sql = "update PCInfo set PCUse = 0 where PCID='" + pcID + "'";
            int pc = db.GetZSG(sql);
            //修改记录表中的下机时间和费用
            string sql1 = "update RecordInfo set endtime=getDate(),free='" + fee + "' where PCId= '"+pcID+"' and endtime is null";
            int timeFee = db.GetZSG(sql1);
            //扣除会员的上机费用
            string sql2 = "update CardInfo set cardBalance-='" + fee + "' where cardNumber='" + cardId + "'";
            int KouFee = db.GetZSG(sql2);
            //判断三者是否修改成功
            if (pc > 0 && timeFee > 0 && KouFee > 0)
            {
                MessageBox.Show("下机成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
