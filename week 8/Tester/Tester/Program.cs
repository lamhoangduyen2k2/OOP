using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class AppWindow
    {
        // Protected members
        protected int top;
        protected int left;
        // constructor takes two integers to fix location on the console
        public AppWindow (int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // simulates drawing the AppWindow
        public virtual void CreateWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
    }
    // ListBox derives from AppWindow
    public class ListBox : AppWindow
    {
        private string listBoxContent;
        // constructor adds a parameter and also call base constructor
        public ListBox (int top, int left, string contents) : base(top, left)
        {
            listBoxContent = contents;
        }
        // Overriding CreateWindow
        public override void CreateWindow()
        {
            base.CreateWindow(); // invoking base method
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContent);
        }
    }
    // Button derives from AppWindow
    public class Button : AppWindow
    {
        public Button(int top, int left) : base(top,left)
        { }
        // Overriding CreateWindow
        public override void CreateWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
    public class Tester
    {
        public static void Main(string[] args)
        {
            AppWindow win = new AppWindow(-110, -0);
            win.CreateWindow();
            win = new ListBox(3, 4, "This is a list box");
            win.CreateWindow();
            win = new Button(5, 6);
            win.CreateWindow();
        }
    }
}
