using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class ViTri
    {
        private string tenvt;
        private string mavt;

        public string Tenvt
        {
            get
            {
                return tenvt;
            }

            set
            {
                tenvt = value;
            }
        }

        public string Mavt
        {
            get
            {
                return mavt;
            }

            set
            {
                mavt = value;
            }
        }
        public ViTri(string mavt, string tenvt)
        {
            this.Tenvt = tenvt;
            this.Mavt = mavt;
        }
    }
}

