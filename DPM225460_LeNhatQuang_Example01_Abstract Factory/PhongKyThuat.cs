using System;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class PhongKyThuat : PhongBan
    {
        public override NhanVien TaoNhanVien()
        {
            return new NhanVienKyThuat();
        }
        public override QuanLy TaoQuanLy()
        {
            return new QuanLyKyThuat();
        }
    }

}
