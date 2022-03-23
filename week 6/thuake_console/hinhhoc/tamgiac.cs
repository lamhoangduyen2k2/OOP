using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace hinhhoc
{
    public class tamgiac : hinhhoc
    {
        private Point _A;
        private Point _B;
        private Point _C;

        public Point B { get; set; }
        public Point C { get; set; }
        public Point A { get { return _A; } set { _A = value; } }

        public Point Tam
        {
            get { return new Point((_A.X + _B.X + _C.X) / 3, (_A.Y + _B.Y + _C.Y) / 3); }
        }
        public tamgiac() { }

        public tamgiac(Point a, Point b, Point c)
        {
            _A = a;
            _B = b;
            _C = c;
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
            Console.WriteLine("Tam giac:.....");
            g.DrawLine(new Pen(Color.Red, 5), _A, _B);
            g.DrawLine(new Pen(Color.Red, 5), _B, _C);
            g.DrawLine(new Pen(Color.Red, 5), _C, _A);
        }
    }
}
