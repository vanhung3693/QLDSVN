using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace QLDSVN
{
    public class VeTau
    {
        public string MaVeTau { get; set; }
        public string MaChuyenTau { get; set; }
        string LoaiTau { get; set; }
        double GiaVe { get; set; }
        public DateTime GioKhoiHanh { get; set; }
        public string LoaiVe { get; set; }
        public string ChoNgoi { get; set; }
        public string ToaNgoi { get; set; }
        string DichVu { get; set; }
        public string HoTenKhachHang { get; set; }
        public string CMND { get; set; }
        string NgaySinh { get; set; }

        //public de co the truy cap tu ben ngoai vao
        public static VeTau NhapThongTinVeTau()
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

            return veTau;
            //veTau.XuatThongTin(veTau);
        }

        void XuatThongTin(VeTau veTau)
        {


        }
    }
}
