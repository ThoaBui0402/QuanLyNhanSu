using QLNhanSu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmMain frMain_main;
        public static string usernamelogin = "";
        [STAThread]
        static void Main()
        {
            ConnectDatabase.ConnectDB();
          //  Application.Run(new HSNV());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            


        }
    }
}
