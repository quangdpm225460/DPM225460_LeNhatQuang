using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class QuanLyBanHang : QuanLy
    {
        public override void DieuHanh(NhanVien a)
        {
            Console.WriteLine(this.GetType().Name +
              " dang dieu hanh " + a.GetType().Name);
        }
    }

}
