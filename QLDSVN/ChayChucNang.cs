using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSVN
{
    public class ChayChucNang
    {
        private readonly INhanVien _nhanVien;
        public ChayChucNang(INhanVien nhanVien)
        {
            _nhanVien = nhanVien;
        }

        public void XuatDanhSachNhanVien()
        {
            _nhanVien.XuatThongTinNhanVien();
        }
    }
}
