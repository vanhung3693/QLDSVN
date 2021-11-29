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
            Console.WriteLine("3. Chuc Nang Quan Ly Chuyen Tau");
            Console.WriteLine("4. Chuc Nang Quan Ly Ve Tau");
            Console.WriteLine("5. Chuc Nang Quan Ly Doanh Thu");
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
                case "3":
                    NhapThongTinChuyenTau();
                    break;
                case "4":
                    NhapThongTinVeTau();
                    break;
                case "5":
                    NhapThongTinDoanhThu();
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

        static void NhapThongTinChuyenTau()
        {
            string loaiTauChon;
            ChuyenTau chuyenTau = new ChuyenTau();

            Console.WriteLine("\n ===> Nhap thong tin Chuyen Tau <==");

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
                    chuyenTau.Loai = "Tau Diesel Co Dien (" + Console.ReadLine() + ")";
                    break;
                case "2":
                    foreach (var maTauTruyenDong in Enum.GetNames(typeof(Enums.TauDieselTruyenDongDien)))
                    {
                        Console.WriteLine(maTauTruyenDong);
                    }
                    Console.Write("Nhap Ma Tau: ");
                    chuyenTau.Loai = "Tau Diesel Truyen Dong Dien (" + Console.ReadLine() + ")";
                    break;
            }

            Console.Write("Nhap Ma Chuyen Tau: ");
            chuyenTau.MaChuyenTau = Console.ReadLine();
            Console.Write("Nhap So luong Hanh khach Toi Da: ");
            chuyenTau.SoluongHanhKhachToiDa = double.Parse(Console.ReadLine());
            Console.Write("Nhap Gio Khoi Hanh dd/MM/yyyy: ");
            chuyenTau.GioKhoiHanh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            chuyenTau.XuatThongTin(chuyenTau);
        }

        static void NhapThongTinVeTau()
        {
            string loaiTauChon;
            VeTau veTau = new VeTau();

            Console.WriteLine("\n ===> Nhap thong tin Ve Tau <==");

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
                    veTau.LoaiTau = "Tau Diesel Co Dien (" + Console.ReadLine() + ")";
                    break;
                case "2":
                    foreach (var maTauTruyenDong in Enum.GetNames(typeof(Enums.TauDieselTruyenDongDien)))
                    {
                        Console.WriteLine(maTauTruyenDong);
                    }
                    Console.Write("Nhap Ma Tau: ");
                    veTau.LoaiTau = "Tau Diesel Truyen Dong Dien (" + Console.ReadLine() + ")";
                    break;
            }

            Console.Write("Nhap Ma Ve Tau: ");
            veTau.MaVeTau = Console.ReadLine();
            Console.Write("Nhap Ma Chuyen Tau: ");
            veTau.MaChuyenTau = Console.ReadLine();
            Console.Write("Nhap Gia Ve: ");
            veTau.GiaVe = double.Parse(Console.ReadLine());
            Console.Write("Nhap Gio Khoi Hanh dd/MM/yyyy: ");
            veTau.GioKhoiHanh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Nhap Loai Ve: ");
            veTau.LoaiVe = Console.ReadLine();
            Console.Write("Nhap Cho Ngoi: ");
            veTau.ChoNgoi = Console.ReadLine();
            Console.Write("Nhap Toa Ngoi: ");
            veTau.ToaNgoi = Console.ReadLine();            
            Console.Write("Nhap Dich Vu: ");
            veTau.DichVu = Console.ReadLine();
            Console.Write("Nhap Ho Ten Khach Hang: ");
            veTau.HoTenKhachHang = Console.ReadLine();
            Console.Write("Nhap CMND: ");
            veTau.CMND = Console.ReadLine();            
            Console.Write("Nhap Ngay Sinh: ");
            veTau.NgaySinh = Console.ReadLine();

            veTau.XuatThongTin(veTau);
        }
        static void NhapThongTinDoanhThu()
        {
            DoanhThu doanhThu = new DoanhThu();
            Console.WriteLine("\n ===> Nhap thong tin Doanh Thu <==");
            Console.Write("Nhap Doanh Thu Thang: ");
            doanhThu.DoanhThuThang = double.Parse(Console.ReadLine());
            Console.Write("Nhap Doanh Thu Quy: ");
            doanhThu.DoanhThuQuy = double.Parse(Console.ReadLine());
            Console.Write("Nhap Doanh Thu Nam: ");
            doanhThu.DoanhThuNam = double.Parse(Console.ReadLine());

            doanhThu.XuatThongTin(doanhThu);
        }

    }
}
