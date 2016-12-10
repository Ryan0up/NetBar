using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NetBar
{
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单击取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //创建数据库的工具类对象
        DBUtil db = new DBUtil();
        /// <summary>
        ///////////////////////////////////////////////程序加载时获取没有占用的机器编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //定义变量储存sql执行语句
            string sql = "select PCID from PCInfo where PCUse=0";
            //调用方法查询数据
            DataTable dt = db.GetQuery(sql);
            //绑定数据源
            this.cboPcNumber.DataSource = dt.DefaultView;
            //指定显示字段
            this.cboPcNumber.DisplayMember = "PCID";
            //判断是否有空闲的机器
            if(dt.Rows.Count==0)
            {
                this.btnOk.Enabled = false;
                return;
            }
            //得到系统当前时间并显示到文本输入框中
            this.txtBeginTime.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// ////////////////////////////////////////////动态显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //得到系统当前时间并显示到文本输入框中
            this.txtBeginTime.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// //////////////////////////////////////////实现上机功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //获取各个文本框的值
            int PCID = int.Parse(this.cboPcNumber.Text);
            string pwd = this.txtPwd.Text;
            string Id = this.txtIdNumber.Text;
            ////////////////////////////////判断信息是否输入完整
            if (Id == "" || pwd == "")
            {
                MessageBox.Show("请输入完整信息","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //查询用户名和密码有没有相应的值在数据库
            //定义变量储存sql执行语句
            string sql = "select * from CardInfo where cardNumber = '" + Id + "' and cardPassword='" + pwd + "'";
            //调用方法
            DataTable dt = db.GetQuery(sql);
            //判断
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("用户名或密码输入错误，请重新输入！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtPwd.Clear();
                this.txtPwd.Focus();
                return;
            }
            //////////////////////////////如果密码和账户对应 再判断余额是否不足
            //构建sql语句
            string sql1 = "select * from cardInfo where cardNumber='" + Id + "' and cardBalance>5";
            //调用方法
            DataTable dt1 = db.GetQuery(sql1);
            //判断是否查询到数据
            if (dt1.Rows.Count == 0)
            {
                DialogResult dr = MessageBox.Show("余额不足请充值！","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                //如果用户单击了确定 则弹出充值框
                if (dr == DialogResult.OK)
                {
                    frmPay frmP = new frmPay();
                    frmP.Show();
                }
                else
                {
                    this.Close();
                }
                return;
            }

            //判断该会员是否在上机
            string sql2 = "select * from RecordInfo where cardId='" + dt.Rows[0][0] + "' and endtime is null";
            //调用方法
            DataTable dt2 = db.GetQuery(sql2);
            //判断是否查询到数据
            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("该会员正在上机！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //以上查询条件都满足上级 那么修改计算机数据
            string sql3 = "update PCInfo set PCUse=1 where PCID='" + PCID + "'";
            //调用方法
            int row = db.GetZSG(sql3);
            //插入上机记录
            string sql4 = string.Format("insert into RecordInfo values({0},{1},'{2}',null,0)", dt.Rows[0]["cardID"], PCID, DateTime.Now.ToString());
            //调用方法
            int row1 = db.GetZSG(sql4);
            //判断
            if (row > 0 && row1 > 0)
            {
                MessageBox.Show("上机成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdNumber.Clear();
                this.txtPwd.Clear();
                return;
            }
            else
            {
                MessageBox.Show("上机失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
