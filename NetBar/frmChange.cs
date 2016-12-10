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
    public partial class frmChange : Form
    {
        public frmChange()
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
        /// 加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChange_Load(object sender, EventArgs e)
        {
            //创建sql执行语句查询正在上机的机器
            string sqlz = "select PCID from PCInfo where PCUse = 1";
            //调用
            DataTable dt = db.GetQuery(sqlz);
            //绑定数据源
            this.cboFrom.DataSource = dt.DefaultView;
            this.cboFrom.DisplayMember = "PCID";
            //创建sql执行语句查询空闲的机器
            string sqly = "select PCID from PCInfo where PCUse = 0";
            //调用
            DataTable dt1 = db.GetQuery(sqly);
            //绑定数据源
            this.cboTo.DataSource = dt1.DefaultView;
            this.cboTo.DisplayMember = "PCID";
            if (dt.Rows.Count == 0)
            {
                this.btnOk.Enabled = false;
                return;
            }
        }
        /// <summary>
        /// /////////////////////////////////实现换机功能//////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //更改计算机的状态
            int Use = int.Parse(this.cboFrom.Text);
            int unUse = int.Parse(this.cboTo.Text);
            //创建sql执行语句
            string sql = "update PCInfo set PCUse=0 where PCID='" + Use + "'";
            string sql2 = "update PCInfo set PCUse=1 where PCID='"+unUse+"'";
            //调用
            int count = db.GetZSG(sql);
            int count1 = db.GetZSG(sql2);
            //查询记录编号
            string sql3 = "select RecordId from RecordInfo where PCId='" + Use + "'";
            //调用
            DataTable RecordID = db.GetQuery(sql3);
            //根据记录编号修改计算机BH
            string sql4 = "update RecordInfo set PCID = '" + unUse + "' where PCID='" + Use + "' and endTime is null";
            //调用
            int Fix = db.GetZSG(sql4);
            string Message = string.Format("换机成功,从{0}号机换到{1}",Use,unUse);
            if (count > 0 && count1 > 0 && Fix > 0)
            {
                MessageBox.Show(Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("换机失败！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
