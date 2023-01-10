using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegralLib;
namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangleintegral RectangleIntegral1 = new Rectangleintegral(12.9534,67.0923);
            Console.WriteLine(RectangleIntegral1.RectangleIntegralCalculate());
        }
    }
}
