using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    public class ChuyenTau
    {
        public string Loai { get; set; }
        public string MaChuyenTau { get; set; }
        public Double SoluongHanhKhachToiDa { get; set; }
        public DateTime GioKhoiHanh { get; set; }
    
        public void XuatThongTin(ChuyenTau chuyenTau)
        {
            Console.WriteLine("\n ====> THONG TIN CHUYEN TAU DA NHAP LA <==== \n");
            Console.WriteLine("Ma Chuyen Tau: " + chuyenTau.MaChuyenTau);
            Console.WriteLine("Loai: " + chuyenTau.Loai);
            Console.WriteLine("So Luong Hanh Khach Toi Da: " + chuyenTau.SoluongHanhKhachToiDa);
            Console.WriteLine("Gio Khoi Hanh: " + chuyenTau.GioKhoiHanh);
        }
    }
}
