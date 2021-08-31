using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu
{
    class DangNhap
    {
        private string tenDN;
        private string matKhau;
        private string maNV;

        public string TenDN
        {
            get
            {
                return tenDN;
            }

            set
            {
                tenDN = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }
        public DangNhap(string TenDN,string MatKhau, string MaNV)
        {
            this.tenDN = TenDN;
            this.matKhau = MatKhau;
            this.maNV = MaNV;
        }
    }
}
