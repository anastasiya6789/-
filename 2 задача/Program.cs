using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, b = -1;
            Console.WriteLine("Введите предел:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i = i += 2)
            {
                a = i;
                sum += a;
                b += 1;
            }
            Console.WriteLine($"количество от 1 до {n} равно {b} и сумма {sum}");
        }
    }
}