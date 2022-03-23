using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public class Window
    {
        private int left;
        private int top;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Ve Window tai Top {0} ---- Left {1}", top, left);
        }
    }
}
