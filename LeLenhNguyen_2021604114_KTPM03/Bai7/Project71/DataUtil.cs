using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project71
{
    internal class DataUtil
    {
        XmlDocument doc;
        string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\Bai7\Project71\Nganhang.xml";
        XmlElement root;

        public List<Taikhoan> HienThi()
        {
            List<Taikhoan> accountLists = new List<Taikhoan>();

            doc = new XmlDocument();
            doc.Load(file);

            XmlNodeList accounts = doc.SelectNodes("/nganhang/taikhoan");

            foreach (XmlNode acc in accounts)
            {
                Taikhoan account = new Taikhoan { 
                    SoTaiKhoan = acc["sotaikhoan"].InnerText,
                    TenTaiKhoan = acc["tentaikhoan"].InnerText,
                    DiaChi = acc["diachi"].InnerText,
                    DienThoai = acc["dienthoai"].InnerText,
                    SoTien = Convert.ToInt32(acc["sotien"].InnerText)
                };

                accountLists.Add(account);
            }

            return accountLists;
        }

        public bool ThemTaiKhoan(Taikhoan account)
        {
            doc = new XmlDocument();
            doc.Load(file);

            XmlNodeList nodeList = doc.SelectNodes("/nganhang/taikhoan");
            foreach (XmlNode node in nodeList)
            {
                if (node["sotaikhoan"].InnerText == account.SoTaiKhoan)
                {
                    return false;
                }
            }

            root = doc.DocumentElement;
            XmlElement tai_khoan = doc.CreateElement("taikhoan");

            XmlElement so_tk = doc.CreateElement("sotaikhoan");
            so_tk.InnerText = account.SoTaiKhoan;
            tai_khoan.AppendChild(so_tk);

            XmlElement ten_tk = doc.CreateElement("tentaikhoan");
            ten_tk.InnerText = account.TenTaiKhoan;
            tai_khoan.AppendChild(ten_tk);

            XmlElement dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = account.DiaChi;
            tai_khoan.AppendChild(dia_chi);
            
            XmlElement dien_thoai = doc.CreateElement("dienthoai");
            dien_thoai.InnerText = account.DienThoai;
            tai_khoan.AppendChild(dien_thoai);

            XmlElement so_tien = doc.CreateElement("sotien");
            so_tien.InnerText = account.SoTien.ToString();
            tai_khoan.AppendChild(so_tien);

            root.AppendChild(tai_khoan);
            doc.Save(file);

            return true;
        }

        public bool CapNhatTaiKhoan(Taikhoan tk)
        {
            doc = new XmlDocument();
            doc.Load(file);

            XmlNode node = doc.SelectSingleNode($"/nganhang/taikhoan[sotaikhoan='{tk.SoTaiKhoan}']");
            if (node != null) {
                node["tentaikhoan"].InnerText = tk.SoTaiKhoan;
                node["diachi"].InnerText = tk.DiaChi;
                node["dienthoai"].InnerText = tk.DienThoai;
                node["sotien"].InnerText = tk.SoTien.ToString();

                doc.Save(file);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaTaiKhoan(string sotk)
        {
            doc = new XmlDocument();
            doc.Load(file);

            XmlNode node = doc.SelectSingleNode($"/nganhang/taikhoan[sotaikhoan='{sotk}']");

            if (node != null) { 
                node.ParentNode.RemoveChild(node);
                doc.Save(file);
                return true;

            }
            else
            {
                return false;
            }
        }

        public Taikhoan TimTaiKhoan(string sotk)
        {
            doc = new XmlDocument();
            doc.Load(file);

            XmlNode node = doc.SelectSingleNode($"/nganhang/taikhoan[sotaikhoan='{sotk}']");

            if (node != null)
            {
                return new Taikhoan
                {
                    SoTaiKhoan = node["sotaikhoan"].InnerText,
                    TenTaiKhoan = node["tentaikhoan"].InnerText,
                    DiaChi = node["diachi"].InnerText,
                    DienThoai = node["dienthoai"].InnerText,
                    SoTien = Convert.ToInt32(node["sotien"].InnerText)
                };
            }
            else
            {
                return null;
            }
        }
    }
}
