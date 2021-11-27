using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i <= m; i++)
            {
                int j = 0;
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}