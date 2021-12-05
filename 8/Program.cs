using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ввдите х: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double res;
                res = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
                Console.WriteLine("Ответ:" + res);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
            }
            
        }
    }
}