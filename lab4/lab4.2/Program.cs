using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DifChar();
            void DifChar()
            {
                Console.Write("Введите предложение: ");
                string lineToCheck = Console.ReadLine();
                lineToCheck = Regex.Replace(lineToCheck, @"\s+", "");
                var letters = lineToCheck.GroupBy(e => e);
                StringBuilder lettersInfo = new StringBuilder();
                foreach (var letter in letters)
                {
                    lettersInfo.AppendLine($"{letter.Key} = {letter.Count()}");
                }
                Console.WriteLine(lettersInfo);
            }

            Console.ReadLine();
        }
    }
}
