using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 100; i <= 999; i++) {
                int a = i % 10;
                int b = (i - a) % 100;
                int c = i / 100;
                if (i == Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3)) {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
