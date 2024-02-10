using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _12._1
{
    public static class Circle
    {
        public static string GetLength(double r)
        {
            double length = 2 * Math.PI * r;
            return $"Длина окружности с радиусом {r} составляет {length}";
        }

        public static string GetSquare(double r)
        {
            double square = Math.PI * Math.Pow(r, 2);
            return $"Площадь окружности с радиусом {r} составляет {square}";
        }
        public static string CheckPoint(double x0, double y0, double x, double y, double r)
        {
            if ((Math.Abs(x) - Math.Abs(x0) < r) && (Math.Abs(y) - Math.Abs(y0) < r))
            {
                return "Точка принадлежит кругу";
            }
            else
            {
                return "Точка не принадлежит кругу";
            }
        }
    }
}
