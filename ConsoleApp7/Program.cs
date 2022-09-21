using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int le = 0;
            int sp = 0;
            int num = 0; 
            int symbol = 0;
            str = Console.ReadLine();
            char[] c = str.ToCharArray();//把字符串转换成字符数组
            foreach (char i in c)
            {
                if (i >= 'a' && i <= 'z' || i >= 'A' && i <= 'Z')
                    le++;
                else if (i >= '0' && i <= '9')
                    num++;
                else if (i == ' ')
                    sp++;
                else
                    symbol++;
            }
            Console.WriteLine("字母有" + le + "个，空格有" + sp + "个，数字有" + num + "个，其它字符有" + symbol + "个.");
            Console.ReadLine();

        }
    }
}
