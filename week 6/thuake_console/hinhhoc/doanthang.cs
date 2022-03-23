using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace hinhhoc
{
    public class doanthang : hinhhoc
    {
        private Point _A;
        private Point _B;

        public Point A
        {
            get;
            set;
        }
        public Point B
        {
            get;
            set;
        }
        public doanthang(Point a, Point b)
        {
            _A = a;
            _B = b;
        }

        public override double ChuVi()
        {
            throw new System.NotImplementedException();
        }

        public override double DienTich()
        {
            throw new System.NotImplementedException();
        }

        public override void Ve(Graphics g)
        {
            g.DrawLine(new Pen(Color.Red, 5), _A, _B);
        }
    }
}
