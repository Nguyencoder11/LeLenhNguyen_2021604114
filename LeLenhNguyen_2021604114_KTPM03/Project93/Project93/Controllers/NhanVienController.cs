using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project93.Controllers
{
    public class NhanVienController : ApiController
    {
        string dbUrl = "Data Source=DESKTOP-4B4DR8B\\SQLEXPRESS;Initial Catalog=QLLuong;Integrated Security=True;Encrypt=False";

        // Web API lay toan bo danh sach nhan vien
        [HttpGet]
        public List<NhanVien> LayToanBoNhanVien()
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            List<NhanVien> nhanviens = db.NhanViens.ToList();
            foreach (NhanVien nv in nhanviens) {
                nv.DonVi = null;
            }

            return nhanviens;
        }

        // Web API lay chi tiet 1 nhan vien
        [HttpGet]
        public NhanVien ChiTietNhanVien(string manv)
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma == manv);
            if(nv != null)
            {
                nv.DonVi = null;
            }
            return nv;
        }

        // Web API lay danh sach nhan vien theo donvi
        [HttpGet]
        public List<NhanVien> DanhSachNhanVienTheoDonVi(string madv)
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            List<NhanVien> dsNV = db.NhanViens.Where(x => x.MaDonVi == madv).ToList();
            foreach(NhanVien nv in dsNV)
            {
                nv.DonVi = null;
            }
            return dsNV;
        }

        // Web API lay danh sach nhan vien theo gioi tinh
        [HttpGet]
        public List<NhanVien> DanhSachNhanVienTheoGT(string gioitinh)
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            List<NhanVien> dsNV = db.NhanViens.Where(x => x.GioiTinh == gioitinh).ToList();
            foreach( NhanVien nv in dsNV)
            {
                nv.DonVi = null;
            }
            return dsNV;
        }

        // Web API tim ds nhan vien co he so luong trong khoang [a,b]
        [HttpGet]
        public List<NhanVien> DanhSachNhanVienCoKhoangLuongAB(decimal a, decimal b)
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            List<NhanVien> dsNV = db.NhanViens.Where(x => x.Hsluong >= a && x.Hsluong <= b).ToList();
            foreach (NhanVien nv in dsNV)
            {
                nv.DonVi = null;
            }
            return dsNV;
        }


        // Web API luu 1 nhan vien
        [HttpPost]
        public bool LuuNhanVien(string manv, string tennv, DateTime ngaysinh, string gioitinh, decimal hsluong, string madv)
        {
            try
            {
                QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
                NhanVien nv = new NhanVien
                {
                    Ma = manv,
                    HoTen = tennv,
                    NgaySinh = ngaysinh,
                    GioiTinh = gioitinh,
                    Hsluong = hsluong,
                    MaDonVi = madv
                };
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();

                return true;
            }
            catch { }

            return false;
        }


    }
}
