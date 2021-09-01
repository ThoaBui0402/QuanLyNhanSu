using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            chenBang();
        }

        private void chenBang()
        {
            BindingSource soureTB = new BindingSource();
            soureTB.DataSource = ConnectDatabase.getAllNhanVien();
            dgwTotal.DataSource = soureTB;
        }
        private void btnfrmMain_PB_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar3_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem6_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar9_ItemClick(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BindingSource soureTB = new BindingSource();
            soureTB.DataSource = ConnectDatabase.getNhanVienTimDuoc(textBox1.Text);
            dgwTotal.DataSource = soureTB;
        }
    }
}
