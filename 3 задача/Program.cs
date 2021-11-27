using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            Console.WriteLine("Введите с какого числа начнется прогрессия");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите до какого числа будет идти прогрессия");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = b; i <= c; i++)
            {
                a = i;
                sum += a;
            }
            Console.WriteLine($"Сумма {c} членов арифметической прогрессии равна {sum}.");
        }
    }
}