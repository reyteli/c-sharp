using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++;
                while (b >= c)
                {
                    b -= c;
                    n++;
                }
                int count = 0;
                for (int i = 0; i < k; i++)
                    count += n;
                Console.WriteLine("N= " + count);
            }
        } 
    }
}
