using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) sum = sum + j;
                }
                if (sum == i) Console.WriteLine(i + " ");
            }
        }
    }
}
