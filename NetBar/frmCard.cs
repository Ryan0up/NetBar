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
    public partial class frmCard : Form
    {
        public frmCard()
        {
            InitializeComponent();
        }
        DBUtil db = new DBUtil();
        //定义方法
        public void ShowCard()
        {
            //创建sql执行语句
            string sql = "select cardId,cardNumber,cardBalance,TransactTime from CardInfo order by CardId asc";
            //调用
            DataTable dt = db.GetQuery(sql);
            //绑定数据源
            this.dgvCard.DataSource = dt.DefaultView;
            this.dgvCard.Columns[0].HeaderText = "编号";
            this.dgvCard.Columns[1].HeaderText = "卡号";
            this.dgvCard.Columns[2].HeaderText = "余额";
            this.dgvCard.Columns[3].HeaderText = "办理时间";
        }
        /// <summary>
        /// 调用方法加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCard_Load(object sender, EventArgs e)
        {
            this.ShowCard();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowCard();
        }
    }
}
