using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            var n = int.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            foreach (int i in array)
            {
                if (i == max)
                {
                    s++;
                }
            }
            Console.WriteLine($"{max} колличество = {s}");
        }
    }
}