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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            this.dgvPhongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongBan.DataSource = ConnectDatabase.getAllPhongBan();
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            PhongBan temp = new PhongBan(txtMPB.Text, txtTenPB.Text, txtdiadiem.Text, txtmaTP.Text, txtTenTP.Text);
            ConnectDatabase.XoaPhongBan(temp);
            dgvPhongBan.DataSource = ConnectDatabase.getAllPhongBan();
            MessageBox.Show("Xóa Phòng Ban Thành Công!!!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvPhongBan.DataSource = ConnectDatabase.getAllPhongBan();
        }

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMPB.Text = row.Cells[0].Value.ToString();
                txtTenPB.Text = row.Cells[1].Value.ToString();
                txtdiadiem.Text = row.Cells[2].Value.ToString();
                txtmaTP.Text = row.Cells[3].Value.ToString();
                txtTenTP.Text = row.Cells[4].Value.ToString();

            }
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {

            frmThemPB frm = new frmThemPB();
            frm.Show();
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            PhongBan temp = new PhongBan(txtMPB.Text, txtTenPB.Text, txtdiadiem.Text, txtmaTP.Text, txtTenTP.Text);
            ConnectDatabase.SuaPhongBan(temp);
            dgvPhongBan.DataSource = ConnectDatabase.getAllPhongBan();
        }

        private void txtRimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvPhongBan.DataSource = ConnectDatabase.timKiemPhongBan(txtRimKiem.Text);
        }
    }
}
