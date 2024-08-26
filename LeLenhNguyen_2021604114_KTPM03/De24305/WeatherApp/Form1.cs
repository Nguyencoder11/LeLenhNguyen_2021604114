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

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDataGridView()
        {
            string url = "http://localhost/thoitiet/api/thoitiettrongngay";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            WebResponse response = request.GetResponse();
            // Su dung JsonConvert.DeserializeObject de ho tro doc du lieu kieu DateTime
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                ThoiTietTrongNgay[] arr = JsonConvert.DeserializeObject<ThoiTietTrongNgay[]>(json);
                dataThoiTiet.DataSource = arr;
            }
        }

        private void dataThoiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaKV.Text = dataThoiTiet.Rows[d].Cells[0].Value.ToString();
            txtGio.Text = dataThoiTiet.Rows[d].Cells[1].Value.ToString();
            txtNhietDo.Text = dataThoiTiet.Rows[d].Cells[2].Value.ToString();
            txtDoAm.Text = dataThoiTiet.Rows[d].Cells[3].Value.ToString();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/thoitiet/api/thoitiettrongngay" + string.Format("?makv={0}&gio={1}&nhietdo={2}&doam={3}", txtMaKV.Text.Trim(), txtGio.Text, Decimal.Parse(txtNhietDo.Text), Decimal.Parse(txtDoAm.Text));
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Them du lieu thanh cong");
            }
            else
            {
                MessageBox.Show("Them du lieu that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/thoitiet/api/thoitiettrongngay" + string.Format("?makv={0}&gio={1}", txtMaKV.Text.Trim(), txtGio.Text);
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "DELETE";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq) {
                LoadDataGridView();
                MessageBox.Show("Xoa du lieu thanh cong");
            }
            else
            {
                MessageBox.Show("Khong the xoa");
            }
        }
    }
}
