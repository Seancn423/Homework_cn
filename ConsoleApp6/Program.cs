using System;

namespace ConsoleApp6
{
    class Program
    {

        public static void TempSwap(int a,int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static int maxShare(int m, int n) {
            int i;
            if(m>n)TempSwap(m, n);
            for (i = m; i >= 1; i--) {
                if (m % i == 0 && n % i == 0) return i;
            }
            return 0;
        }
        public static int minShare(int m, int n)
        {
            int i;
            if (m > n) TempSwap(m, n);
            for (i = n;i<=m*n; i++)
            {
                if (i%m == 0 && i%n == 0) return i;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大公约数："+maxShare(a, b));
            Console.WriteLine("最小公倍数："+minShare(a, b));
        }
    }
}
