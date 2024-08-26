using QLNV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLNV.Controllers
{
    public class NhanVienController : ApiController
    {
        db_qlnvEntities db = new db_qlnvEntities();
        public List<NhanVien> GetAllNhanViens()
        {
            return db.NhanViens.ToList();
        }

        public IHttpActionResult Post(NhanVien x)
        {
            if (GetAllNhanViens().Any(y => y.MaNV == x.MaNV))
            {
                return BadRequest();
            }

            db.NhanViens.Add(x);
            db.SaveChanges();
            return Ok();
        }

        public IHttpActionResult Put(NhanVien x) {
            NhanVien nv = db.NhanViens.FirstOrDefault(z => z.MaNV == x.MaNV);
            if (nv == null)
            {
                return NotFound();
            }
            nv.HoTen = x.HoTen;
            nv.TrinhDo = x.TrinhDo;
            nv.Luong = x.Luong;

            db.SaveChanges();
            return Ok();
        }

        public IHttpActionResult Delete(int ma) {
            NhanVien nv = db.NhanViens.FirstOrDefault(z => z.MaNV == ma);
            if (nv == null)
            {
                return NotFound();
            }

            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return Ok();
        }

        public NhanVien GetSearch(int ma)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
        }
    }
}
