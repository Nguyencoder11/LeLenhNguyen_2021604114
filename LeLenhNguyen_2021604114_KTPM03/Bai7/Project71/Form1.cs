using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project71
{
    public partial class Form1 : Form
    {
        private DataUtil dataUtil;
        public Form1()
        {
            InitializeComponent();
            dataUtil = new DataUtil();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<Taikhoan> taikhoans = dataUtil.HienThi();
            dataTaiKhoan.DataSource = taikhoans;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Taikhoan tk = new Taikhoan {
                SoTaiKhoan = txtSoTK.Text,
                TenTaiKhoan = txtTenTK.Text,
                DiaChi = txtDiachi.Text,
                DienThoai = txtDienThoai.Text,
                SoTien = Convert.ToInt32(txtSotien.Text),
            };

            if (dataUtil.ThemTaiKhoan(tk))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Số tài khoản đã tồn tại!");
            }
            LoadData();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sotk = txtSoTK.Text.Trim();

            Taikhoan tk = dataUtil.TimTaiKhoan(sotk);

            if(tk != null)
            {
                List<Taikhoan> taikhoans = new List<Taikhoan> { tk };
                dataTaiKhoan.DataSource = taikhoans;

                txtTenTK.Text = tk.TenTaiKhoan;
                txtDiachi.Text = tk.DiaChi;
                txtDienThoai.Text = tk.DienThoai;
                txtSotien.Text = tk.SoTien.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản được chỉ định!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sotaikhoan = txtSoTK.Text.Trim();

            if(MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataUtil.XoaTaiKhoan(sotaikhoan))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Taikhoan tk = new Taikhoan
            {
                SoTaiKhoan = txtSoTK.Text,
                TenTaiKhoan = txtTenTK.Text,
                DiaChi = txtDiachi.Text,
                DienThoai = txtDienThoai.Text,
                SoTien = Convert.ToInt32(txtSotien.Text)
            };

            if (dataUtil.CapNhatTaiKhoan(tk)) {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản để cập nhật!");
            }
        }
    }
}
