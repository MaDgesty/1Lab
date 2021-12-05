using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int hour;
                int hourrest;
                int min;
                Console.Write("Введите кло-во секунд: ");
                int data = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (data < 0)
                    {
                        Console.Write("Время не может быть отрицательным");
                        break;
                    }
                    else if(data != 0)
                    {
                        hour = data / 3600;
                        Console.WriteLine("Часы " + hour);
                        hourrest = data % 3600;
                        min = hourrest / 60;
                        Console.WriteLine("Минуты " + min);
                        break;
                    }
                    else if(data == 0)
                    {
                        Console.WriteLine("Число равно нулю, какое время ты хочешь увидеть?");
                        break;
                    }

                }
                Console.ReadKey();
            }
            catch
            {
                while (true)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}