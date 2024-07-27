using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Solution1
{
    internal class Program
    {
        static string file = @"E:\HaUI_Learn\Semester 7\LeLenhNguyen_2021604114\LeLenhNguyen_2021604114_KTPM03\Bai6\Solution1\nhanvien.json";
        static void Main(string[] args)
        {
            WriteToObject();
            ReadFromFile();

        }

        private static void WriteToObject()
        {
            var employees = new List<Employee>
            {
                new Employee("NV01", "Nguyen Van A", new DateTime(1990, 1, 1), "Nam", "Hanoi", 1.5),
                new Employee("NV02", "Tran Thi B", new DateTime(1992, 2, 2), "Nu", "HCM", 2.0),
                new Employee("NV03", "Le Van C", new DateTime(1994, 3, 3), "Nam", "Danang", 1.8)
            };

            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);

            try
            {
                File.WriteAllText(file, json);
                Console.WriteLine("Data has been written to " + file);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        private static void ReadFromFile()
        {
            try
            {
                if (File.Exists(file))
                {
                    string json = File.ReadAllText(file);
                    var employees = JsonConvert.DeserializeObject<List<Employee>>(json);

                    Console.WriteLine("Employee List:");
                    foreach (var employee in employees)
                    {
                        Console.WriteLine($"MaNV: {employee.MaNV}, HoTen: {employee.HoTen}, NgaySinh: {employee.NgaySinh.ToShortDateString()}, GioiTinh: {employee.GioiTinh}, DiaChi: {employee.DiaChi}, HeSoLuong: {employee.HeSoLuong}");
                    }
                }
                else
                {
                    Console.WriteLine("File " + file + " does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }
    }
}
