using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToAnalyse = "22 + 1 ASDASDAD 4 / 8 FDSFD 2 + 1 DASDASD 20 * 3";

            string searchAny = @"\d+\s[+-/*]\s\d+";
            string searchNumb = @"\d+";
            string searchAction = "[+-/*]";
            Regex regexAny = new Regex(searchAny);
            Regex regexNumb = new Regex(searchNumb);
            Regex regexAction = new Regex(searchAction);
            MatchCollection matchesAny = regexAny.Matches(stringToAnalyse);
            Console.Write(stringToAnalyse + "\n");
            foreach (Match m in matchesAny)
            {
                string currentExp = m.Value;
                MatchCollection matchesNumb = regexNumb.Matches(currentExp);
                MatchCollection matchAction = regexAction.Matches(currentExp);
                string action = matchAction[0].Value;
                double number1 = Double.Parse(matchesNumb[0].Value);
                double number2 = Double.Parse(matchesNumb[1].Value);
                if (action == "+")
                {
                    Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
                } else if (action == "-")
                {
                    Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
                } else if (action == "*")
                {
                    Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
                } else if (action == "/")
                {
                    Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
                }
            }   
            Console.ReadKey();
        }
    }
}
