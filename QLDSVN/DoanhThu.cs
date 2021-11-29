using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSVN
{
    class DoanhThu
    {
        public double DoanhThuThang { get; set; }
        public double DoanhThuQuy { get; set; }
        public double DoanhThuNam { get; set; }


        public void XuatThongTin(DoanhThu doanhThu)
        {
            Console.WriteLine("\n ====> THONG TIN DOANH THU LA <==== \n");
            Console.WriteLine("Doanh Thu Thang: " + doanhThu.DoanhThuThang);
            Console.WriteLine("Doanh Thu Quy: " + doanhThu.DoanhThuQuy);
            Console.WriteLine("Doanh Thu Nam: " + doanhThu.DoanhThuNam);
        }
    }
}
