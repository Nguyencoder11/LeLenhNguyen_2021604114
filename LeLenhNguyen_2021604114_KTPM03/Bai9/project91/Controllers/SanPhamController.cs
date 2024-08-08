using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project91.Controllers
{
    public class SanPhamController : ApiController
    {
        string conn_string = "Data Source=DESKTOP-4B4DR8B\\SQLEXPRESS;Initial Catalog=CSDLQLBanHang;Integrated Security=True;Encrypt=False";

        // Web API lay toan bo san pham
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach(SanPham s in dsSP)
            {
                s.DanhMuc = null;
            }
            return dsSP;
        }

        // Web API lay chi tiet mot san pham
        [HttpGet]
        public SanPham ChiTietSanPham(string id)
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            SanPham sp = context.SanPhams.FirstOrDefault(x => x.Ma == id);
            if(sp != null)
            {
                sp.DanhMuc = null;
            }
            return sp;

        }

        // Web API lay danh sach san pham theo danh muc
        [HttpGet]
        public List<SanPham> DanhSachSanPhamTheoDanhMuc(string madm)
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            List<SanPham> dsSP = context.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
            foreach (SanPham s in dsSP)
            {
                s.DanhMuc = null;
            }
            return dsSP;
        }


        // Web API tim danh sach san pham co gia trong doan [a,b]
        [HttpGet]
        public List<SanPham> TimDanhSachSanPhamCoGiaTrongDoan(int a, int b)
        {
            CSDLTestDataContext context = new CSDLTestDataContext(conn_string);
            List<SanPham> dsSP = context.SanPhams.Where(x => x.DonGia>=a && x.DonGia<=b).ToList();
            foreach(SanPham s in dsSP)
            {
                s.DanhMuc = null;
            }
            return dsSP;
        }

    }
}
