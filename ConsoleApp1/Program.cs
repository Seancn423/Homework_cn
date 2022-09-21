using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int r(int b)
        {
            int[] a;
            a = new int[100];
            int i;
            a[0] = 1;
            a[1] = 1;
            for (i = 2; i <= b; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            return a[b];
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(r(n));
        }
    }
}
