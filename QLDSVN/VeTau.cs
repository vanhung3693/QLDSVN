using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSVN
{
    class VeTau
    {
        string MaVeTau { get; set; }
        string MaChuyenTau { get; set; } 
        string LoaiTau { get; set; }
        double GiaVe { get; set; }
        DateTime GioKhoiHanh { get; set; }
        string LoaiVe { get; set; }
        string ChoNgoi { get; set; }
        string ToaNgoi { get; set; }
        string DichVu { get; set; }
        string HoTenKhachHang { get; set; }
        string CMND { get; set; }
        string NgaySinh { get; set; }

        //public de co the truy cap tu ben ngoai vao
        public static void NhapThongTinVeTau()
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

        void XuatThongTin(VeTau veTau)
        {
            Console.WriteLine("\n ====> THONG TIN VE TAU DA NHAP LA <==== \n");
            Console.WriteLine("Ma Ve Tau: " + veTau.MaVeTau);
            Console.WriteLine("Ma Chuyen Tau: " + veTau.MaChuyenTau);
            Console.WriteLine("Loai Tau: " + veTau.LoaiTau);
            Console.WriteLine("Gia Ve: " + veTau.GiaVe);
            Console.WriteLine("Gio Khoi Hanh: " + veTau.GioKhoiHanh);
            Console.WriteLine("Loai Ve: " + veTau.LoaiVe);
            Console.WriteLine("Cho Ngoi: " + veTau.ChoNgoi);
            Console.WriteLine("Toa Ngoi: " + veTau.ToaNgoi);
            Console.WriteLine("Dich Vu: " + veTau.DichVu);
            Console.WriteLine("Ho Ten Khach Hang: " + veTau.HoTenKhachHang);
            Console.WriteLine("CMND: " + veTau.CMND);
            Console.WriteLine("Ngay Sinh: " + veTau.NgaySinh);
        }
    }
}
