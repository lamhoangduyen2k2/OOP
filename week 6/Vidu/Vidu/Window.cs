using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu
{
    abstract public class Window
    {
        protected int left;
        protected int top;

        public Window()
        {
        }

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public int count(int x)
        {
            x = top;
            return x;
        }

        abstract public void DrawWindow();
    }
}
