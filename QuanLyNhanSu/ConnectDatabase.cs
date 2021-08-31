using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Data.OleDb;
using QuanLyNhanSu;

namespace QuanLyNhanSu
{
    class ConnectDatabase
    {
        static SqlConnection conn;


        public static void ConnectDB()
        {
            conn = new SqlConnection(@"Data Source=MAYTINH-3FOQHGV\ADMIN;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
            conn.Open();
        }

        
        public static bool Login(string tk, string mk)
        {
            string sql = "select * from [DANGNHAP] where TenDN=@usr and MatKhau=@pass";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@usr", tk));
                command.Parameters.Add(new SqlParameter("@pass", mk));

                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        Program.usernamelogin = tk;
                        return true;
                    }


                }

            }
            return false;
        }
        public static void thayDoiMatKhau(string tk, string mk)
        {
            string sql = "UPDATE DANGNHAP set MatKhau=@mk where TenDN=@tk";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mk", mk));
                command.Parameters.Add(new SqlParameter("@tk", tk));

                command.ExecuteNonQuery();
                command.Cancel();
            }
        }

        public static DataTable getAllNhanVien()
        {
            string sql = "select * from NHANVIEN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public static int checkNhanVien(string manv)
        {

            string sql = "select * from NHANVIEN n where ((MaNV like '%' + @text + '%'))";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", manv));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        public static void ThemNhanVien(NhanVien nhanvien)
        {

            string sql = "insert into NHANVIEN(MaNV, HoTen, BangCap, GioiTinh, NgaySinh, DiaChi, MaPB, CMTND, SDT, DanToc, TonGiao) values(@manv, @tennv, @bangcap, @gioitinh, CONVERT(date, @ngaysinh, 111), @diachi, @mapb, @cmt, @sdt, @dt, @tg)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", nhanvien.Manv));
                command.Parameters.Add(new SqlParameter("@tennv", nhanvien.Tennv));
                command.Parameters.Add(new SqlParameter("@bangcap", nhanvien.Bangcap));
                command.Parameters.Add(new SqlParameter("@gioitinh", nhanvien.Gt));
                command.Parameters.Add(new SqlParameter("@ngaysinh", nhanvien.Ngaysinh.GetDateTimeFormats()[6]));
                command.Parameters.Add(new SqlParameter("@diachi", nhanvien.Diachi));
                command.Parameters.Add(new SqlParameter("@mapb", nhanvien.Mapb));
                command.Parameters.Add(new SqlParameter("@cmt", nhanvien.Cmt));
                command.Parameters.Add(new SqlParameter("@sdt", nhanvien.Sdt));
                command.Parameters.Add(new SqlParameter("@dt", nhanvien.Dantoc));
                command.Parameters.Add(new SqlParameter("@tg", nhanvien.Tongiao));




                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!");
                }
                else MessageBox.Show("Thêm nhân viên mới thất bại!");
                command.Cancel();


            }
        }
    }
}

