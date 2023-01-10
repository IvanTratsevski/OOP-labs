using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace CountryDefinerLib
{
    public class Definer
    {
        string inputString;
        Dictionary<string, string> countries = CountryBase.GetCountriesNumbers();
        public Definer(string inputString)
        {
            this.inputString = inputString;
        }
        private string GetCountryCode(string number)
        {
            string code;
            if (number[0] == '+')
            {
                code = number.Substring(1, 3);
            } else
            {
                code = number.Substring(0, 3);
            }
            return code;
        }
        public StringBuilder defineCoutries()
        {
            string searchPhoneShort = @"\+?\d{3}[\s\(\-(\s\()]?\d{2,4}[\)\s\-(\)\s))]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}";
            StringBuilder definedPhones = new StringBuilder();
            MatchCollection matches = Regex.Matches(inputString, searchPhoneShort);
            foreach (Match match in matches)
            {
                string code = GetCountryCode(match.ToString());
                foreach (KeyValuePair<string, string> country in countries)
                    if (country.Key == code)
                        definedPhones.Append(country.Value + " " + match.Value + "\n");
            }
            return definedPhones;
        }
    }
}
