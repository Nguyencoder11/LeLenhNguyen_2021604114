using APICreatingPackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICreatingPackage.Controllers
{
    public class DonViController : ApiController
    {
        QLLuongEntities db = new QLLuongEntities();

        // Lay toan bo danh sach don vi
        [HttpGet]
        public List<DonVi> getDonVis()
        {
            return db.DonVis.ToList();
        }
    }
}
