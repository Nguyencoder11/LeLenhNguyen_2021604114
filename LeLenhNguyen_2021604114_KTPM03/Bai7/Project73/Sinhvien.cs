using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project73
{
    internal class Sinhvien
    {
        private string masv;
        private string hoten;
        private int tuoi;
        private string diachi;
        private string dienthoai;

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int Tuoi 
        { 
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
    }
}
