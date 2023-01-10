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
            try
            {
                Rectangleintegral RectangleIntegral1 = new Rectangleintegral(0, 1);
                RectangleIntegral1.FuncToIntegrate(1);
            }
            catch(IntegralExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
/*            Console.WriteLine(RectangleIntegral1.FuncToIntegrate(0));*/
        }
    }
}
