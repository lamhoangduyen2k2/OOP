﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class MainFunc
    {
        static void Main(string[] args)
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4, "Viet lai ham cua listbox");
            Button bt = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            bt.DrawWindow();
            // Doi voi mang
            Window[] winArr = new Window[3];
            winArr[0] = new Window(1, 2);
            winArr[1] = new ListBox(3, 4, "tuong tu tren listbox");
            winArr[2] = new Button(5, 6);
            Console.WriteLine("In ra cac thanh phan Array");
            for(int i = 0; i < 3; i++)
            {
                winArr[i].DrawWindow();
            }
        }
    }
}
