using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Pizza.Classe
{
    internal class Pizza
    {
        public string name { get; private set; }
        public float price { get; private set; }
        public bool vegetarian { get; private set; }
        List<string> ingredients { get; set; }
        public Pizza(string aName, float aPrice, bool isVeg, List<string> listIngredients)
        {
            name = aName;
            price = aPrice;
            vegetarian = isVeg;
            ingredients = listIngredients;
        }
        public override string ToString()
        {
            string txt = "";
            var ingredientToPrint = ingredients.Select(i => FormatFirstLetterUppercase(i));
            txt += FormatFirstLetterUppercase(name);
            string badgeVeg = vegetarian ? " (V)" : "";  //nouveau
            //if (vegetarian) { txt += "(V)"; }
            txt += badgeVeg + " - " + price + "$\n";
            txt += string.Join(", ", ingredientToPrint) + "\n"; //nouveau
            return txt;
        }
        public static string FormatFirstLetterUppercase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            string lowercase = s.ToLower();
            string uppercase = s.ToUpper();
            string result = uppercase[0] + lowercase[1..];
            return result;
        }
    }
}

