using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;
            while (N > 0)
            {
                if (N % 2 == 0)
                {
                    count++;
                    sum += N;
                }

                N -= 1;
            }

            Console.WriteLine("Количество парных {0}; Сумма парных: {1}", count, sum);

            Console.ReadLine();
        }
    }
}