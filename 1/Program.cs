using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                decimal a = Convert.ToDecimal(Console.ReadLine());
                while (true)
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Нужно ввести число больше нуля с запятой");
                        break;
                    }
                    else
                    {
                        int m = (int)a;
                        decimal n = a - (int)a;
                        Console.WriteLine("Целая часть: " + m + " Дробное число: " + n);
                        Console.ReadKey();
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