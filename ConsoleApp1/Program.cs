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


            //Задача 18
            //Random rnd = new Random();
            //    int elem = rnd.Next(-30,30);
            //    if (elem > 0)
            //    {
            //        Console.WriteLine($"{elem} - положительный");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{elem} - отрицательный");

            //    }


            //Задача 19




            //Задача 20

            Console.Write("Введите день недели: ");
            byte day = byte.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;

                default: Console.WriteLine("Errorchik");break;
            }
            Console.ReadKey();

        }
    }
}
