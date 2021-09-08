using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


//sua de thu nghiem

namespace QuanLyNhanSu
{
    public partial class frmThemPB : Form
    {
        public frmThemPB()
        {
            InitializeComponent();
            txtTenTp.ReadOnly = true;
        }
        ConnectDatabase db = new ConnectDatabase();
       
        
        public void load()
        {

            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();
        }

 
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
         
            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();
        }

        private void frmThemPB_Load(object sender, EventArgs e)
        {
            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();

        }

        private void txtmaTP_TextChanged(object sender, EventArgs e)
        {
            txtTenTp.Text = ConnectDatabase.getTenTruongPhongTuMaTruongPhong(txtmaTP.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            load();
            this.Close();
            
        }

        private void dgvThemPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenTp_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_them_Click(object sender, EventArgs e)
        {
            PhongBan temp = new PhongBan(txtMaPB.Text, txtTenPB.Text, txtDiaChi.Text, txtmaTP.Text, txtTenTp.Text);
            {

                if (ConnectDatabase.checkPhongBan(temp.Mapb) == 1)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại. Xin mời nhập lại!!!");
                    return;

                }
                ConnectDatabase.ThemPhongBan(temp);
                dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();
                load();
            }
        }
    }
}

