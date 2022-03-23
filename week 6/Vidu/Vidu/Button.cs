using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu
{
    public class Button : Window
    {
        public Button(int top, int left) :base(top,left)
        {
        }

        public override void DrawWindow()
        {
            base.count(2);
            Console.WriteLine(" Drawing a button at {0}: {1}", top, left);
        }
    }
}
