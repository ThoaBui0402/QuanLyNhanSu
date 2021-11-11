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
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

      

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            DangNhap temp = new DangNhap( txtTenDN.Text, txtMK.Text, txtmanv.Text);

            ConnectDatabase.ThemTaiKhoan(temp);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
