using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i;
            for (i = 101; i <= 200; i++)
            {
                int f = 0;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
