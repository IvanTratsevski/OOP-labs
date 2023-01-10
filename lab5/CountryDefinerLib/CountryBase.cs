using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDefinerLib
{
    internal class CountryBase
    {
        public static Dictionary<string, string> countries = new Dictionary<string, string>()
        {
            ["375"] = "Беларусь",
            ["355"] = "Албания",
            ["376"] = "Андорра",
            ["244"] = "Ангола",
            ["374"] = "Армения",
            ["880"] = "Бангладеш",
        };
        public static Dictionary<string,string> GetCountriesNumbers() {
            return countries;
        }
    }
}
