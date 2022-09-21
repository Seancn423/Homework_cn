using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double score= Convert.ToInt32(Console.ReadLine());
            if (score >= 90) Console.WriteLine("A");
            else if (score >= 60) Console.WriteLine("B");
            else Console.WriteLine("C");
        }
    }
}
