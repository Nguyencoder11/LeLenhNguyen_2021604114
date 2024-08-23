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
using Newtonsoft.Json;

namespace APIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataView();
            LoadComboBox();
        }

        private void LoadDataView()
        {
            string link = "http://localhost/qlnvrestful/api/nhanvien";
            HttpWebRequest req = WebRequest.CreateHttp(link);
            WebResponse res = req.GetResponse();
            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                NhanVien[] arr = JsonConvert.DeserializeObject<NhanVien[]>(json);
                dataNhanvien.DataSource = arr;
            }
        }

        private void LoadComboBox()
        {
            string link = "http://localhost/qlnvrestful/api/donvi";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi[] arr1 = data as DonVi[];
            cboDonVi.DataSource = arr1;
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.ValueMember = "MaDonVi";
        }

        private void dataNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaNV.Text = dataNhanvien.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = dataNhanvien.Rows[d].Cells[1].Value.ToString();
            txtNgaySinh.Text = dataNhanvien.Rows[d].Cells[2].Value.ToString();
            txtGioitinh.Text = dataNhanvien.Rows[d].Cells[3].Value.ToString();
            txtHsl.Text = dataNhanvien.Rows[d].Cells[4].Value.ToString();
            cboDonVi.SelectedValue = dataNhanvien.Rows[d].Cells[5].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?manv={0}&hoten={1}&ngaysinh={2}&gioitinh={3}&hsl={4}&madv={5}", txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtGioitinh.Text.Trim(), txtHsl.Text.Trim(), cboDonVi.SelectedValue);
            string link = "http://localhost/qlnvrestful/api/nhanvien/" + postString;

            HttpWebRequest req = WebRequest.CreateHttp(link);
            req.Method = "POST";
            Stream dataStream = req.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataView();
                MessageBox.Show("Them nhan vien thanh cong");
            }
            else
            {
                MessageBox.Show("Them nhan vien that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?manv={0}&hoten={1}&ngaysinh={2}&gioitinh={3}&hsl={4}&madv={5}", txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtNgaySinh.Text.Trim(), txtGioitinh.Text.Trim(), txtHsl.Text.Trim(), cboDonVi.SelectedValue);
            string link = "http://localhost/qlnvrestful/api/nhanvien/" + putString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataView();
                MessageBox.Show("Sua nhan vien thanh cong");
            }
            else
            {
                MessageBox.Show("Sua nhan vien that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            string delString = string.Format("?id={0}", manv);

            string link = "http://localhost/qlnvrestful/api/nhanvien/" + delString;
            HttpWebRequest req = WebRequest.CreateHttp(link);
            req.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataView();
                MessageBox.Show("Xoa nhan vien thanh cong");
            }
        }

        private void btnTimGT_Click(object sender, EventArgs e)
        {
            string gender = txtGioitinh.Text;
            string url = "http://localhost/qlnvrestful/api/nhanvien?gender=" + gender;

            HttpWebRequest request = WebRequest.CreateHttp(url);
            WebResponse response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                NhanVien[] arr = JsonConvert.DeserializeObject<NhanVien[]>(json);
                dataNhanvien.DataSource = arr;
            }
        }

        private void clearTextBox()
        {
            txtMaNV.Text = null;
            txtHoTen.Text = null;
            txtNgaySinh.Text = null;
            txtGioitinh.Text = null;
            txtHsl.Text = null;
        }

        private void txtGioitinh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGioitinh.Text))
            {
                LoadDataView();
            }
        }
    }
}
