using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class QuanLyKyThuat : QuanLy
    {
        public override void DieuHanh(NhanVien a)
        {
            Console.WriteLine(this.GetType().Name +
              " dieu hanh " + a.GetType().Name);
        }
    }
}
