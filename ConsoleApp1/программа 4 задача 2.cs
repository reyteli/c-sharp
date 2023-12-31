using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var pr = 1;
            int buf;
            do
            {
                buf = int.Parse(Console.ReadLine());
                if (buf > 0)
                    sum += buf;
                else
                    if (buf != 0)
                    pr *= buf;
            }
            while (buf != 0);
            if (sum > pr)
                Console.WriteLine("Сумма ({0}) больше произведения ({1})", sum, pr);
            else
                if (sum < pr)
                Console.WriteLine("Произведение ({1}) больше суммы ({0})", sum, pr);
            else
                Console.WriteLine("Произведение ({1}) и сумма ({0}) равны", sum, pr);
            Console.ReadKey();
        }
    }
}
