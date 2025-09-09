using System;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class NhanVienBanHang : NhanVien
    {
        public override void LamViec()
        {
            Console.WriteLine("Nhan vien ban hang dang ban hang");
        }
    }
}
