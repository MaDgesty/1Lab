using System;
using System.Collections;
namespace Table
{
    public class Lab1_10
    {
        public enum Type
        {
            Р, К, РПБ
        }
        public class Item
        {
            public String Name;
            public Type type;
            public string adress;
            public double rating;
            public Item(string Name, Type type, string adress, double rating)
            {
                this.Name = Name;
                this.type = type;
                this.adress = adress;
                this.rating = rating;
            }
            public void Print()
            {
                Console.WriteLine($"|{this.Name,-24}|{this.type,-12}|{this.adress,-20}|{this.rating,-15}|"); 
            }
        }
        private static void Main()
        {
            ArrayList list = new();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");
                Console.Write("Название: ");
                string Name = Console.ReadLine();
                Type type;
                while (true)
                {
                    Console.Write("Вид (Р, К, РПБ): ");
                    string tmp = Console.ReadLine();
                    if (tmp == "Р" || tmp == "H")
                    {
                        type = Type.Р;
                        break;
                    }
                    else if (tmp == "К" || tmp == "R")
                    {
                        type = Type.К;
                        break;
                    }
                    else if (tmp == "РПБ" || tmp == "HG<")
                    {
                        type = Type.РПБ;
                        break;
                    }
                    else Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                }
                Console.Write("Адрес: ");
                string adress = Console.ReadLine();
                Console.Write("Рейтинг (из 10): ");
                double rating = double.Parse(Console.ReadLine());
                Item value = new(Name, type, adress, rating);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Рестораны и кафе",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Название",-25}|{"Вид",-12}|{"Адрес",-20}|{"Рейтинг(из 10)",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Р – ресторан, РБП – ресторан быстрого питания, К – кафе",-75}|");
            Console.WriteLine(new String('-', 76));
        }
    }
}