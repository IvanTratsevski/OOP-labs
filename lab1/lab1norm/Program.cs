using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace lab1norm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[4], y = new double[4];
            double pointX,pointY;
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Введите x{i} и y{i} \n");
                x[i] = Convert.ToDouble(Console.ReadLine());
                y[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Введите координаты точки для проверки");
            pointX = Convert.ToDouble(Console.ReadLine()); 
            pointY = Convert.ToDouble(Console.ReadLine());
            Figure.Parallel p1 = new Figure.Parallel(x,y);
            double[] sides = p1.getSides();
            if (p1.isReal())
            {
                Console.WriteLine("It's real");
                Console.WriteLine("Square " + p1.getSquare());
                Console.WriteLine("Perimetr " + p1.getPerimeter());
                Console.WriteLine("Sides:");
                for (int i = 0; i < sides.Length; i++)
                {
                    Console.WriteLine(sides[i]);
                }
                Console.WriteLine(p1.doesInclude(pointX, pointY));
            }
            else
            {
                Console.WriteLine("It's not real");
            }
        }
    }
}