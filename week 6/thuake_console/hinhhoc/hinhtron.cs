using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace hinhhoc
{
    public class hinhtron : hinhhoc
    {
        private Point _A;
        private Point _B;
        private Point _C;
        private Point _D;

        public Point B { get; set; }
        public Point D { get; set; }
        public Point C { get; set; }
        public Point A { get { return _A; } set { _A = value; } }
        public hinhtron() { }

        public hinhtron(Point a, Point b, Point c, Point d)
        {
            _A = a;
            _B = b;
            _C = c;
            _D = d;
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
            Console.WriteLine("Hinh Tron:.....");
            g.DrawEllipse(new Pen(Color.Red, 5), new Rectangle(275, 10, 100, 100));
        }
    }
}
