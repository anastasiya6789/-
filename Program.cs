using System;

namespace _4_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine()), s = 4, i = 1;

            while (i <= n)
                i += s++;
            Console.WriteLine(i);
        }
    }
}
