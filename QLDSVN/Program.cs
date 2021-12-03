using System;
using System.Collections.Generic;
using System.Data;
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
                    Console.WriteLine("\n ====> THONG TIN VE TAU DA NHAP LA <==== \n");
                    //tao doi tuong kieu du lieu la danh sach
                    List<VeTau> veTauLst = new List<VeTau>();

                    string themVe;
                    string xoaVe;

                    do
                    {
                        VeTau veTau = VeTau.NhapThongTinVeTau();
                        //them doi tuong vao danh sach 
                        veTauLst.Add(veTau);
                        Console.WriteLine("1. Them ve");
                        Console.WriteLine("0. Xuat Danh Sach");
                        themVe = Console.ReadLine();
                    }
                    while (themVe != "0");

                    Console.WriteLine("Danh Sach");
                    DataTable dataTables = veTauLst.ToDataTable();
                    dataTables.Print();

                    Console.WriteLine("1. Xoa ve");
                    Console.WriteLine("0. Thoat");
                    xoaVe = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("1. Nhap Ma ve: ");
                        string mave = Console.ReadLine();
                        //tim kiem trong linq
                        VeTau veTauMove = veTauLst.Find(x => x.MaVeTau == mave);
                        veTauLst.Remove(veTauMove);
                        DataTable dataTablesNew = veTauLst.ToDataTable();
                        dataTablesNew.Print();
                        Console.WriteLine("1. Xoa ve");
                        Console.WriteLine("0. Thoat");
                        xoaVe = Console.ReadLine();
                    }
                    while (xoaVe != "0");

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
