using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость товара:");
            double a;
            double b;
            double x = Convert.ToInt32(Console.ReadLine());

            if (x >= 500 && x <= 1000)
            {
                a = x * 0.97;
                Console.WriteLine("Цена товара с учетом скидки: " + a);
            }
            else if (x > 1000)
            {
                b = x * 0.95;
                Console.WriteLine("Цена товара с учетом скидки: " + b);
            }
        }
    }
}