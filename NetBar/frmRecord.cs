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
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
        }
        DBUtil db = new DBUtil();
        public void ShowRecord()
        {
            //定义变量储存sql执行语句
            string sql = "select recordId,cardNumber,PCID,begintime,endtime,free from RecordInfo ri inner join CardInfo ci on ri.cardId=ci.cardID";
            DataTable dt = db.GetQuery(sql);
            this.dgvRecord.DataSource = dt.DefaultView;
            this.dgvRecord.Columns["recordId"].HeaderText = "记录编号";
            this.dgvRecord.Columns["cardNumber"].HeaderText = "会员编号";
            this.dgvRecord.Columns["PCID"].HeaderText = "电脑编号";
            this.dgvRecord.Columns["begintime"].HeaderText = "上机时间";
            this.dgvRecord.Columns["endtime"].HeaderText = "下机时间";
            this.dgvRecord.Columns["free"].HeaderText = "上机费用";
        }
        /// <summary>
        /// 程序加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRecord_Load(object sender, EventArgs e)
        {
            //刷新
            this.ShowRecord();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowRecord();
        }
    }
}
