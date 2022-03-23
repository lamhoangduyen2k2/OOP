using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viduSGK
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
        abstract public void DrawWindow();

        abstract public void VeHinh();
    }
}
