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

        private void dgwTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static frmPhongBan form_phongban = new frmPhongBan();
        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {
            form_phongban = new frmPhongBan();
            form_phongban.Show();
        }

        private void ribbonBar7_ItemClick(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }
        public static frmChucVu frm_ChucVu;
        private void ribbonBar4_ItemClick(object sender, EventArgs e)
        { 
            frm_ChucVu = new frmChucVu();
            frm_ChucVu.Show();
       
    }

        private void ribbonBar10_ItemClick(object sender, EventArgs e)
        {

            frmHopDong frm = new frmHopDong();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
