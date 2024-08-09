using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Project93.Controllers
{
    public class DonViController : ApiController
    {
        string dbUrl = "Data Source=DESKTOP-4B4DR8B\\SQLEXPRESS;Initial Catalog=QLLuong;Integrated Security=True;Encrypt=False";

        // Web API lay toan bo danh sach don vi
        [HttpGet]
        public List<DonVi> LayToanBoDonVi()
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            List<DonVi> donvis = db.DonVis.ToList();
            foreach (DonVi dv in donvis)
            {
                dv.NhanViens = null;
            }
            return donvis;
        }

        // Web API lay chi tiet 1 don vi
        [HttpGet]
        public DonVi ChiTietMotDonVi(string madv)
        {
            QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
            DonVi donvi = db.DonVis.FirstOrDefault(x => x.MaDonVi == madv);
            if (donvi != null)
            {
                donvi.NhanViens = null;
            }

            return donvi;
        }

        // Web API luu 1 don vi
        [HttpPost]
        public bool LuuDonVi(string madv, string tendv)
        {
            try
            {
                QLLuongDBDataContext db = new QLLuongDBDataContext(dbUrl);
                DonVi dv = new DonVi
                {
                    MaDonVi = madv,
                    TenDonVi = tendv
                };
                db.DonVis.InsertOnSubmit(dv);
                db.SubmitChanges();

                return true;
            }
            catch { }
            return false;
        }
    }
}
