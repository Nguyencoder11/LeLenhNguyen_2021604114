using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Project73;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Sinhvien> sinhviens = new List<Sinhvien>();

        // Nhap danh sach sinh vien
        sinhviens.Add(new Sinhvien { MaSV = "SV01", HoTen = "Nguyen Van A", Tuoi = 20, DiaChi = "Ha Noi", DienThoai = "0123456789" });
        sinhviens.Add(new Sinhvien { MaSV = "SV02", HoTen = "Tran Thi B", Tuoi = 21, DiaChi = "Hai Phong", DienThoai = "0987654321" });
        sinhviens.Add(new Sinhvien { MaSV = "SV03", HoTen = "Le Van C", Tuoi = 22, DiaChi = "Da Nang", DienThoai = "0912345678" });

        // ghi vao file sinhvien.dat, using JSON
        string jsonSinhVien = JsonConvert.SerializeObject(sinhviens, Formatting.Indented);
        File.WriteAllText("E:\\HaUI_Learn\\Semester 7\\LeLenhNguyen_2021604114\\LeLenhNguyen_2021604114_KTPM03\\Bai7\\Project73\\sinhvien.dat", jsonSinhVien);

        // doc du lieu tu file sinhvien.dat, su dung JSON
        string jsonData = File.ReadAllText("E:\\HaUI_Learn\\Semester 7\\LeLenhNguyen_2021604114\\LeLenhNguyen_2021604114_KTPM03\\Bai7\\Project73\\sinhvien.dat");
        List<Sinhvien> lists = JsonConvert.DeserializeObject<List<Sinhvien>>(jsonData);
        Console.WriteLine("Danh sach sinh vien:");
        foreach(var sinhvien in lists)
        {
            Console.WriteLine($"Mã SV: {sinhvien.MaSV}");
            Console.WriteLine($"Họ tên: {sinhvien.HoTen}");
            Console.WriteLine($"Tuổi: {sinhvien.Tuoi}");
            Console.WriteLine($"Địa chỉ: {sinhvien.DiaChi}");
            Console.WriteLine($"Điện thoại: {sinhvien.DienThoai}");
            Console.WriteLine(new string('-', 20));
        }
    }
}