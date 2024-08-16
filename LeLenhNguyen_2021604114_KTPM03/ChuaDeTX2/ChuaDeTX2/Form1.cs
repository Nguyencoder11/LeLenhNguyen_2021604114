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

namespace ChuaDeTX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\ChuaDeTX2\ChuaDeTX2\CongTy.xml";
        int d;

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            dataNhanVien.Rows.Clear();
            doc.Load(file);

            XmlNodeList nhanviens = doc.SelectNodes("/congty/nhanvien");
            //int sd = 0;

            dataNhanVien.ColumnCount = 5;
            //dataNhanVien.Rows.Add();

            // Hien thi theo cach su dung XmlNode thong thg
            //foreach (XmlNode nv in nhanviens)
            //{
            //    XmlNode ma_nv = nv.SelectSingleNode("manv");
            //    dataNhanVien.Rows[sd].Cells[0].Value = ma_nv.InnerText;
            //    XmlNode ho_ten = nv.SelectSingleNode("hoten");
            //    dataNhanVien.Rows[sd].Cells[1].Value = ho_ten.InnerText;
            //    XmlNode noi_sinh = nv.SelectSingleNode("noisinh");
            //    dataNhanVien.Rows[sd].Cells[2].Value = noi_sinh.InnerText;
            //    XmlNode ten_nn = nv.SelectSingleNode("ngoaingu/@tennn");
            //    dataNhanVien.Rows[sd].Cells[3].Value = ten_nn.InnerText;
            //    XmlNode trinh_do = nv.SelectSingleNode("ngoaingu/trinhdo");
            //    dataNhanVien.Rows[sd].Cells[4].Value = trinh_do.InnerText;

            //    dataNhanVien.Rows.Add();

            //    sd++;
            //}

            foreach (XmlNode nv in nhanviens)
            {
                string ma_nv = nv.SelectSingleNode("manv").InnerText;
                string ho_ten = nv.SelectSingleNode("hoten").InnerText;
                string noi_sinh = nv.SelectSingleNode("noisinh").InnerText;
                string ten_nn = nv.SelectSingleNode("ngoaingu").Attributes["tennn"].Value;
                string trinh_do = nv.SelectSingleNode("ngoaingu/trinhdo").InnerText;

                dataNhanVien.Rows.Add(ma_nv, ho_ten, noi_sinh, ten_nn, trinh_do);
            }
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtMaNV.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtMaNV.ReadOnly = true;
            txtHoTen.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            txtNoiSinh.Text = dataNhanVien.Rows[d].Cells[2].Value.ToString();
            txtNgoaiNgu.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();
            txtTrinhDo.Text = dataNhanVien.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(file);

            string manv = txtMaNV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string noisinh = txtNoiSinh.Text.Trim();
            string tennn = txtNgoaiNgu.Text.Trim();
            string trinhdo = txtTrinhDo.Text.Trim();

            XmlNode nhanvien = doc.SelectSingleNode($"/congty/nhanvien[manv='{manv}']");
            if(nhanvien != null)
            {
                MessageBox.Show("Trùng mã nhân viên");
                return;
            }

            XmlNode nhan_vien = doc.CreateElement("nhanvien");

            XmlNode ma_nv = doc.CreateElement("manv");
            ma_nv.InnerText = manv;
            nhan_vien.AppendChild(ma_nv);
            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = hoten;
            nhan_vien.AppendChild(ho_ten);
            XmlNode noi_sinh = doc.CreateElement("noisinh");
            noi_sinh.InnerText = noisinh;
            nhan_vien.AppendChild(noi_sinh);
            XmlNode ngoai_ngu = doc.CreateElement("ngoaingu");
            XmlAttribute ten_nn = doc.CreateAttribute("tennn");
            ten_nn.InnerText = tennn;
            ngoai_ngu.Attributes.Append(ten_nn);
            XmlNode trinh_do = doc.CreateElement("trinhdo");
            trinh_do.InnerText = trinhdo;
            ngoai_ngu.AppendChild(trinh_do);
            nhan_vien.AppendChild(ngoai_ngu);

            doc.DocumentElement.AppendChild(nhan_vien);

            doc.Save(file);

            HienThi();

            clearTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            
            string noisinh = txtNoiSinh.Text.Trim();
            string tennn = txtNgoaiNgu.Text.Trim();

            XmlNode nhanvien = doc.SelectSingleNode($"/congty/nhanvien[manv='{txtMaNV.Text.Trim()}' and noisinh='{noisinh}' and ngoaingu/@tennn='{tennn}']");

            if(nhanvien != null)
            {
                if(noisinh == "Hà Nội" && tennn == "Anh")
                {
                    nhanvien.SelectSingleNode("hoten").InnerText = txtHoTen.Text.Trim();
                    nhanvien.SelectSingleNode("ngoaingu/trinhdo").InnerText = txtTrinhDo.Text.Trim();

                    doc.Save(file);

                    HienThi();

                    clearTextBox();

                    txtMaNV.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Không được sửa");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            string noisinh = txtNoiSinh.Text.Trim();

            XmlNodeList nhanviens = doc.SelectNodes($"/congty/nhanvien[noisinh='{noisinh}']");
            if (nhanviens.Count > 0)
            {
                foreach (XmlNode nv in nhanviens)
                {
                    doc.DocumentElement.RemoveChild(nv);
                }

                doc.Save(file);

                HienThi();

                clearTextBox();
            }
            else
            {
                MessageBox.Show("Không có nơi sinh này");
            }
        }

        private void clearTextBox()
        {
            txtMaNV.Text = null;
            txtHoTen.Text = null;
            txtNoiSinh.Text = null;
            txtNgoaiNgu.Text = null;
            txtTrinhDo.Text = null;
        }
    }
}
