using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viduSGK
{
    public class ListBox : Window
    {
        private string mListBoxContents;

        public ListBox(int top, int left, string theContents)
        {
            this.top = top;
            this.left = left;
            mListBoxContents = theContents;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("ListBox write: {0}/{1}/{2}", mListBoxContents, top, left);
        }

        public override void VeHinh()
        {
            throw new NotImplementedException();
        }
    }
}
