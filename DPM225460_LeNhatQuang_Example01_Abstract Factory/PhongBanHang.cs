using System;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class PhongBanHang : PhongBan
    {
        public override NhanVien TaoNhanVien()
        {
            return new NhanVienBanHang();
        }
        public override QuanLy TaoQuanLy()
        {
            return new QuanLyBanHang();
        }
    }
}
