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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                // conn.Open();
                string tk = txtDanhNhap.Text;
             
                string mk = txtMatKhau.Text;
               // MessageBox.Show(mk);
                if (ConnectDatabase.Login(tk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                    Program.usernamelogin = tk;
                    Program.frMain_main = new frmMain();
                    Program.frMain_main.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập lỗi" + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDanhNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_Click(object sender, EventArgs e)
        {

        }

        private void txtQLNS_Click(object sender, EventArgs e)
        {

        }
    }
}
