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
            conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=QLNhanSu;Integrated Security=True");
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

    }
}
