using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu
{
    public class ListBox : Window
    {
        private string mListBoxContent;

        public ListBox(int top, int left, string theContent) :base(top, left)
        {
            mListBoxContent = theContent;
        }

        public override void DrawWindow()
        {
            base.count(2);
            Console.WriteLine("ListBox write: {0}", mListBoxContent);
        }
    }
}
