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
                    NhanVien.NhapThongTinNhanVien();
                    break;
                case "2":
                    LoaiTau.NhapThongTinLoaiTau();
                    break;
                case "3":
                    ChuyenTau.NhapThongTinChuyenTau();
                    break;
                case "4":
                   VeTau.NhapThongTinVeTau();
                    break;
                case "5":
                    DoanhThu.NhapThongTinDoanhThu();
                    break;
            }

            Console.WriteLine("\n 1. Tro Ve Ban Dau");
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
    }
}
