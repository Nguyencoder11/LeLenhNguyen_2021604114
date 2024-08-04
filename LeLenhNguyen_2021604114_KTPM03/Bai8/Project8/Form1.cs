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

namespace Project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        int d;
        string filepath = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\Bai8\Project8\congty.xml";

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(filepath);
            XmlElement root = doc.DocumentElement;

            XmlNode nv_del = root.SelectSingleNode($"/congty/nhanvien[@manv='{txtMa.Text}']");

            if(nv_del != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Confirm Delete", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    root.RemoveChild(nv_del);

                    doc.Save(filepath);

                    LoadData();
                    clearTextbox();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên cần xóa");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(filepath);
            XmlElement root = doc.DocumentElement;

            if (doc.SelectSingleNode($"/congty/nhanvien[@manv='{txtMa.Text}']") != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                return;
            }

            XmlNode nv_moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            nv_moi.Attributes.Append(ma_nv);
            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = txtHoten.Text;
            nv_moi.AppendChild(hoten);
            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = txtTuoi.Text;
            nv_moi.AppendChild(tuoi);
            XmlElement luong = doc.CreateElement("luong");
            luong.InnerText = txtLuong.Text;
            nv_moi.AppendChild(luong);
            XmlElement diachi = doc.CreateElement("diachi");
            XmlElement xa = doc.CreateElement("xa");
            xa.InnerText = txtXa.Text;
            XmlElement huyen = doc.CreateElement("huyen");
            huyen.InnerText = txtHuyen.Text;
            XmlElement tinh = doc.CreateElement("tinh");
            tinh.InnerText = txtTinh.Text;
            diachi.AppendChild(xa);
            diachi.AppendChild(huyen);
            diachi.AppendChild(tinh);
            nv_moi.AppendChild(diachi);
            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = txtDienthoai.Text;
            nv_moi.AppendChild(dienthoai);

            root.AppendChild(nv_moi);

            doc.Save(filepath);

            LoadData();
            clearTextbox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(filepath);
            XmlElement root = doc.DocumentElement;

            XmlNode nv_cu = root.SelectSingleNode($"/congty/nhanvien[@manv='{txtMa.Text}']");

            if (nv_cu != null)
            {
                XmlNode nv_moi = doc.CreateElement("nhanvien");
                XmlAttribute ma_nv = doc.CreateAttribute("manv");
                ma_nv.InnerText = txtMa.Text;
                nv_moi.Attributes.Append(ma_nv);
                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = txtHoten.Text;
                nv_moi.AppendChild(hoten);
                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = txtTuoi.Text;
                nv_moi.AppendChild(tuoi);
                XmlElement luong = doc.CreateElement("luong");
                luong.InnerText = txtLuong.Text;
                nv_moi.AppendChild(luong);
                XmlElement diachi = doc.CreateElement("diachi");
                XmlElement xa = doc.CreateElement("xa");
                xa.InnerText = txtXa.Text;
                XmlElement huyen = doc.CreateElement("huyen");
                huyen.InnerText = txtHuyen.Text;
                XmlElement tinh = doc.CreateElement("tinh");
                tinh.InnerText = txtTinh.Text;
                diachi.AppendChild(xa);
                diachi.AppendChild(huyen);
                diachi.AppendChild(tinh);
                nv_moi.AppendChild(diachi);
                XmlElement dienthoai = doc.CreateElement("dienthoai");
                dienthoai.InnerText = txtDienthoai.Text;
                nv_moi.AppendChild(dienthoai);

                root.ReplaceChild(nv_moi, nv_cu);

                doc.Save(filepath);

                LoadData();
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            doc.Load(filepath);

            XmlNode nhanvien = doc.DocumentElement.SelectSingleNode($"/congty/nhanvien[@manv='{txtMa.Text}']");

            if(nhanvien != null)
            {
                dataNhanvien.Rows.Clear();
                dataNhanvien.ColumnCount = 6;

                dataNhanvien.Rows.Add();

                XmlNode ma_nv = nhanvien.SelectSingleNode("@manv");
                dataNhanvien.Rows[0].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = nhanvien.SelectSingleNode("hoten");
                dataNhanvien.Rows[0].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode tuoi = nhanvien.SelectSingleNode("tuoi");
                dataNhanvien.Rows[0].Cells[2].Value = tuoi.InnerText.ToString();
                XmlNode luong = nhanvien.SelectSingleNode("luong");
                dataNhanvien.Rows[0].Cells[3].Value = luong.InnerText.ToString();
                XmlNode xa = nhanvien.SelectSingleNode("diachi/xa");
                XmlNode huyen = nhanvien.SelectSingleNode("diachi/huyen");
                XmlNode tinh = nhanvien.SelectSingleNode("diachi/tinh");
                dataNhanvien.Rows[0].Cells[4].Value = xa.InnerText.ToString() + ", " + huyen.InnerText.ToString() + ", " + tinh.InnerText.ToString();
                XmlNode dien_thoai = nhanvien.SelectSingleNode("dienthoai");
                dataNhanvien.Rows[0].Cells[5].Value = dien_thoai.InnerText.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataNhanvien.Rows.Clear();
            doc.Load(filepath);

            XmlNodeList nhanviens = doc.SelectNodes("/congty/nhanvien");
            int sd = 0;
            int employeeCount = 0, totalSalary = 0, provinceEmployeeCount = 0;
            string specificProvince = "Ha Noi";

            dataNhanvien.ColumnCount = 6;
            dataNhanvien.Rows.Add();

            foreach(XmlNode nhanvien in nhanviens)
            {
                XmlNode ma_nv = nhanvien.SelectSingleNode("@manv");
                dataNhanvien.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = nhanvien.SelectSingleNode("hoten");
                dataNhanvien.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode tuoi = nhanvien.SelectSingleNode("tuoi");
                dataNhanvien.Rows[sd].Cells[2].Value = tuoi.InnerText.ToString();
                XmlNode luong = nhanvien.SelectSingleNode("luong");
                int salary = int.Parse(luong.InnerText.ToString());
                dataNhanvien.Rows[sd].Cells[3].Value = salary;
                XmlNode xa = nhanvien.SelectSingleNode("diachi/xa");
                XmlNode huyen = nhanvien.SelectSingleNode("diachi/huyen");
                XmlNode tinh = nhanvien.SelectSingleNode("diachi/tinh");
                string province = tinh.InnerText.ToString();
                dataNhanvien.Rows[sd].Cells[4].Value = xa.InnerText.ToString() + ", " + huyen.InnerText.ToString() + ", " + province;
                XmlNode dien_thoai = nhanvien.SelectSingleNode("dienthoai");
                dataNhanvien.Rows[sd].Cells[5].Value = dien_thoai.InnerText.ToString();

                if(salary > 1000)
                {
                    employeeCount++;
                    totalSalary += salary;
                }

                if(province == specificProvince)
                {
                    provinceEmployeeCount++;
                }

                dataNhanvien.Rows.Add();

                sd++;
            }

            label10.Text = $"Số nhân viên có lương > 1000: {employeeCount}, Tổng lương: {totalSalary}";
            label11.Text = $"Số nhân viên ở {specificProvince}: {provinceEmployeeCount}";
        }

        private void dataNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtMa.Text = dataNhanvien.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataNhanvien.Rows[d].Cells[1].Value.ToString();
            txtTuoi.Text = dataNhanvien.Rows[d].Cells[2].Value.ToString();
            txtLuong.Text = dataNhanvien.Rows[d].Cells[3].Value.ToString();
            string[] diachi = dataNhanvien.Rows[d].Cells[4].Value.ToString().Split(',');
            txtXa.Text = diachi[0].Trim();
            txtHuyen.Text = diachi[1].Trim();
            txtTinh.Text = diachi[2].Trim();
            txtDienthoai.Text = dataNhanvien.Rows[d].Cells[5].Value.ToString();
        }

        private void clearTextbox()
        {
            txtMa.Text = null;
            txtHoten.Text = null;
            txtTuoi.Text = null;
            txtLuong.Text = null;
            txtXa.Text = null;
            txtHuyen.Text = null;
            txtTinh.Text = null;
            txtDienthoai.Text = null;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                LoadData();
            }
        }
    }
}
