using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        CreateSinhVienHTML();
        CreateNhanVienHTML();
    }

    private static void CreateNhanVienHTML()
    {
        string sinhvienHtml = @"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <title>Danh Sách Sinh Viên</title>
            </head>
            <body>
                <h1>Danh Sách Sinh Viên</h1>
                <div id='sinhvien-list'></div>

                <script>
                    const sinhvienArray = [
                        { masv: 'SV01', hoten: 'Nguyen Van A', tuoi: 20, diachi: 'Ha Noi', dienthoai: '0123456789' },
                        { masv: 'SV02', hoten: 'Tran Thi B', tuoi: 21, diachi: 'Hai Phong', dienthoai: '0987654321' },
                        { masv: 'SV03', hoten: 'Le Van C', tuoi: 22, diachi: 'Da Nang', dienthoai: '0912345678' }
                    ];

                    const sinhvienList = document.getElementById('sinhvien-list');
                    sinhvienArray.forEach(sinhvien => {
                        const sinhvienDiv = document.createElement('div');
                        sinhvienDiv.innerHTML = `
                            <p>Mã SV: ${sinhvien.masv}</p>
                            <p>Họ tên: ${sinhvien.hoten}</p>
                            <p>Tuổi: ${sinhvien.tuoi}</p>
                            <p>Địa chỉ: ${sinhvien.diachi}</p>
                            <p>Điện thoại: ${sinhvien.dienthoai}</p>
                            <hr>
                        `;
                        sinhvienList.appendChild(sinhvienDiv);
                    });
                </script>
            </body>
            </html>
        ";

        File.WriteAllText("E:\\HaUI_Learn\\Semester 7\\LeLenhNguyen_2021604114\\LeLenhNguyen_2021604114_KTPM03\\Bai7\\Project7.2\\sinhvien.html", sinhvienHtml);
        Console.WriteLine("File sinhvien.html created successfully.");
    }

    private static void CreateSinhVienHTML()
    {
        string nhanvienHtml = @"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <title>Danh Sách Nhân Viên</title>
            </head>
            <body>
                <h1>Danh Sách Nhân Viên</h1>
                <div id='nhanvien-list'></div>

                <script>
                    const nhanvienArray = [
                        { manv: 'NV01', hoten: 'Nguyen Van D', luong: 5000000, thuong: 1000000, tongluong: 6000000, diachi: { xa: 'Dong Da', huyen: 'Dong Da', tinh: 'Ha Noi' } },
                        { manv: 'NV02', hoten: 'Tran Thi E', luong: 6000000, thuong: 1500000, tongluong: 7500000, diachi: { xa: 'Le Chan', huyen: 'Le Chan', tinh: 'Hai Phong' } },
                        { manv: 'NV03', hoten: 'Le Van F', luong: 7000000, thuong: 2000000, tongluong: 9000000, diachi: { xa: 'Lien Chieu', huyen: 'Lien Chieu', tinh: 'Da Nang' } }
                    ];

                    const nhanvienList = document.getElementById('nhanvien-list');
                    nhanvienArray.forEach(nhanvien => {
                        const nhanvienDiv = document.createElement('div');
                        nhanvienDiv.innerHTML = `
                            <p>Mã NV: ${nhanvien.manv}</p>
                            <p>Họ tên: ${nhanvien.hoten}</p>
                            <p>Lương: ${nhanvien.luong}</p>
                            <p>Thưởng: ${nhanvien.thuong}</p>
                            <p>Tổng lương: ${nhanvien.tongluong}</p>
                            <p>Địa chỉ: Xã ${nhanvien.diachi.xa}, Huyện ${nhanvien.diachi.huyen}, Tỉnh ${nhanvien.diachi.tinh}</p>
                            <hr>
                        `;
                        nhanvienList.appendChild(nhanvienDiv);
                    });
                </script>
            </body>
            </html>
        ";

        File.WriteAllText("E:\\HaUI_Learn\\Semester 7\\LeLenhNguyen_2021604114\\LeLenhNguyen_2021604114_KTPM03\\Bai7\\Project7.2\\nhanvien.html", nhanvienHtml);
        Console.WriteLine("File nhanvien.html created successfully.");
    }
}