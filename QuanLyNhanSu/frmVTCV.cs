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
    public partial class frmVTCV : Form
    {
        public frmVTCV()
        {
            InitializeComponent();
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            ViTri temp = new ViTri(txtMaVT.Text, txtTenVT.Text);
            ConnectDatabase.XoaViTri(temp);
            dgvVT.DataSource = ConnectDatabase.getAllViTri();
        }

        private void frmVTCV_Load(object sender, EventArgs e)
        {
            this.dgvVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVT.DataSource = ConnectDatabase.getAllViTri();

        }

        private void dgvVT_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaVT.Text = row.Cells[0].Value.ToString();
                txtTenVT.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
