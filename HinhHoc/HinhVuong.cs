using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HinhHoc
{
    public class HinhVuong : HinhHoc
    {
        private Point _A, _B, _C, _D;
        public Point B { get; set; }
        public Point D { get; set; }
        public Point C { get; set; }
        public Point A { get { return _A; } set { _A = value; } }
        public HinhVuong() { }
        public HinhVuong(Point a, Point b, Point c, Point d)
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
            Console.WriteLine("Hinh Vuong:.....");
            g.DrawRectangle(new Pen(Color.Green, 5), new Rectangle(250,10,100,100));

        }
    }
}