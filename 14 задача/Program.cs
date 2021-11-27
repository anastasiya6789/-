using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt16(Console.ReadLine());
            var mas = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int s = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                s = s + mas[i];
            }
            s /= n;
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == 0)
                {
                    mas[i] = s;
                }
                Console.Write($"{mas[i]} ");
            }
        }
    }
}