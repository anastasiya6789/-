using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 7; i++)
            {
                Console.WriteLine($"Таблица умножения на {i}");
                for (int x = 2; x < 10; x++)
                {
                    Console.WriteLine($"{x} * {i} = {x * i}");
                }
                Console.WriteLine();
            }

        }
    }
}