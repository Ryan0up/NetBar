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
    public partial class frmPC : Form
    {
        public frmPC()
        {
            InitializeComponent();
        }
        DBUtil db = new DBUtil();
        /// <summary>
        /// 定义方法
        /// </summary>
        public void ShowPC()
        {
            //定义变量储存sql执行语句
            string sql = "select * from PCInfo order by PCID asc";
            DataTable dt = db.GetQuery(sql);
            this.dgvPc.DataSource = dt.DefaultView;
            this.dgvPc.Columns[0].HeaderText = "电脑编号";
            this.dgvPc.Columns[1].HeaderText = "是否使用";
            this.dgvPc.Columns[2].HeaderText = "电脑描述";
        }
        /// <summary>
        /// 调用方法加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPC_Load(object sender, EventArgs e)
        {
            this.ShowPC();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowPC();
        }
    }
}
