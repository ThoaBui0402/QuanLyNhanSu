using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class PhanCong_ViTri
    {
        private string MaVT;
        private string MaNV;

        public string MaVT1
        {
            get
            {
                return MaVT;
            }

            set
            {
                MaVT = value;
            }
        }

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }
        public PhanCong_ViTri ( string manv, string mavt)
        {
            this.MaVT = mavt;
            this.MaNV = manv;
           
        }
    }
}
