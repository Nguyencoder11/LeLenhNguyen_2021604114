using De24305.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace De24305.Controllers
{
    public class ThoiTietTrongNgayController : ApiController
    {
        DBTTEntities db = new DBTTEntities();
        [HttpGet]
        public List<ThoiTietTrongNgay> ThongTinThoiTiet()
        {
            return db.ThoiTietTrongNgays.ToList();
        }

        [HttpPost]
        public bool Them(string makv, DateTime gio, decimal nhietdo, decimal doam)
        {
            ThoiTietTrongNgay tt = db.ThoiTietTrongNgays.FirstOrDefault(x => x.MaKhuVuc == makv && x.Gio == gio);
            if(tt == null)
            {
                ThoiTietTrongNgay tt1 = new ThoiTietTrongNgay { 
                    MaKhuVuc = makv,
                    Gio = gio,
                    NhietDo = nhietdo,
                    DoAm = doam
                };
                db.ThoiTietTrongNgays.Add(tt1);
                db.SaveChanges();

                return true;
            }

            return false;
        }

        [HttpDelete]
        public bool Xoa(string makv, DateTime gio)
        {
            ThoiTietTrongNgay tt = db.ThoiTietTrongNgays.FirstOrDefault(x => x.MaKhuVuc == makv && x.Gio == gio);
            if(tt != null)
            {
                db.ThoiTietTrongNgays.Remove(tt);
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
