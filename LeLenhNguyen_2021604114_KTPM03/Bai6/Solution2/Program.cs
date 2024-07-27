using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Solution2
{
    internal class Program
    {
        static string filePath = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\Bai6\Solution2\Sanpham.xml";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNodeList lists = doc.SelectNodes("/sieuthi/sanpham");

                foreach (XmlNode sanpham in lists) 
                {
                    XmlNode ma_sp = sanpham.SelectSingleNode("masp");
                    XmlNode ten = sanpham.SelectSingleNode("tensp");
                    XmlNode sl = sanpham.SelectSingleNode("soluong");

                    Console.WriteLine($"Mã sản phẩm: {ma_sp.InnerText} - Tên sản phẩm: {ten.InnerText} - Số lượng: {sl.InnerText}");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
