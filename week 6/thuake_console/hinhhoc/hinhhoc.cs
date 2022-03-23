using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace hinhhoc
{
    public abstract class hinhhoc
    {
        private Point _Tam;

        protected Point Tam
        {
            get { return _Tam; }
            set { _Tam = value; }
        }
        public abstract double ChuVi();

        public abstract double DienTich();

        public abstract void Ve(Graphics g);
    }
}
