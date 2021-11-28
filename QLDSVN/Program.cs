using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chucNang;
            Console.WriteLine("===> HE THONG QUAN LY DUONG SAT VIET NAM <=== \n");
            Console.WriteLine("1. Chuc Nang Quan Ly Nhan Vien");
            Console.Write("Moi Ban Nhap Chuc Nang Tuong Ung: ");
            chucNang = Console.ReadLine();
            switch (chucNang)
            {
                case "1":
                    NhapThongTinNhanVien();
                    break;
            }


        }

        static void NhapThongTinNhanVien()
        {
            //khoi tao doi tuong nhan vien input de thuc hien nhap thong tin nhan vien
            NhanVien nhanVienInput = new NhanVien();

            Console.WriteLine("\n ===> Nhap thong tin Nhan Vien <==");
            Console.Write("Nhap Ma Nhan Vien: ");
            nhanVienInput.MaNhanVien = Console.ReadLine();
            Console.Write("Nhap Ten Nhan Vien: ");
            nhanVienInput.HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh Nhan Vien dd/MM/yyyy: ");
            nhanVienInput.NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Nhap Chuc Vu Nhan Vien: ");
            nhanVienInput.ChucVu = Console.ReadLine();
            Console.Write("Nhap Luong Nhan Vien: ");
            nhanVienInput.Luong = int.Parse(Console.ReadLine());

            ////Khoi tao doi tuong nhan vien output duoc gian gia tri khoi tao tu nhan vien input de in ra thong tin nhan vien
            //NhanVien nhanVienOutput = new NhanVien(nhanVienInput.HoTen, nhanVienInput.MaNhanVien, nhanVienInput.NgaySinh, nhanVienInput.ChucVu, nhanVienInput.Luong);
            //nhanVienOutput.XuatThongTinNhanVien();

            ////xuat thong tin theo cach khac ke thua tinh da hinh
            //nhanVienInput.XuatThongTinNhanVien(nhanVienInput);
            //Console.ReadKey();

            ChayChucNang chucnang = new ChayChucNang(new NhanVien(nhanVienInput.HoTen, nhanVienInput.MaNhanVien, nhanVienInput.NgaySinh, nhanVienInput.ChucVu, nhanVienInput.Luong));
            chucnang.XuatDanhSachNhanVien();

        }
    }
}
