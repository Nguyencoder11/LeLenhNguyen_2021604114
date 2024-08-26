using QuanLySanPhamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySanPhamDB.Controllers
{
    public class SanPhamController : ApiController
    {
        QuanLySanPhamDBEntities db = new QuanLySanPhamDBEntities();
        [HttpGet]
        public List<SanPham> DanhSachSP()
        {
            return db.SanPhams.ToList();
        }

        [HttpGet]
        [Route("api/sanpham/dssoluong")]
        public List<SanPham> DSSoLuong()
        {
            return db.SanPhams.Where(sp => sp.SoLuongBan > 5).ToList();
        }

        [HttpPost]
        public bool ThemSP(int masp, string tensp, double dongia, int slban, double tienban, int manh)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == masp);
            if(sp == null)
            {
                SanPham sp1 = new SanPham
                {
                    MaSP = masp,
                    TenSP = tensp,
                    DonGia = dongia,
                    SoLuongBan = slban,
                    TienBan = tienban,
                    MaNhomHang = manh
                };

                db.SanPhams.Add(sp1);
                db.SaveChanges();
                return true;
            }

            return false;
        }


        [HttpPut]
        public bool SuaSP(int masp, string tensp, double dongia, int slban, double tienban, int manh)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == masp);
            if(sp != null)
            {
                sp.TenSP = tensp;
                sp.DonGia = dongia;
                sp.SoLuongBan = slban;
                sp.TienBan = tienban;
                sp.MaNhomHang = manh;

                db.SaveChanges();
                return true;
            }


            return false;
        }


        [HttpDelete]
        public bool XoaSP(int id)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == id);
            if (sp != null) {

                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
