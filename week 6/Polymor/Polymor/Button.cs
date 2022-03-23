using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public class Button:Window
    {
        public Button(int top, int left) :base(top,left)
        {
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("ve lai button");
        }
    }
}
