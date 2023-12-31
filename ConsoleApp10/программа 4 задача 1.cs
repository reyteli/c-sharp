using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= N ; i++)
            {
                s += 2 * i - 1;
                
            }
            Console.WriteLine( s);
            Console.ReadKey();
        }
    }
}

