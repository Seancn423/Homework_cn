using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double l = 100;
            for (int i = 1; i <= 10; i++) {
                l = l / 2;
                s += l;
            }
            Console.WriteLine("第十次弹起高度" + l + "米");
            Console.WriteLine("共经过"+s+"米");
        }
    }
}
