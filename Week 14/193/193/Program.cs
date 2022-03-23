﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _193
{
    class Program
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread Number 1 (English)";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread Number 2 (Spanish)";
            t2.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                if (i == 31)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " is about to be aborted");
                    t1.Abort();
                }
                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " Hola...");
            }
        }
    }
}
