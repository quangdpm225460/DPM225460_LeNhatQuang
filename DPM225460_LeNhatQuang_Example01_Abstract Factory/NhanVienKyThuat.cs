using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class NhanVienKyThuat : NhanVien
    {
        public override void LamViec()
        {
            Console.WriteLine("Nhan vien ky thuat dang phat trien phan mem");
        }
    }
}
