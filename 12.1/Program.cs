using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Длина окружности
            Console.WriteLine("Введите радиус для вычисления длины окружности");
            double r_length = Convert.ToDouble(Console.ReadLine());
            string answer_length = Circle.GetLength(r_length);
            Console.WriteLine(answer_length);
            Console.WriteLine();

            //Площадь круга
            Console.WriteLine("Введите радиус для вычисления площади круга");
            double r_square = Convert.ToDouble(Console.ReadLine());
            string answer_square = Circle.GetSquare(r_square);
            Console.WriteLine(answer_square);
            Console.WriteLine();

            //Принадлежность точки
            Console.WriteLine("Введите координату x0 центра круга");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y0 центра круга");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x проверяемой точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y проверяемой точки");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            
            string answer_point = Circle.CheckPoint(x0, y0, x, y, r);
            Console.WriteLine(answer_point);
            Console.ReadKey();
        }
    }
}
