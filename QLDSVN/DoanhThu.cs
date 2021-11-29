using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSVN
{
    class DoanhThu
    {
        double DoanhThuThang { get; set; }
        double DoanhThuQuy { get; set; }
        double DoanhThuNam { get; set; }

        //public de co the truy cap tu ben ngoai vao
        public static void NhapThongTinDoanhThu()
        {
            DoanhThu doanhThu = new DoanhThu();
            Console.WriteLine("\n ===> Nhap thong tin Doanh Thu <==");
            Console.Write("Nhap Doanh Thu Thang: ");
            doanhThu.DoanhThuThang = double.Parse(Console.ReadLine());
            Console.Write("Nhap Doanh Thu Quy: ");
            doanhThu.DoanhThuQuy = double.Parse(Console.ReadLine());
            Console.Write("Nhap Doanh Thu Nam: ");
            doanhThu.DoanhThuNam = double.Parse(Console.ReadLine());

            doanhThu.XuatThongTin(doanhThu);
        }

        void XuatThongTin(DoanhThu doanhThu)
        {
            Console.WriteLine("\n ====> THONG TIN DOANH THU LA <==== \n");
            Console.WriteLine("Doanh Thu Thang: " + doanhThu.DoanhThuThang);
            Console.WriteLine("Doanh Thu Quy: " + doanhThu.DoanhThuQuy);
            Console.WriteLine("Doanh Thu Nam: " + doanhThu.DoanhThuNam);
        }
    }
}
