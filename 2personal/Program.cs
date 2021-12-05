using System;

namespace _2personal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a: "); double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите x: "); double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b: "); double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите cos(от 0,1 до 1 c запятой!!!): "); double cos = Convert.ToDouble(Console.ReadLine());
                if (cos <= 0 | cos > 1)
                {
                    Console.WriteLine("Нужно ввести число от 0,1 до 1");
                }
                else
                {
                    double S = Math.Sqrt(x * b / a) + Math.Pow(Math.Cos(cos), 2) * Math.Pow(x + b, 3);
                    Console.WriteLine("S= " + S);
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не то!");
            }
        }
    }
}
