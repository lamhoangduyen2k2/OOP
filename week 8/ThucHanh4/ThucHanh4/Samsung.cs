using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh4
{
    class Samsung : Devices
    {
        public Samsung(string name, int year, string color, int seri) : base(name, year, color, seri)
        { }
        public override void Information()
        {
            base.Information();
        }
        public override void HoatDong()
        {
            base.HoatDong();
        }
        public override void UsingGSM()
        {
            base.UsingGSM();
        }
    }
}
