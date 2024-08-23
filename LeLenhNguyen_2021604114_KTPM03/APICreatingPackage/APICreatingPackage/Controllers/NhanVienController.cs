using APICreatingPackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICreatingPackage.Controllers
{
    public class NhanVienController : ApiController
    {
        QLLuongEntities db = new QLLuongEntities();

        // Lay toan bo danh sach nhan vien
        public List<NhanVien> getNhanViens()
        {
            return db.NhanViens.ToList();
        }
        // Lay danh sach nhan vien theo don vi
        [HttpGet]
        public List<NhanVien> getNhanViensByDonVi(string madv)
        {
            return db.NhanViens.Where(x => x.MaDonVi == madv).ToList();
        }

        // Lay danh sach nhan vien theo gioi tinh
        [HttpGet]
        public List<NhanVien> getNhanViensByGioiTinh(string gender)
        {
            return db.NhanViens.Where(x => x.GioiTinh == gender).ToList();
        }

        // Tim danh sach nhan vien co he so luong theo khoang [a....b]
        public List<NhanVien> getNhanViensByHSL(decimal a, decimal b)
        {
            return db.NhanViens.Where(x => x.Hsluong >= a && x.Hsluong <= b).ToList();
        }

        // Them moi mot nhan vien
        [HttpPost]
        public bool AddNhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, decimal hsl, string madv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma == manv);
            if (nv == null)
            {
                NhanVien newNV = new NhanVien { 
                    Ma = manv,
                    HoTen = hoten,
                    NgaySinh = ngaysinh,
                    GioiTinh = gioitinh,
                    Hsluong = hsl,
                    MaDonVi = madv
                };

                db.NhanViens.Add(newNV);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        // Sua mot nhan vien
        [HttpPut]
        public bool UpdateNhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, decimal hsl, string madv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma == manv);
            if(nv != null)
            {
                nv.Ma = manv;
                nv.HoTen = hoten;
                nv.NgaySinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                nv.Hsluong = hsl;
                nv.MaDonVi = madv;

                db.SaveChanges();
                return true;
            }

            return false;
        }


        // Xoa 1 nhan vien
        [HttpDelete]
        public bool DeleteNhanVien(string id) {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma == id);
            if (nv != null) {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
