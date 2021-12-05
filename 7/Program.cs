using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(" Введите трёхзначное число ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 100 | a > 999)
                {
                    Console.WriteLine(" Введите трёхзначное число ");
                }
                int b = a / 100;
                int c = (a / 10) % 10;
                int d = a % 10;
                Console.WriteLine($"Число :{b}{c}{d}");
                (b, d) = (d, b);
                Console.WriteLine($"reversed : {b}{c}{d}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
           
        }
    }
}