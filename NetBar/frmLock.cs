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
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmUnlock frmUn = new frmUnlock();//实例化Form2窗体
            frmUn.infos = txtInfo.Text.Trim();//传递挂机信息
            frmUn.pwd = txtPwd.Text.Trim();//传递解锁密码
            frmUn.ShowDialog();//打开Form2窗体
            this.Hide();
        }

        private void frmLock_Load(object sender, EventArgs e)
        {
            this.txtPwd.Focus();
        }
    }
}
