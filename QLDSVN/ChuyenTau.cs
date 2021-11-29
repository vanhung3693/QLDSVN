using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    class ChuyenTau
    {
        string Loai { get; set; }
        string MaChuyenTau { get; set; }
        Double SoluongHanhKhachToiDa { get; set; }
        DateTime GioKhoiHanh { get; set; }

        //public de co the truy cap tu ben ngoai vao
        public static void NhapThongTinChuyenTau()
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

        void XuatThongTin(ChuyenTau chuyenTau)
        {
            Console.WriteLine("\n ====> THONG TIN CHUYEN TAU DA NHAP LA <==== \n");
            Console.WriteLine("Ma Chuyen Tau: " + chuyenTau.MaChuyenTau);
            Console.WriteLine("Loai: " + chuyenTau.Loai);
            Console.WriteLine("So Luong Hanh Khach Toi Da: " + chuyenTau.SoluongHanhKhachToiDa);
            Console.WriteLine("Gio Khoi Hanh: " + chuyenTau.GioKhoiHanh);
        }
    }
}
