using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class ChucVu
    {
        private string tencv;
        private string macv;


        public string Tencv
        {
            get
            {
                return tencv;
            }

            set
            {
                tencv = value;
            }
        }

        public string Macv
        {
            get
            {
                return macv;
            }

            set
            {
                macv = value;
            }
        }
        public ChucVu(string macv, string tencv)
        {
            this.Tencv = tencv;
            this.Macv = macv;
        }
    }
}
