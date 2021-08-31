using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class PhongBan
    {
        private string mapb;
        private string tenpb;
        private string diachi;
        private string matp;
        private string tentp;


        public string Mapb
        {
            get
            {
                return mapb;
            }

            set
            {
                mapb = value;
            }
        }

        public string Tenpb
        {
            get
            {
                return tenpb;
            }

            set
            {
                tenpb = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Matp
        {
            get
            {
                return matp;
            }

            set
            {
                matp = value;
            }
        }

        public string Tentp
        {
            get
            {
                return tentp;
            }

            set
            {
                tentp = value;
            }
        }
        public PhongBan()
        {

        }
        public PhongBan(string mapb, string tenpb, string diachi, string matp, string tentp)
        {
            this.Mapb = mapb;
            this.Tenpb = tenpb;
            this.Diachi = diachi;
            this.Matp = matp;
            this.Tentp = tentp;
        }
    }
}
