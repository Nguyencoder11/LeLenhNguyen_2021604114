using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    internal class Employee
    {
        private string manv;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private double hesoluong;


        public string MaNV {
            get { return manv; } 
            set { manv = value; } 
        }

        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string DiaChi
        {
            get => diachi;
            set => diachi = value;
        }

        public double HeSoLuong
        { 
            get { return hesoluong; }
            set { hesoluong = value; } 
        }

        public Employee(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, double hesoluong)
        {
            MaNV = manv;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            DiaChi = diachi;
            HeSoLuong = hesoluong;
        }

    }
}
