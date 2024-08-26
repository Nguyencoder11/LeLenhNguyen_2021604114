using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;

namespace QuanLySanPhamDB_CallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSP.Text = dataSanpham.Rows[d].Cells[0].Value.ToString();
            txtTenSP.Text = dataSanpham.Rows[d].Cells[1].Value.ToString();
            txtDongia.Text = dataSanpham.Rows[d].Cells[2].Value.ToString();
            txtSlBan.Text = dataSanpham.Rows[d].Cells[3].Value.ToString();
            txtTienban.Text = dataSanpham.Rows[d].Cells[4].Value.ToString();
            cboNH.SelectedValue = dataSanpham.Rows[d].Cells[5].Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBox();
        }

        private void LoadDataGridView()
        {
            string url = "http://localhost/sanpham/api/sanpham";
            HttpWebRequest req = WebRequest.CreateHttp(url);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataSanpham.DataSource = arr;
        }

        private void LoadComboBox() 
        {
            string url = "http://localhost/sanpham/api/nhomhang";
            HttpWebRequest req = WebRequest.CreateHttp(url);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhomHang[]));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            NhomHang[] arr = data as NhomHang[];
            cboNH.DataSource = arr;
            cboNH.ValueMember = "MaNhomHang";
            cboNH.DisplayMember = "TenNhomHang";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/sanpham/api/sanpham" + string.Format("?masp={0}&tensp={1}&dongia={2}&slban={3}&tienban={4}&manh={5}", txtMaSP.Text.Trim(), txtTenSP.Text, Double.Parse(txtDongia.Text), Convert.ToInt32(txtSlBan.Text), Double.Parse(txtTienban.Text), cboNH.SelectedValue);
            HttpWebRequest req = WebRequest.CreateHttp(url);
            req.Method = "POST";
            Stream dataStream = req.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/sanpham/api/sanpham" + string.Format("?masp={0}&tensp={1}&dongia={2}&slban={3}&tienban={4}&manh={5}", txtMaSP.Text.Trim(), txtTenSP.Text, Double.Parse(txtDongia.Text), Convert.ToInt32(txtSlBan.Text), Double.Parse(txtTienban.Text), cboNH.SelectedValue);
            HttpWebRequest req = WebRequest.CreateHttp(url);
            req.Method = "PUT";
            Stream dataStream = req.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/sanpham/api/sanpham" + string.Format("?id={0}", txtMaSP.Text.Trim());
            HttpWebRequest req = WebRequest.CreateHttp(url);
            req.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Xoá sản phẩm thất bại");
            }
        }

        private void btnWindow2_Click(object sender, EventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
