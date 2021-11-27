using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var mas = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int min = mas[0];
            int b = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    b = i;
                }
            }
            Console.WriteLine($"min = {min} and namber element = {b}");
        }
    }
}