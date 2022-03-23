using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
   public class ListBox : Window
    {
        private string listBoxContents;

        public ListBox(int top, int left, string contents) :base(top, left)
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Thuoc ve ListBox {0}", listBoxContents);
        }
    }
}
