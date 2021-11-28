using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    public interface INhanVien
    {
        void XuatThongTinNhanVien();
        void XuatThongTinNhanVien(NhanVien nhanVien);
    }
    //lop nhan vien co tinh dong goi la public, tinh ke thua la lop nhan vien duoc ke thua thuoc tinh tu lop nguoi
    public class NhanVien : Nguoi, INhanVien
    {
        //ThuocTinh tu dong implement
        public string MaNhanVien { get; set;}    
        public string ChucVu { get; set; }
        public double Luong { get;set; }

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

        //Phuong thuc xuat thong tin nhan vien
        public void XuatThongTinNhanVien()
        {
            Console.WriteLine("\n ===> Thong tin Nhan Vien La:  <==");
            Console.Write("\n Ma Nhan Vien: " + MaNhanVien);
            Console.Write("\n Ten Nhan Vien: " + HoTen);
            Console.Write("\n Ngay Sinh: " + NgaySinh);
            Console.Write("\n Chuc Vu: " + ChucVu);
            Console.Write("\n Luong: " + Luong);
            Console.ReadKey();
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
            Console.ReadKey();
        }
    }
}
