using _2021604114_LeLenhNguyen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2021604114_LeLenhNguyen.Controllers
{
    public class NhanVienController : ApiController
    {
        db_qlnvEntities db = new db_qlnvEntities();

        [HttpGet]
        public List<NhanVien> DanhsachNV()
        {
            return db.NhanViens.ToList();
        }

        [HttpPost]
        public bool ThemNhanvien(int ma, string hoten, string trinhdo, int luong)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
            if (nv == null) {
                NhanVien nhanvien = new NhanVien { 
                    MaNV = ma,
                    HoTen = hoten,
                    TrinhDo = trinhdo,
                    Luong = luong
                };

                db.NhanViens.Add(nhanvien);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        [HttpDelete]
        public bool XoaNhanvien(int ma)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
            if(nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
