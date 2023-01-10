using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CountryDefinerLib;
namespace DefineCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string consoleEnter = Console.ReadLine();
            Definer definer = new Definer(consoleEnter);
            Console.Write("Номера телефонов которые удалось опрделить:\n");
            Console.Write(definer.defineCoutries());
            Console.ReadLine();
        }
    }
}