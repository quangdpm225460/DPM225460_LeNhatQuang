using System;
namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class Client
    {
        private NhanVien _nhanVien;
        private QuanLy _quanLy;
        // Constructor
        public Client(PhongBan phongBan)
        {
            _nhanVien = phongBan.TaoNhanVien();
            _quanLy = phongBan.TaoQuanLy();
        }
        public void Run()
        {
            _nhanVien.LamViec();
            _quanLy.DieuHanh(_nhanVien);
        }
    }
}