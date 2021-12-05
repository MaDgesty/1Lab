using System;

namespace _1_личное
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите х: "); int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b: "); int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите a: "); int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите sin(от 0 до 1 (с запятой)): "); double s = Convert.ToDouble(Console.ReadLine());
                while (true)
                {
                    if (s < 0 | s > 1) { Console.WriteLine("Введите число sin в диапозоне от 0 до 1!!! "); break; }
                    else
                    {
                        double R = Math.Pow(x, 2) * (x + 1) / b - Math.Pow(Math.Sin(s), 2) * (x + a);
                        Console.WriteLine("Ответ = " + R);
                        break;
                    }
                }

            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
}