using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HinhHoc
{
    public class TuGiac : HinhHoc
    {
        private Point _A, _B, _C,_D;
        public Point B { get; set; }
        public Point D { get; set; }
        public Point C { get; set; }
        public Point A { get { return _A; } set { _A = value; } }
        public TuGiac() { }
        public TuGiac(Point a, Point b, Point c,Point d)
        {
            _A = a;
            _B = b;
            _C = c;
            _D = d;
        }
        public override double ChuVi()
        {
            throw new NotImplementedException();
        }
        public override double DienTich()
        {
            throw new NotImplementedException();
        }
        public override void Ve(Graphics g)
        {
            Console.WriteLine("Tu giac:.....");
            g.DrawLine(new Pen(Color.Pink, 5), _A, _B);
            g.DrawLine(new Pen(Color.Pink, 5), _B, _C);
            g.DrawLine(new Pen(Color.Pink, 5), _C, _D);
            g.DrawLine(new Pen(Color.Pink, 5), _D, _A);

        }
    }
}
