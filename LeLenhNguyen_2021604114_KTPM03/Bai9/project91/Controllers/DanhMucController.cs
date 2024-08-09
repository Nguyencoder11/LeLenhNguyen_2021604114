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
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            List<DanhMuc> danhMucs = context.DanhMucs.ToList();
            foreach(DanhMuc dm in danhMucs)
            {
                dm.SanPhams = null;
            }

            return danhMucs;
        }

        // Web API lay chi tiet mot danh muc san pham
        [HttpGet]
        public DanhMuc ChiTietDanhMuc(string id)
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == id);
            if (dm != null)
            {
                dm.SanPhams = null;
            }
            return dm;
        }

        // Web API để lưu 1 danh mục
        [HttpPost]
        public bool LuuDanhMuc(string madm, string tendm)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
                DanhMuc dm = new DanhMuc
                {
                    MaDanhMuc = madm,
                    TenDanhMuc = tendm
                };
                context.DanhMucs.InsertOnSubmit(dm);
                context.SubmitChanges();

                return true;
            }

            catch { }
            return false;
        }


        // Web API de sua 1 danh muc
        [HttpPut]
        public bool SuaDanhMuc(string madm, string tendm)
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);

            if(dm != null)
            {
                dm.TenDanhMuc = tendm;
                context.SubmitChanges();
                return true;
            }

            return false;
        }


        // Web API ded xoa 1 danh muc
        [HttpDelete]
        public bool XoaDanhMuc(string madm)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
                DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);
                if (dm != null)
                {
                    context.DanhMucs.DeleteOnSubmit(dm);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
