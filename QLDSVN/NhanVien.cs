using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    //lop nhan vien co tinh dong goi la public, tinh ke thua la lop nhan vien duoc ke thua thuoc tinh tu lop nguoi
    public class NhanVien : Nguoi, INhanVien
    {
        //ThuocTinh tu dong implement
        string MaNhanVien { get; set;}    
        string ChucVu { get; set; }
        double Luong { get;set; }

        //Phuong thuc khoi tao mac dinh
        public NhanVien()
        {

        }

        //Phuong thuc khoi tao voi parameter truyen vao
        public NhanVien(string hoTen, string maNhanVien, DateTime ngaySinh, string chucVu, double luong)
        {
            HoTen = hoTen; 
            MaNhanVien = maNhanVien;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            Luong = luong;  
        }

        public static void NhapThongTinNhanVien()
        {
            //khoi tao doi tuong nhan vien input de thuc hien nhap thong tin nhan vien
            NhanVien nhanVienInput = new NhanVien();

            Console.WriteLine("\n ===> Nhap thong tin Nhan Vien <==");
            Console.Write("Nhap Ma Nhan Vien: ");
            nhanVienInput.MaNhanVien = Console.ReadLine();
            Console.Write("Nhap Ten Nhan Vien: ");
            nhanVienInput.HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh Nhan Vien dd/MM/yyyy: ");
            nhanVienInput.NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Nhap Chuc Vu Nhan Vien: ");
            nhanVienInput.ChucVu = Console.ReadLine();
            Console.Write("Nhap Luong Nhan Vien: ");
            nhanVienInput.Luong = int.Parse(Console.ReadLine());

            ////Khoi tao doi tuong nhan vien output duoc gian gia tri khoi tao tu nhan vien input de in ra thong tin nhan vien
            //NhanVien nhanVienOutput = new NhanVien(nhanVienInput.HoTen, nhanVienInput.MaNhanVien, nhanVienInput.NgaySinh, nhanVienInput.ChucVu, nhanVienInput.Luong);
            //nhanVienOutput.XuatThongTinNhanVien();

            ////xuat thong tin theo cach khac ke thua tinh da hinh
            //nhanVienInput.XuatThongTinNhanVien(nhanVienInput);
            //Console.ReadKey();

            ChayChucNang chucnang = new ChayChucNang(new NhanVien(nhanVienInput.HoTen, nhanVienInput.MaNhanVien, nhanVienInput.NgaySinh, nhanVienInput.ChucVu, nhanVienInput.Luong));
            chucnang.XuatDanhSachNhanVien();

        }

        //Phuong thuc xuat thong tin nhan vien
        public void XuatThongTinNhanVien()
        {
            Console.WriteLine("\n ===> Thong tin Nhan Vien La:  <==");
            Console.Write("\n Ma Nhan Vien: " + MaNhanVien);
            Console.Write("\n Ten Nhan Vien: " + HoTen);
            Console.Write("\n Ngay Sinh: " + NgaySinh);
            Console.Write("\n Chuc Vu: " + ChucVu);
            Console.Write("\n Luong: " + Luong);
        }

        //Phuong thuc xuat thong tin nhan vien ke thua tinh da hinh 1 tac vu thuc hien theo cach khac
        public void XuatThongTinNhanVien(NhanVien nhanVien)
        {
            Console.WriteLine("\n ===> Thong tin Nhan Vien La:  <==");
            Console.Write("\n Ma Nhan Vien: " + nhanVien.MaNhanVien);
            Console.Write("\n Ten Nhan Vien: " + nhanVien.HoTen);
            Console.Write("\n Ngay Sinh: " + nhanVien.NgaySinh);
            Console.Write("\n Chuc Vu: " + nhanVien.ChucVu);
            Console.Write("\n Luong: " + nhanVien.Luong);
        }
    }
}
