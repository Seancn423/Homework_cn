using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 4; i++) {
                for (int j = 1; j <= 4; j++) {
                    for (int k = 1; k <= 4; k++) {
                        if (i == j || i == k || j == k) { }
                        else {
                            sum++;
                            Console.WriteLine((i * 100 + j * 10 + k) + " ");
                        }
                    }
                }
            }
            Console.WriteLine("共有"+sum+"个符合条件的数");
        }
    }
}
