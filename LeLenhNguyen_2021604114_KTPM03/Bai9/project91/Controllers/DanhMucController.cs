using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project91.Controllers
{
    public class DanhMucController : ApiController
    {
        string conn_string = "Data Source=DESKTOP-4B4DR8B\\SQLEXPRESS;Initial Catalog=CSDLQLBanHang;Integrated Security=True;Encrypt=False";

        // Web API lay toan bo danh muc san pham
        [HttpGet]
        public IHttpActionResult LayToanBoDanhMuc()
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
                var dsDanhMuc = context.DanhMucs.Select(dm => new
                {
                    dm.MaDanhMuc,
                    dm.TenDanhMuc,
                    SanPhams = dm.SanPhams.Select(sp => new { sp.Ma, sp.Ten }).ToList() // Customize serialization
                }).ToList();

                return Ok(dsDanhMuc);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }



        // Web API lay chi tiet mot danh muc san pham
        [HttpGet]
        public IHttpActionResult ChiTietDanhMuc(string id)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
                var danhMuc = context.DanhMucs
                    .Where(dm => dm.MaDanhMuc == id)
                    .Select(dm => new
                    {
                        dm.MaDanhMuc,
                        dm.TenDanhMuc,
                        SanPhams = dm.SanPhams.Select(sp => new { sp.Ma, sp.Ten }).ToList() // Customize serialization
                    })
                    .FirstOrDefault();

                if (danhMuc == null)
                {
                    return NotFound();
                }

                return Ok(danhMuc);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
