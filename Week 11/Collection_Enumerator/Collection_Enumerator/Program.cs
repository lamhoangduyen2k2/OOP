using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Enumerator
{
    public class ListBoxTest : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)new ListBoxEnumerator(this);
        }
        private class ListBoxEnumerator : IEnumerator
        {
            private ListBoxTest lbt;
            private int index;
            public ListBoxEnumerator(ListBoxTest lbt)
            {
                this.lbt = lbt;
                index = -1;
            }

            public bool MoveNext()
            {
                index++;
                if (index >= lbt.strings.Length)
                    return false;
                else
                    return true;
            }

            public void Reset()
            {
                index = -1;
            }
            public object Current
            {
                get
                {
                    return (lbt[index]);
                }
            }
        }
        public ListBoxTest(params string[] initStr)
        {
            strings = new String[10];
            foreach (string s in initStr)
            {
                strings[ctr++] = s;
            }
        }
        public void Add(string theString)
        {
            strings[ctr] = theString;
            ctr++;
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strings.Length)
                {
                    // Xử lí index sai
                }
                return strings[index];
            }
            set
            {
                strings[index] = value;
            }
        }
        public int GetNumEntries()
        {
            return ctr;
        }
        private string[] strings;
        private int ctr = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListBoxTest lbt = new ListBoxTest("Hello", "World");
            lbt.Add("A");
            lbt.Add("B");
            lbt.Add("C");
            lbt.Add("D");
            lbt.Add("E");
            string subst = "Them 1 thanh phan vao";
            lbt[1] = subst;
            int count = 1;
            foreach (string s in lbt)
            {
                Console.WriteLine("Value {0}: {1}", count, s);
                count++;
            }
            Console.ReadLine();
        }
    }
}
