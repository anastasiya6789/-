using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета треугольника");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            int b = 1;
            string x = "";
            string y = " ";
            string z = "*";
            string d = "*";
            Console.WriteLine("*");
            do
            {
                a += 1;
                Console.WriteLine($"*{x}*");
                x += y;
            } while (a < n);
            while (b != n)
            {
                z += d;
                b += 1;
            }
            Console.WriteLine(z);
        }
    }
}