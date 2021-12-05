using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a1: ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("b1: ");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("c1: ");
                int c1 = Convert.ToInt32(Console.ReadLine());

                int d1 = a1 + b1 + c1;

                Console.Write("a2: ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("b2: ");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("c2: ");
                int c2 = Convert.ToInt32(Console.ReadLine());

                int d2 = a2 + b2 + c2;

                Console.Write("a3: ");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("b3: ");
                int b3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("c3: ");
                int c3 = Convert.ToInt32(Console.ReadLine());

                int d3 = a3 + b3 + c3;

                int matrixdeterminant = (a1 * b2 * c3) + (a3 * b1 * c2) + (a2 * b3 * c1) - (c1 * b2 * a3) - (a2 * b1 * c3) - (a1 * b3 * c2);
                if (matrixdeterminant == 0)
                {
                    Console.WriteLine("Определитель матрицы = 0");
                }
                else
                {
                    double determinantx = (d1 * b2 * c3) + (d3 * b1 * c2) + (d2 * b3 * c1) - (c1 * b2 * d3) - (d2 * b1 * c3) - (d1 * b3 * c2);
                    double x = determinantx / matrixdeterminant;
                    Console.WriteLine("x =" + x);
                    double determinanty = (a1 * d2 * c3) + (a3 * d1 * c2) + (a2 * d3 * c1) - (c1 * d2 * a3) - (a2 * d1 * c3) - (a1 * d3 * c2);
                    double y = determinanty / matrixdeterminant;
                    Console.WriteLine("y =" + y);
                    double determinantz = (a1 * b2 * d3) + (a3 * b1 * d2) + (a2 * b3 * d1) - (d1 * b2 * a3) - (a2 * b1 * d3) - (a1 * b3 * d2);
                    double z = determinantz / matrixdeterminant;
                    Console.WriteLine("z =" + z);
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
           
        }
    }
}