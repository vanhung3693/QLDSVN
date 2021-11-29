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
            Console.WriteLine("2. Chuc Nang Quan Ly Cac Loai Tau");
            Console.Write("Moi Ban Nhap Chuc Nang Tuong Ung: ");
            chucNang = Console.ReadLine();
            switch (chucNang)
            {
                case "1":
                    NhapThongTinNhanVien();
                    break;
                case "2":
                    NhapThongTinLoaiTau();
                    break;
            }

            Console.WriteLine("1. Tro Ve Ban Dau");
            Console.WriteLine("2. Thoat");

            String refresh = Console.ReadLine();

            switch (refresh)
            {
                case "1":
                    Main(new String[] { });
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
            
            Console.ReadKey();

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

        static void NhapThongTinLoaiTau()
        {
            string loaiTauChon;

            LoaiTau loaiTau = new LoaiTau();
            Console.WriteLine("\n ===> Nhap thong tin Loai Tau <==");

            Console.WriteLine("Cac LoaiTau: ");
            Console.WriteLine("1. Tau Diesel Co Dien ");
            Console.WriteLine("2. Tau Diesel Truyen Dong Dien ");
            Console.Write("ChonLoaiTau: ");
            loaiTauChon = Console.ReadLine();

            switch (loaiTauChon)
            {
                case "1":
                    foreach (var maTauCoDien in Enum.GetNames(typeof(Enums.TauDieselCoDien)))
                    {
                        Console.WriteLine(maTauCoDien);
                    }
                    Console.Write("Nhap Ma Tau: ");
                    loaiTau.Loai = "Tau Diesel Co Dien (" + Console.ReadLine() + ")";
                    break;
                case "2":
                    foreach (var maTauTruyenDong in Enum.GetNames(typeof(Enums.TauDieselTruyenDongDien)))
                    {
                        Console.WriteLine(maTauTruyenDong);
                    }
                    Console.Write("Nhap Ma Tau: ");
                    loaiTau.Loai = "Tau Diesel Truyen Dong Dien (" + Console.ReadLine() + ")";
                    break;
            }

            Console.Write("Nhap Toc Do: ");
            loaiTau.TocDo = double.Parse(Console.ReadLine());
            Console.Write("Nhap Tai Trong Keo: ");
            loaiTau.TaiTrongKeo = double.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Dai: ");
            loaiTau.ChieuDai = double.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Cao: ");
            loaiTau.ChieuCao = double.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Rong: ");
            loaiTau.ChieuRong = double.Parse(Console.ReadLine());

            //xuat thong tin
            loaiTau.XuatThongTinTau(loaiTau);
        }
    }
}
