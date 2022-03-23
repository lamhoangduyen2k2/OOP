using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maTrix
{
    class matran
    {
        private int _dong;

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
        private int _cot;

        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }
        int[,] mt;
        public matran(int d, int c)
        {
            Dong = d;
            Cot = c;
            mt = new int[Dong, Cot];
        }
        public void nhap()
        {
            for (int i = 0; i < Dong; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                nhaplai:
                    try
                    {
                        Console.Write("nhap vao phan tu thu a[{0}][{1}]:\t", i, j);
                        mt[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Loi :\t" + e.Message);
                        goto nhaplai;
                    }
                }
            }
        }
        public void xuat()
        {
            for (int i = 0; i < Dong; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    Console.Write("\t" + mt[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static matran operator +(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] + b.mt[i, j];
                }
            }
            return c;
        }
        public static matran operator -(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] - b.mt[i, j];
                }
            }
            return c;
        }
        public static matran operator *(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = b.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = 0;
                    for (int k = 0; k < b.Dong; k++)
                    {
                        c.mt[i, j] += a.mt[i, k] * b.mt[k, j];
                    }
                }
            return c;
        }
        public int this[int dong, int cot]
        {
            get
            {
                for (int i = 0; i < Dong; i++)
                {
                    for (int j = 0; j < Cot; j++)
                    {
                        if (dong == i && cot == j)
                            return mt[i, j];
                    }
                }
                return -100;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao dong ma tran a:\t");
            int dong = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua ma tran a:\t");
            int cot = int.Parse(Console.ReadLine());
            matran a = new matran(dong, cot);
            a.nhap();
            a.xuat();
            Console.Write("\n\nnhap vao dong ma tran b:\t");
            dong = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua ma tran b:\t");
            cot = int.Parse(Console.ReadLine());
            matran b = new matran(dong, cot);
            b.nhap();
            b.xuat();
        menu:
            int chon;
            Console.WriteLine("\n\n\t......Moi lan lam viec xong menu nay deu hien ra......\n\n");
            Console.WriteLine("                     0 de thoat");
            Console.WriteLine("                     1 xuat ma tran");
            Console.WriteLine("                     2 tong hai ma tran");
            Console.WriteLine("                     3 hieu hai ma tran");
            Console.WriteLine("                     4 tich hai ma tran");
            Console.WriteLine("                     5 tim he so theo chi muc");
            Console.WriteLine("\n\n\t.....................................................\n\n");
            try
            {
                Console.Write("nhap mot so trong menu:\t");
                chon = int.Parse(Console.ReadLine());
                if (chon < 0 || chon > 5)
                    goto menu;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n Da co loi" + e.Message);
                goto menu;
            }
            switch (chon)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("\n\nma tran a");
                    a.xuat();
                    Console.WriteLine("\n\nma tran b");
                    b.xuat();
                    goto menu;

                case 2:
                    if (a.Dong == b.Dong && a.Cot == b.Cot)
                    {
                        matran c = a + b;
                        Console.WriteLine("\n\n\ntong hai ma tran la");
                        c.xuat();
                    }
                    else
                    {
                        Console.WriteLine("\n\n\nhai ma tran nay khong cong duoc");
                    }
                    goto menu;
                case 3:
                    if (a.Dong == b.Dong && a.Cot == b.Cot)
                    {
                        matran c = a - b;
                        Console.WriteLine("\n\n\ntong hai ma tran la");
                        c.xuat();
                    }
                    else
                    {
                        Console.WriteLine("\n\nhai ma tran nay khong tru duoc");
                    }
                    goto menu;
                case 4:
                    if (a.Cot != b.Dong)
                    {
                        Console.WriteLine("\n\nkhong the thuc hien phep nhan hai ma tran");
                    }
                    else
                    {
                        Console.WriteLine("\n\ntich hai ma tran la:");
                        matran c = a * b;
                        c.xuat();
                    }
                    goto menu;
                case 5:
                laimatrancantim:
                    Console.Write("nhap vao ma tran can tim theo chi  muc (a hoac b):\t");
                    string mtcantim = Console.ReadLine();
                    if (mtcantim == "a")
                    {
                    laidongcottim:
                        Console.Write("nhap vao dong:\t");
                        int dd = int.Parse(Console.ReadLine());
                        Console.Write("nhap vao cot:\t");
                        int cc = int.Parse(Console.ReadLine());
                        if (dd > a.Dong || cc > a.Cot)
                        {
                            Console.WriteLine("khong duoc nhap so qua lon");
                            goto laidongcottim;
                        }
                        else
                        {
                            if (a[dd, cc] == -100)
                            {
                                Console.WriteLine("he so nay khong ton tai");
                            }
                            else
                                Console.WriteLine("\n\nGia tri tim duoc la:\t" + a[dd, cc]);
                        }
                    }
                    else if (mtcantim == "b")
                    {
                    laidongcottim:
                        Console.Write("nhap vao dong:\t");
                        int dd = int.Parse(Console.ReadLine());
                        Console.Write("nhap vao cot:\t");
                        int cc = int.Parse(Console.ReadLine());
                        if (dd > b.Dong || cc > b.Cot)
                        {
                            Console.WriteLine("khong duoc nhap so qua lon");
                            goto laidongcottim;
                        }
                        else
                        {
                            if (b[dd, cc] == -100)
                            {
                                Console.WriteLine("he so nay khong ton tai");
                            }
                            else
                                Console.WriteLine("\n\nGia tri tim duoc la:\t" + b[dd, cc]);
                        }

                    }
                    else
                    {
                        Console.WriteLine("khong co ma tran nay");
                        goto laimatrancantim;
                    }
                    goto menu;
                default:
                    goto menu;
                    break;
            }

            Console.ReadLine();
        }
    }
}
