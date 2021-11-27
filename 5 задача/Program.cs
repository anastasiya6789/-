using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что бы увидеть таблицу умножения введите A");
            string a = Console.ReadLine();
            string z = "A";
            int sum;
            if (a == z)
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        sum = i * j;
                        Console.WriteLine($"{i} x {j} = {sum}");
                    }
                }
            }
            else Console.WriteLine("Видимо эта программа не очень нужна");
        }
    }
}