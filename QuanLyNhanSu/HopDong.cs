using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class HopDong
    {
        private string maHD;
        private string tenHD;
        private string maNV;
        private string tenNV;
        private DateTime dateBD;
        private DateTime dateKT;

        public string MaHD
        {
            get
            {
                return maHD;
            }

            set
            {
                maHD = value;
            }
        }

        public string TenHD
        {
            get
            {
                return tenHD;
            }

            set
            {
                tenHD = value;
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

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public DateTime DateBD
        {
            get
            {
                return dateBD;
            }

            set
            {
                dateBD = value;
            }
        }

        public DateTime DateKT
        {
            get
            {
                return dateKT;
            }

            set
            {
                dateKT = value;
            }


        }

        public HopDong()
        {

        }
        public HopDong(string mahd, string tenhd, string manv, DateTime datebd, DateTime datekt)
        {
            this.MaHD = mahd;
            this.MaNV = manv;
            this.tenHD = tenhd;
            this.dateBD = datebd;
            this.dateKT = datekt;

        }
    }
}
