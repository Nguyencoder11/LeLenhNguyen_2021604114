using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OnTapTX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\OnTapTX2\OnTapTX2\BangGiaXe.xml";
        int d;
        XmlDocument doc = new XmlDocument();

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            dataXe.Rows.Clear();
            doc.Load(filename);

            XmlNodeList hangxes = doc.SelectNodes("/banggiaxe/hangxe");

            dataXe.ColumnCount = 5;

            foreach(XmlNode hangxe in hangxes)
            {
                string ten_hang = hangxe.Attributes["ten"].Value;

                XmlNodeList dongxes = hangxe.SelectNodes("dongxe");
                foreach (XmlNode dongxe in dongxes)
                {
                    string ten_dong = dongxe.Attributes["ten"].Value;
                    string phien_ban = dongxe.SelectSingleNode("phienban").InnerText;
                    string dong_co = dongxe.SelectSingleNode("dongco").InnerText;
                    string gia = dongxe.SelectSingleNode("gia").InnerText;

                    dataXe.Rows.Add(ten_hang, ten_dong, phien_ban, dong_co, gia);
                }
            }
        }

        private void dataXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtHangXe.Text = dataXe.Rows[d].Cells[0].Value.ToString();
            txtDongXe.Text = dataXe.Rows[d].Cells[1].Value.ToString();
            txtPhienBan.Text = dataXe.Rows[d].Cells[2].Value.ToString();
            txtDongCo.Text = dataXe.Rows[d].Cells[3].Value.ToString();
            txtGia.Text = dataXe.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(filename);

            string tenHang = txtHangXe.Text.Trim();
            string tenDong = txtDongXe.Text.Trim();
            string phienBan = txtPhienBan.Text.Trim();
            string dongCo = txtDongCo.Text.Trim();
            string gia = txtGia.Text.Trim();

            XmlNode hangXeNode = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten='{tenHang}']");
            if (hangXeNode != null)
            {
                XmlNode dongXeNode = hangXeNode.SelectSingleNode($"dongxe[@ten='{tenDong}']");
                if (dongXeNode != null)
                {
                    MessageBox.Show("Thong tin da ton tai");
                    return;
                }
            }

            if (hangXeNode == null)
            {
                hangXeNode = doc.CreateElement("hangxe");
                XmlAttribute attrTenHang = doc.CreateAttribute("ten");
                attrTenHang.Value = tenHang;
                hangXeNode.Attributes.Append(attrTenHang);
                doc.DocumentElement.AppendChild(hangXeNode);
            }

            XmlElement dongxeElement = doc.CreateElement("dongxe");
            XmlAttribute attrTenDong = doc.CreateAttribute("ten");
            attrTenDong.Value = tenDong;
            dongxeElement.Attributes.Append(attrTenDong);

            XmlElement phienBanElement = doc.CreateElement("phienban");
            phienBanElement.InnerText = phienBan;
            dongxeElement.AppendChild(phienBanElement);

            XmlElement dongCoElement = doc.CreateElement("dongco");
            dongCoElement.InnerText = dongCo;
            dongxeElement.AppendChild(dongCoElement);

            XmlElement giaElement = doc.CreateElement("gia");
            giaElement.InnerText = gia;
            dongxeElement.AppendChild(giaElement);

            hangXeNode.AppendChild(dongxeElement);

            doc.Save(filename);

            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (d >= 0)
            {
                doc.Load(filename);

                string tenHang = txtHangXe.Text.Trim();
                string tenDong = txtDongXe.Text.Trim();
                string phienBan = txtPhienBan.Text.Trim();
                string dongCo = txtDongCo.Text.Trim();
                string gia = txtGia.Text.Trim();

                XmlNode hangxeNode = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten='{tenHang}']");
                if (hangxeNode != null)
                {
                    XmlNode dongxeNode = hangxeNode.SelectSingleNode($"dongxe[@ten='{tenDong}']");
                    if (dongxeNode != null)
                    {
                        dongxeNode.SelectSingleNode("phienban").InnerText = phienBan;
                        dongxeNode.SelectSingleNode("dongco").InnerText = dongCo;
                        dongxeNode.SelectSingleNode("gia").InnerText = gia;

                        doc.Save(filename);
                        HienThi();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (d >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    doc.Load(filename);

                    string tenHang = txtHangXe.Text.Trim();
                    string tenDong = txtDongXe.Text.Trim();

                    XmlNode hangxeNode = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten='{tenHang}']");
                    if (hangxeNode != null)
                    {
                        XmlNode dongxeNode = hangxeNode.SelectSingleNode($"dongxe[@ten='{tenDong}']");
                        if (dongxeNode != null)
                        {
                            hangxeNode.RemoveChild(dongxeNode);
                            if (!hangxeNode.HasChildNodes)
                            {
                                doc.DocumentElement.RemoveChild(hangxeNode);
                            }

                            doc.Save(filename);
                            HienThi();
                        }
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataXe.Rows.Clear();
            doc.Load(filename);

            string tenHang = txtHangXe.Text.Trim();
            XmlNode hangxeNode = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten='{tenHang}']");

            if (hangxeNode != null)
            {
                XmlNodeList dongxes = hangxeNode.SelectNodes("dongxe");
                foreach (XmlNode dongxe in dongxes)
                {
                    string ten_dong = dongxe.Attributes["ten"].Value;
                    string phien_ban = dongxe.SelectSingleNode("phienban").InnerText;
                    string dong_co = dongxe.SelectSingleNode("dongco").InnerText;
                    string gia = dongxe.SelectSingleNode("gia").InnerText;

                    dataXe.Rows.Add(tenHang, ten_dong, phien_ban, dong_co, gia);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
        }

        private void txtHangXe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHangXe.Text))
            {
                HienThi();
            }
        }
    }
}
