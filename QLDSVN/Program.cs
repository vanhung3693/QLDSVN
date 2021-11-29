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
            //KHAI BAO BIEN
            string chucNang;

            //IN RA MAN HINH
            Console.WriteLine("===> HE THONG QUAN LY DUONG SAT VIET NAM <=== \n");//inra xuong dong
            Console.WriteLine("1. Chuc Nang Quan Ly Nhan Vien");
            Console.WriteLine("2. Chuc Nang Quan Ly Cac Loai Tau");
            Console.WriteLine("3. Chuc Nang Quan Ly Chuyen Tau");
            Console.WriteLine("4. Chuc Nang Quan Ly Ve Tau");
            Console.WriteLine("5. Chuc Nang Quan Ly Doanh Thu");
            Console.Write("Moi Ban Nhap Chuc Nang Tuong Ung: ");//inra khong xuong dong
            chucNang = Console.ReadLine();//lay gia tri nhap vao man hinh sau khi enter
            switch (chucNang)//chon
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
                    Main(new String[] { });//goi lai chuong trinh
                    break;
                case "2":
                    Environment.Exit(0);//thoat chuong trinh
                    break;
            }

            Console.ReadKey();

        }
    }
}
