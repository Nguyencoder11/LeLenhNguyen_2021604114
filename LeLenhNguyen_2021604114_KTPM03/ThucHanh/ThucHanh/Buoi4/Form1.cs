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
namespace Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tao doi tuong su dung tai lieu xml 
        XmlDocument doc = new XmlDocument();
        // duong dan toi file XML
        string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\ThucHanh\ThucHanh\Buoi4\dsnhanvien.xml";
        int d; // xac dinh chi so dong duoc chon tren DataGrid

        // hien thi du lieu tu file XML len DataGrid 
        private void HienThi()
        {
            dataNhanVien.Rows.Clear();
            doc.Load(file); // doc file xml
            // Tao doi tuong ds chua cac nut nhanvien
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int sd = 0;

            dataNhanVien.ColumnCount = 3; // so luong cot datagrid = 3
            dataNhanVien.Rows.Add();

            // duyet tung nut nhan vien
            foreach (XmlNode nhan_vien in DS)
            {
                // truy xuat thuoc tinh @manv
                XmlNode ma_nv = nhan_vien.SelectSingleNode("@manv");
                // dua gia tri ma nhan vien len cot dau tien cua DataGrid
                dataNhanVien.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                // truy xuat nut ho ten
                XmlNode ho_ten = nhan_vien.SelectSingleNode("hoten");
                dataNhanVien.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                // tuong tu voi nut dia chi
                XmlNode dia_chi = nhan_vien.SelectSingleNode("diachi");
                dataNhanVien.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();

                dataNhanVien.Rows.Add();

                sd++;
            }
        }
        private void FormLoaded(object sender, EventArgs e)
        {
            // goi toi ham hien thi de hien thi data sau khi load form
            HienThi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            // truy xuat nut goc cua tai lieu
            XmlElement goc = doc.DocumentElement;
            // tao mot nut nhan vien
            XmlNode nhan_vien = doc.CreateElement("nhanvien");
            // tao thuoc tinh @manv cho phan tu nhan vien
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            // xac dinh gia tri cua thuoc tinh @manv
            ma_nv.InnerText = txtMa.Text;
            // bo sung thuoc tinh cho nut nhan vien
            nhan_vien.Attributes.Append(ma_nv);

            // tao nut ho ten
            XmlNode ho_ten = doc.CreateElement("hoten");
            // xac dinh gia tri nut ho ten
            ho_ten.InnerText = txtHoten.Text;
            // bo sung nut ho ten vao nut nhan vien
            nhan_vien.AppendChild(ho_ten);

            // tuong tu voi nut dia chi
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            nhan_vien.AppendChild(dia_chi);

            // them nut nhan vien vao nut goc
            goc.AppendChild(nhan_vien);

            // luu tep va hien thi lai datagrid
            doc.Save(file);
            HienThi();

            clearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            // xac dinh nut nhan vien can sua
            XmlNode nv_cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");

            // tao nhan vien moi 
            XmlNode nv_moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            nv_moi.Attributes.Append(ma_nv);
            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = txtHoten.Text;
            nv_moi.AppendChild(ho_ten);
            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            nv_moi.AppendChild(dia_chi);

            // thay the nut nhan vien cu bang nut nhan vien moi
            goc.ReplaceChild(nv_moi, nv_cu);
            doc.Save(file);
            HienThi();

            clearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            // xac dinh nut nhan vien can xoa
            XmlNode nv_xoa = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");

            // xoa nut nhan vien
            goc.RemoveChild(nv_xoa);
            doc.Save(file);
            HienThi();

            clearTextBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", file);
        }

        private void Cell_Chosen(object sender, DataGridViewCellEventArgs e)
        {
            // xu ly su kien khi click vao cac row du lieu
            d = e.RowIndex;
            
            // hien thi cac thong tin cua row dc chon len textbox tuong ung
            txtMa.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            txtDiachi.Text = dataNhanVien.Rows[d].Cells[2].Value.ToString();
        }

        private void clearTextBox()
        {
            txtMa.Text = null;
            txtHoten.Text = null;
            txtDiachi.Text = null;
        }
    }
}
