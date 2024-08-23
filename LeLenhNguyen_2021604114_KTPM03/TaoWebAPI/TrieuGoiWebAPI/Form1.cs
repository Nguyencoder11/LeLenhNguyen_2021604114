using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace TrieuGoiWebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBox();
        }

        public void LoadDataGridView()
        {
            // Link goi lay toan bo san pham da cai Web API len IIS
            string link = "http://localhost/hocrestful/api/sanpham";
            // Link goi API lay toan bo san pham chua cai Web API len IIS
            // string link = "https://localhost:44363/api/sanpham";

            // tao mot yeu cau gui toi Website su dung lop HttpWebRequest
            HttpWebRequest req = WebRequest.CreateHttp(link);
            // Lay thong tin tu WebServer su dung WebResponse
            WebResponse res = req.GetResponse();
            // Tao doi tuong Js kieu mang sang pham theo dinh dang Json
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            // Lay du lieu tu luong Dl
            object data = js.ReadObject(res.GetResponseStream());
            // ep du lieu ve mang san pham
            SanPham[] arr = data as SanPham[];
            dataDanhSach.DataSource = arr;
        }

        public void LoadComboBox()
        {
            string link = "http://localhost/hocrestful/api/danhmuc";
            // string link = "https://localhost:44363/api/danhmuc";

            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse res = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(res.GetResponseStream());
            DanhMuc[] arr1 = data as DanhMuc[];
            cboDanhMuc.DataSource = arr1;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }

        private void dataDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSP.Text = dataDanhSach.Rows[d].Cells[0].Value.ToString();
            txtTenSP.Text = dataDanhSach.Rows[d].Cells[1].Value.ToString();
            txtDonGia.Text = dataDanhSach.Rows[d].Cells[2].Value.ToString();
            cboDanhMuc.SelectedValue = dataDanhSach.Rows[d].Cells[3].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // chuoi gia tri nhap tu form cho cac TS cua Web API them
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), txtDonGia.Text.Trim(), cboDanhMuc.SelectedValue);
            // link goi API them 1 san pham da cai Web API len IIS
            string link = "http://localhost/hocrestful/api/sanpham/" + postString;
            // link goi API them 1 san pham chua cai Web API len IIS
            // string link = "https://localhost:44363/api/sanpham/" + postString;

            HttpWebRequest req = WebRequest.CreateHttp(link);
            req.Method = "POST";
            // Tao luong yeu cau
            Stream dataStream = req.GetRequestStream();
            // Tao doi tuong js kieu bool theo dinh dang js
            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            // lay du lieu tra ve tu luong dl
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
            clearTextField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), txtDonGia.Text.Trim(), cboDanhMuc.SelectedValue);
            string link = "http://localhost/hocrestful/api/sanpham/" + putString;
            // string link = "https://localhost:44363/api/sanpham/" + putString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";

            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sửa sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }
            clearTextField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string deleteString = string.Format("?id={0}", masp);
            string link = "http://localhost/hocrestful/api/sanpham/" + deleteString;
            // string link = "https://localhost:44363/api/sanpham/" + deleteString;

            HttpWebRequest req = WebRequest.CreateHttp(link);
            req.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            object data = js.ReadObject (req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            clearTextField();
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string link = "http://localhost/hocrestful/api/sanpham?madm=" + madm;
            //string link = "https://localhost:44363/api/sanpham?madm=" + madm;

            HttpWebRequest req = WebRequest.CreateHttp(link);
            WebResponse resp = req.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(resp.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            
            dataDanhSach.DataSource = arr;
        }

        private void txtMaDM_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text))
            {
                LoadDataGridView();
            }
        }


        private void clearTextField()
        {
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDonGia.Text = null;
        }
    }
}
