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
using System.Xml.Linq;

namespace Bai4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\ThucHanh\ThucHanh\Bai4_3\dsnhanvien.xml";
        int d;

        private void HienThi() 
        {
            dataNhanvien.Rows.Clear();
            doc.Load(file);

            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int sd = 0;

            dataNhanvien.ColumnCount = 4;
            dataNhanvien.Rows.Add();

            foreach (XmlNode nv in DS)
            {
                XmlNode ma_nv = nv.SelectSingleNode("@manv");
                dataNhanvien.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();

                XmlNode ho = nv.SelectSingleNode("hoten/ho");
                dataNhanvien.Rows[sd].Cells[1].Value = ho.InnerText.ToString();

                XmlNode ten = nv.SelectSingleNode("hoten/ten");
                dataNhanvien.Rows[sd].Cells[2].Value = ten.InnerText.ToString();

                XmlNode dia_chi = nv.SelectSingleNode("diachi");
                dataNhanvien.Rows[sd].Cells[3].Value = dia_chi.InnerText.ToString();

                dataNhanvien.Rows.Add();
                sd++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }


        private void dataNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtMa.Text = dataNhanvien.Rows[d].Cells[0].Value.ToString();
            txtHo.Text = dataNhanvien.Rows[d].Cells[1].Value.ToString();
            txtTen.Text = dataNhanvien.Rows[d].Cells[2].Value.ToString();
            txtDiachi.Text = dataNhanvien.Rows[d].Cells[3].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            XmlNode nv = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            nv.Attributes.Append(ma_nv);
            XmlNode hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            ho.InnerText = txtHo.Text;
            hoten.AppendChild(ho);
            XmlNode ten = doc.CreateElement("ten");
            ten.InnerText = txtTen.Text;
            hoten.AppendChild(ten);
            nv.AppendChild(hoten);
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            nv.AppendChild(dia_chi);

            goc.AppendChild(nv);
            doc.Save(file);
            HienThi();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            XmlNode nv_cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");

            XmlNode nv_moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            nv_moi.Attributes.Append(ma_nv);
            XmlNode hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            ho.InnerText = txtHo.Text;
            hoten.AppendChild(ho);
            XmlNode ten = doc.CreateElement("ten");
            ten.InnerText = txtTen.Text;
            hoten.AppendChild(ten);
            nv_moi.AppendChild(hoten);
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            nv_moi.AppendChild(dia_chi);

            goc.ReplaceChild(nv_moi, nv_cu);
            doc.Save(file);
            HienThi();
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(file);

            XmlElement goc = doc.DocumentElement;
            XmlNode nv = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");
            goc.RemoveChild(nv);

            doc.Save(file);
            HienThi();
            clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", file);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void clear()
        {
            txtMa.Text = null;
            txtHo.Text = null;
            txtTen.Text = null;
            txtDiachi.Text = null;
        }
    }
}
