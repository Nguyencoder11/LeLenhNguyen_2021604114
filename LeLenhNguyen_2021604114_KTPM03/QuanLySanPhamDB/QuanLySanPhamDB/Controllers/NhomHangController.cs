using QuanLySanPhamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySanPhamDB.Controllers
{
    public class NhomHangController : ApiController
    {
        QuanLySanPhamDBEntities db = new QuanLySanPhamDBEntities();
        [HttpGet]
        public List<NhomHang> getNhomHangs()
        {
            return db.NhomHangs.ToList();
        }
    }
}
