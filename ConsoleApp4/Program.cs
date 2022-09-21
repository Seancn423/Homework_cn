using System;

namespace ConsoleApp4
{
    class Program
    {
        /*public static bool isZhi(int n) {
            int i;
            for (i = 2; i < n; i++) {
                if (n % i == 0) break;
            }
            if (i == n) return true;
            else return false;
        }*/
        public static void f(int n,int k) {
            if (k == n) {
                Console.Write(k+"@");
            } 
            else if (n % k == 0 && n/k!=1) {
                Console.Write(k+"*");
                f(n / k, k);
            }
            /*else if (n % k == 0 && n / k == 1)
            {
                Console.WriteLine(k);
                f(n / k, k);
            }*/

            else f(n, k + 1);
            
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            f(a, 2);
        }
    }
}
