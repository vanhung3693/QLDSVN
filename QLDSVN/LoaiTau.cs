using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    public class LoaiTau
    {
        public double TocDo { get; set; }
        public double TaiTrongKeo { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuCao { get; set; }
        public double ChieuRong { get; set; }
        public string Loai { get; set; }

        public void XuatThongTinTau(LoaiTau loaiTau)
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
