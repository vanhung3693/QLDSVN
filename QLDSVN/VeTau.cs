using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSVN
{
    public class VeTau
    {
        public string MaVeTau { get; set; }
        public string MaChuyenTau { get; set; } 
        public string LoaiTau { get; set; }
        public double GiaVe { get; set; }
        public DateTime GioKhoiHanh { get; set; }
        public string LoaiVe { get; set; }
        public string ChoNgoi { get; set; }
        public string ToaNgoi { get; set; }
        public string DichVu { get; set; }
        public string HoTenKhachHang { get; set; }
        public string CMND { get; set; }

        public void XuatThongTin(VeTau veTau)
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
        }
    }
}
