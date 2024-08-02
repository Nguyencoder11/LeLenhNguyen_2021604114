using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project71
{
    internal class Taikhoan
    {
        private string so_tai_khoan;
        private string ten_tai_khoan;
        private string dia_chi;
        private string dien_thoai;
        private int so_tien;

        public string SoTaiKhoan
        {
            get => so_tai_khoan;
            set => so_tai_khoan = value;
        }
        public string TenTaiKhoan 
        { 
            get => ten_tai_khoan; 
            set => ten_tai_khoan = value; 
        }
        public string DiaChi 
        { 
            get => dia_chi; 
            set => dia_chi = value; 
        }
        public string DienThoai 
        { 
            get => dien_thoai; 
            set => dien_thoai = value; 
        }
        public int SoTien 
        { 
            get => so_tien; 
            set => so_tien = value; 
        }
    }
}
