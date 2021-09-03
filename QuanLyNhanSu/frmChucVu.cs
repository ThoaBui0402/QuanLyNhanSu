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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            ChucVu temp = new ChucVu(txtMaCV.Text, txtTenCV.Text);
            ConnectDatabase.XoaChucVu(temp);
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
            MessageBox.Show("Xóa Thành Công Chức Vụ!!!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void dgvCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void dgvCV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaCV.Text = row.Cells[0].Value.ToString();
                txtTenCV.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
