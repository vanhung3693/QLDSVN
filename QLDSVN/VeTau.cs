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
            //string loaiTauChon;
            VeTau veTau = new VeTau();

            Console.WriteLine("\n ===> Nhap thong tin Ve Tau <==");

            Console.Write("Nhap Ma Ve Tau (LoaiVe,ToaNgoi,LoaiTau - VIP002D12E): ");
            veTau.MaVeTau = Console.ReadLine();

            string loaitau;
            //tim loai ve tau
            if (veTau.MaVeTau.Contains("VIP"))//tim ton tai trong chuoi
            {
                veTau.LoaiVe = "VIP";
                veTau.DichVu = "An Uong, Ve Sinh, Wifi, Dieu Hoa";
                //lay vi tri toa ngoi
                veTau.ToaNgoi = veTau.MaVeTau.Substring(3, 3);//cat 3 ky tu bat dau tu vi tri so 3

                //lay ma tau
                loaitau = veTau.MaVeTau.Substring(veTau.MaVeTau.Length - 4, 4);//cat 3 ky tu cuoi cung

                //kiem tra ton tai trong enum
                if (Enum.IsDefined(typeof(Enums.TauDieselCoDien), loaitau))//lay ra loai tau tu ma loai tau
                {
                    veTau.LoaiTau = "Tau Diesel Co Dien (" + loaitau + ")";
                }
                else
                {
                    veTau.LoaiTau = "Tau Diesel Truyen Dong Dien (" + loaitau + ")";
                }
            }
            
            //kiem tra ton tai trong chuoi
            else if (veTau.MaVeTau.Contains("NORMAL"))
            {
                veTau.LoaiVe = "NORMAL";
                veTau.DichVu = "An Uong, Ve Sinh";
                //lay vi tri toa ngoi
                veTau.ToaNgoi = veTau.MaVeTau.Substring(6, 3);

                //lay ma tau
                loaitau = veTau.MaVeTau.Substring(veTau.MaVeTau.Length - 4, 4);

                if (Enum.IsDefined(typeof(Enums.TauDieselCoDien), loaitau))
                {
                    veTau.LoaiTau = "Tau Diesel Co Dien (" + loaitau + ")"; 
                }
                else
                {
                    veTau.LoaiTau = "Tau Diesel Truyen Dong Dien (" + loaitau + ")";
                }
            }

            Console.Write("Nhap Ma Chuyen Tau: ");
            veTau.MaChuyenTau = Console.ReadLine();
            Console.Write("Nhap Gia Ve: ");
            veTau.GiaVe = double.Parse(Console.ReadLine());
            Console.Write("Nhap Gio Khoi Hanh dd/MM/yyyy: ");
            veTau.GioKhoiHanh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Nhap Cho Ngoi: ");
            veTau.ChoNgoi = Console.ReadLine();
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
