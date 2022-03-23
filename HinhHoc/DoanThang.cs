using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HinhHoc
{
    public class DoanThang : HinhHoc
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
        public DoanThang(Point a, Point b)
        {
            _A = a;
            _B = b;
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
            g.DrawLine(new Pen(Color.Gold, 5), _A, _B);
        }
    }
}