using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер вашего класса:");
            double x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 0:
                    Console.WriteLine("Отойди от компьютера!");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Вы в младшем классе!");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Вы в среднем классе!");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("Вы в старшем классе!");
                    break;
                default:
                    Console.WriteLine("Читайте условия внимательнее");
                    break;
            }
        }
    }
}