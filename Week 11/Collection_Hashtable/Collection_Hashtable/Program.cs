using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hst = new Hashtable();
            hst.Add(001, "Cuong");
            hst.Add(002, "Minh");
            hst.Add(003, "Khoi");
            Console.WriteLine("So luong thanh phan trong hash tbl " + hst.Count);
            ICollection obClec = hst.Keys;
            Console.WriteLine("Gia tri ban dau:");
            foreach (object i in obClec)
            {
                Console.WriteLine(i + ":" + hst[i]);
            }
            if (hst.ContainsKey(002))
            {
                hst[002] = "Thanh";
            }
            Console.WriteLine("Gia tri moi:");
            foreach (object i in obClec)
            {
                Console.WriteLine(i + ":" + hst[i]);
            }
            Console.ReadKey();
        }
    }
}
