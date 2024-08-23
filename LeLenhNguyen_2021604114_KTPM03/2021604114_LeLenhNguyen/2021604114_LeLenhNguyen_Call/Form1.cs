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

namespace _2021604114_LeLenhNguyen_Call
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
        }

        public void LoadDataGridView() {
            string url = "http://localhost/qlnv/api/nhanvien";

            HttpWebRequest req = WebRequest.CreateHttp(url);
            WebResponse res = req.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(res.GetResponseStream());

            NhanVien[] arr = data as NhanVien[];
            dataNhanVien.DataSource = arr;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delString = string.Format("?ma={0}", txtMaNV.Text);
            string url = "http://localhost/qlnv/api/nhanvien" + delString;

            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                clearTextBox();
                LoadDataGridView();
                MessageBox.Show("Xóa nhân viên thành công");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&hoten={1}&trinhdo={2}&luong={3}", txtMaNV.Text, txtHoTen.Text, txtTrinhDo.Text, txtLuong.Text);

            string url = "http://localhost/qlnv/api/nhanvien" + postString;

            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "POST";

            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                clearTextBox();
                LoadDataGridView();
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaNV.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            txtTrinhDo.Text = dataNhanVien.Rows[d].Cells[2].Value.ToString();
            txtLuong.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();
        }

        private void clearTextBox()
        {
            txtMaNV.Text = null;
            txtHoTen.Text = null;
            txtTrinhDo.Text = null;
            txtLuong.Text = null;
        }
    }
}
