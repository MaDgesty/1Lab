using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите а: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"a: {a} = b: {b}");
                (a, b) = (b, a);
                Console.WriteLine($"a: {a} = b: {b}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
            
        }
    }
}