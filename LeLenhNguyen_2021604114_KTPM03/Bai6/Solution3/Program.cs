using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Solution3
{
    internal class Program
    {
        static string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\Bai6\Solution3\Congty.xml";

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            XmlNodeList lists = doc.SelectNodes("/congty/nhanvien");
            foreach (XmlNode nv in lists)
            {
                XmlNode ma_nv = nv.SelectSingleNode("@manv");
                XmlNode ho_ten = nv.SelectSingleNode("hoten");
                XmlNode tuoi = nv.SelectSingleNode("tuoi");
                XmlNode luong = nv.SelectSingleNode("luong");
                XmlNode xa = nv.SelectSingleNode("diachi/xa");
                XmlNode huyen = nv.SelectSingleNode("diachi/huyen");
                XmlNode tinh = nv.SelectSingleNode("diachi/tinh");
                XmlNode dien_thoai = nv.SelectSingleNode("dienthoai");

                Console.WriteLine($"Mã nhân viên: {ma_nv.InnerText} - Họ tên: {ho_ten.InnerText} - Tuổi: {tuoi.InnerText} - Lương: {luong.InnerText} - Địa chỉ: {xa.InnerText}, {huyen.InnerText}, {tinh.InnerText} - Điện thoại: {dien_thoai.InnerText}");
            }
        }
    }
}
