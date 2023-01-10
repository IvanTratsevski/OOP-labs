using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customArrsLib;
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            SingleArr A = new SingleArr();
            SingleArr B = new SingleArr();
            SingleArr C = new SingleArr();
            Console.WriteLine("Enter amounts and elements of arrays");
            Console.WriteLine("A:");
            A.enterArr();
            Console.WriteLine("B:");
            B.enterArr();
            Console.WriteLine("C:");
            C.enterArr();
            Console.WriteLine("Arrays:");
            Console.WriteLine("A:");
            A.printArr();
            Console.WriteLine("B:");
            B.printArr();
            Console.WriteLine("C:");
            C.printArr();
            Console.WriteLine("Task 2");
            Console.WriteLine(new SingleArr(SingleArr.multiplication(A.getArr(), B.getArr())).getAmountOfNegative());
            Console.WriteLine("Task 3");
            double lookAfterNumb = -100.0;
            Console.WriteLine("A: " + A.getAmountOfNegative(lookAfterNumb));
            Console.WriteLine("C: " + B.getAmountOfNegative());
        }
    }
}
