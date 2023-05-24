using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 15
            //Console.Write("x =");
            //int x = int.Parse(Console.ReadLine());
            //if (x>0)
            //{
            //    Console.WriteLine($"Число {x} - положительное");
            //}
            //else if (x < 0)
            //{
            //    Console.WriteLine($"Число {x} - отрицательное");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {x} - равно нулю");
            //}


            //Задача 16
            //int a;
            //int b;
            //int c;
            //Console.Write("a =");
            //Console.Write("b =");
            //Console.Write("c =");
            //if (a == b || b == c)
            //{
            //    Console.WriteLine($"Треугольник раваносторонний");
            //}
            //else
            //{
            //    Console.WriteLine($"Треугольник не равносторонний");
            //}


            //Задача 17


            Random rnd = new Random();
            for (int z = 1; z <= 0; z++)
            {
                int elem = rnd.Next(-30,30);
                if (elem > 0)
                {
                    Console.WriteLine($"{elem} - положительный");
                }
                else
                {
                    Console.WriteLine($"{elem} - отрицательный");

                }
            }
            

            Console.ReadKey();

        }
    }
}
