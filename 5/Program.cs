using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                int b;
                double S;
                double P;
                Console.Write("Введите a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b:");
                b = Convert.ToInt32(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("Катет не может быть отрицательным");
                }
                if (b <= 0)
                {
                    Console.WriteLine("Катет не может быть отрицательным");
                }

                S = (a * b) / 2;
                Console.WriteLine("S =" + S);
                P = (Math.Sqrt((Math.Pow(b, 2) + Math.Pow(a, 2))) + b + a);
                Console.WriteLine("P =" + P);
                Console.ReadKey();
            }
            catch { Console.WriteLine("Вы Ввели не число"); }
            
        }
    }
}