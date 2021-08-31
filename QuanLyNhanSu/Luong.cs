using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class Luong
    {
        private string LuongNV;
        private string LuongThuong;
        private string MaNV;
        private string SoNgayTangCa;
        private string Chichu;
        private string TongLuong;
        public string LuongNV1

        {
            get
            {
                return LuongNV;
            }

            set
            {
                LuongNV = value;
            }
        }

        public string LuongThuong1
        {
            get
            {
                return LuongThuong;
            }

            set
            {
                LuongThuong = value;
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

        public string Chichu1
        {
            get
            {
                return Chichu;
            }

            set
            {
                Chichu = value;
            }
        }

        public string SoNgayTangCa1
        {
            get
            {
                return SoNgayTangCa;
            }

            set
            {
                SoNgayTangCa = value;
            }
        }

        public string TongLuong1
        {
            get
            {
                return TongLuong;
            }

            set
            {
                TongLuong = value;
            }
        }

        public Luong(string manv, string luong, string luongthuong, string ghichu, string songaytangca, string tongluong)
        {
            this.MaNV = manv;
            this.LuongNV = luong;
            this.LuongThuong = luongthuong;
            this.Chichu = ghichu;
            this.SoNgayTangCa = songaytangca;
            this.TongLuong = tongluong;
        }
    }
}
