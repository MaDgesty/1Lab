using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строго четырех значное число");
                Console.WriteLine("Введите число:");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 1000 | a>9999)
                {
                    Console.WriteLine("Введите четырехзначное число");
                }
                else
                {
                    double f = (a / 1000);

                    double s = (a / 100) % 10;

                    double t = (a / 10) % 10;

                    double fo = (a % 10);

                    double res;
                    res = f * s * t * fo;
                    Console.WriteLine(res);

                    Console.ReadKey();
                }    
            }
            catch
            {
                Console.WriteLine(" Вы ввели не число ");
            }
            
        }
    }
}