using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);

            lb.DrawWindow();
            b.DrawWindow();
        }
    }
}
