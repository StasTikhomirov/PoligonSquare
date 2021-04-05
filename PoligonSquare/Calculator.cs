using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonSquare
{
    public static class Calculator
    {
        /// <summary>
        /// Вычисляет площадь многоугольника
        /// </summary>
        /// <param name="pointsList">Список координат</param>        
        public static double GetPoligonSquare(List<Point> pointsList)
        {
            var points = pointsList.ToArray();
            double generalSum = 0;
            int sum = 0;
            int xP1;
            int yK1;
            int xP2 = 0;
            int yK2 = 0;
                       
            for (int i = 0; i<points.Length - 1;i++)
            {
                sum = 0;
                xP1 = points[i].X;
                yK1 = points[i].Y;

                xP2 = points[i + 1].X;
                yK2 = points[i + 1].Y;

                sum = (xP1 + xP2) * (yK2 - yK1);

                generalSum += sum;                                
            }

            // Замыкаем многоугольник
            generalSum += (xP2 + points[0].X) * (points[0].Y - yK2);
                        
            if (generalSum < 0)
            {
                generalSum = -generalSum;
            }

            return generalSum / 2;
        }        
    }
}
