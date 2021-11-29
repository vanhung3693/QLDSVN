using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    class LoaiTau
    {
        double TocDo { get; set; }
        double TaiTrongKeo { get; set; }
        double ChieuDai { get; set; }
        double ChieuCao { get; set; }
        double ChieuRong { get; set; }
        string Loai { get; set; }

        //public de co the truy cap tu ben ngoai vao
        public static void NhapThongTinLoaiTau()
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
                    foreach (var maTauCoDien in Enum.GetNames(typeof(Enums.TauDieselCoDien)))//chay vong lap gan tung gia tri trong vong lap
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

        void XuatThongTinTau(LoaiTau loaiTau)
        {
            Console.WriteLine("\n ====> THONG TIN TAU DA NHAP LA <==== \n");
            Console.WriteLine("Loai Tau: " + loaiTau.Loai);
            Console.WriteLine("Toc Do: " + loaiTau.TocDo);      
            Console.WriteLine("Tai Trong Keo: " + loaiTau.TaiTrongKeo);
            Console.WriteLine("Chieu Dai: " + loaiTau.ChieuDai);
            Console.WriteLine("Chieu Cao: " + loaiTau.ChieuCao);
            Console.WriteLine("Chieu Rong: " + loaiTau.ChieuRong);
        }
    }
}
