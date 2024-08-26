using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPhamDB_CallAPI
{
    public partial class Window2 : Form
    {
        public Window2()
        {
            InitializeComponent();
            LoadDataView();
        }

        private void LoadDataView()
        {
            string url = "http://localhost/sanpham/api/sanpham/dssoluong";
            HttpWebRequest req = WebRequest.CreateHttp(url);
            req.Method = "GET";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataMoreThanFive.DataSource = arr;
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
