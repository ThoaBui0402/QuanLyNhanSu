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
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
            this.dgvHienThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThi.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            disableInput();
            btnTV.Enabled = false;
        }
        private void disableInput()
        {
            txtMaHD.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            txtTenHD.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            dateBD.Enabled = false;
            dateKT.Enabled = false;
        }
        private void clearInput()
        {
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtTenHD.Text = "";
            dateBD.Value = DateTime.Now;
            dateKT.Value = DateTime.Now;
        }
        private void enableInput()
        {
            txtMaHD.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtTenHD.ReadOnly = false;

            dateBD.Enabled = true;
            dateKT.Enabled = true;
        }
        private void tbnXoa_Click(object sender, EventArgs e)
        {
            if (btnTV.Enabled == false)
            {
                this.tbnThem.Enabled = false;
                this.tbnSua.Enabled = false;
                this.tbnGiaHan.Enabled = false;
                //enableInput();
                disableInput();
                btnTV.Enabled = true;
                //txtMaHD.ReadOnly = true;

            }
            else
            {
                HopDong temp = new HopDong(txtMaHD.Text, txtTenHD.Text, txtMaNV.Text, dateBD.Value, dateKT.Value);
                ConnectDatabase.XoaHopDong(temp);
                MessageBox.Show("Xóa hợp đồng thành công!!");
                dgvHienThi.DataSource = ConnectDatabase.getAllHopDong();

            }
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            BindingSource soureTB = new BindingSource();
            soureTB.DataSource = ConnectDatabase.getAllHopDong();
            dgvHienThi.DataSource = soureTB;
        }

        private void dgvHienThi_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            if (table.Enabled == false) return;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenHD.Text = row.Cells[1].Value.ToString();
                dateBD.Value = row.Cells[2].Value == null ? DateTime.Now : (DateTime)row.Cells[2].Value;
                dateKT.Value = row.Cells[3].Value == null ? DateTime.Now : (DateTime)row.Cells[3].Value;
                txtMaHD.Text = row.Cells[4].Value.ToString();


            }
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            disableInput();
            this.tbnSua.Enabled = true;
            this.tbnXoa.Enabled = true;
            this.tbnGiaHan.Enabled = true;
            this.tbnThem.Enabled = true;

            btnTV.Enabled = false;
        }
    }
}
