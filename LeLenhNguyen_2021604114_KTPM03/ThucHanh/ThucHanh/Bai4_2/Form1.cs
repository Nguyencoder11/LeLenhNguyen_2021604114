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

namespace Bai4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\ThucHanh\ThucHanh\Bai4_2\dsNhanvien.xml";
        int d;


        private void HienThi()
        {
            dataNhanVien.Rows.Clear();
            doc.Load(file);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");

            int sd = 0;
            dataNhanVien.ColumnCount = 5;
            dataNhanVien.Rows.Add();

            foreach (XmlNode nhan_vien in DS)
            {
                XmlNode ma_nv = nhan_vien.SelectSingleNode("@manv");
                dataNhanVien.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = nhan_vien.SelectSingleNode("hoten");
                dataNhanVien.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode gioi_tinh = nhan_vien.SelectSingleNode("gioitinh");
                dataNhanVien.Rows[sd].Cells[2].Value = gioi_tinh.InnerText.ToString();
                XmlNode trinh_do = nhan_vien.SelectSingleNode("trinhdo");
                dataNhanVien.Rows[sd].Cells[3].Value = trinh_do.InnerText.ToString();
                XmlNode dia_chi = nhan_vien.SelectSingleNode("diachi");
                dataNhanVien.Rows[sd].Cells[4].Value = dia_chi.InnerText.ToString();

                dataNhanVien.Rows.Add();
                sd++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            cbxTrinhdo.Items.Clear();
            doc.Load(file);

            XmlNodeList node = doc.SelectNodes("/ds/nhanvien/trinhdo");

            HashSet<string> listSet = new HashSet<string>();

            foreach (XmlNode n in node)
            {
                listSet.Add(n.InnerText);
            }

            foreach(string td in listSet)
            {
                cbxTrinhdo.Items.Add(td);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtMa.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();

            string gender = dataNhanVien.Rows[d].Cells[2].Value.ToString();
            if(gender == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }

            cbxTrinhdo.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();
            txtDiachi.Text = dataNhanVien.Rows[d].Cells[4].Value.ToString();
        }

        private void clear()
        {
            txtMa.Text = null; 
            txtHoten.Text = null;
            cbxTrinhdo.Text = null;
            txtDiachi.Text = null;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            XmlNode nhan_vien = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            nhan_vien.Attributes.Append(ma_nv);

            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = txtHoten.Text;
            nhan_vien.AppendChild(ho_ten);

            XmlNode gioi_tinh = doc.CreateElement("gioitinh");
            gioi_tinh.InnerText = (radNam.Checked == true)?radNam.Text:radNu.Text;
            nhan_vien.AppendChild(gioi_tinh);
            

            XmlNode trinh_do = doc.CreateElement("trinhdo");
            trinh_do.InnerText = cbxTrinhdo.Text;
            nhan_vien.AppendChild(trinh_do);

            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            nhan_vien.AppendChild(dia_chi);

            goc.AppendChild(nhan_vien);

            doc.Save(file);
            HienThi();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            XmlNode old_emp = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");
            XmlNode new_emp = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txtMa.Text;
            new_emp.Attributes.Append(ma_nv);

            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = txtHoten.Text;
            new_emp.AppendChild(ho_ten);

            XmlNode gioi_tinh = doc.CreateElement("gioitinh");
            gioi_tinh.InnerText = (radNam.Checked == true)?radNam.Text:radNu.Text;
            new_emp.AppendChild(gioi_tinh);

            XmlNode trinh_do = doc.CreateElement("trinhdo");
            trinh_do.InnerText = cbxTrinhdo.Text;
            new_emp.AppendChild(trinh_do);

            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txtDiachi.Text;
            new_emp.AppendChild(dia_chi);

            goc.ReplaceChild(new_emp, old_emp);

            doc.Save(file);
            HienThi();
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement goc = doc.DocumentElement;

            XmlNode old_emp = goc.SelectSingleNode("/ds/nhanvien[@manv='" + txtMa.Text + "']");

            goc.RemoveChild(old_emp);
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
    }
}
