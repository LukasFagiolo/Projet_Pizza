using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Pizza.Classe
{
    internal class PizzaPersonnalisée : Pizza

    {
        private List<string> ingredient;

        public PizzaPersonnalisée() : base("personnalisée", 5, false, null)
        {
            ingredient = new List<string>();

            while (true)
            {
                Console.Write("entrer un ingrédient a mettre sur votre pizza (Enter pour terminer) : ");
                var ingredients = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(ingredients))
                {
                    break;
                }
                ingredient.Add(ingredients);

            }
        }
            
        public override string ToString()
        {
            string txt = "";
            var ingredientToUp = ingredient.Select(i => FormatFirstLetterUppercase(i));
            txt += name;
            string badgeVeg = vegetarian ? " (V)" : ""; 
            txt += badgeVeg + " - " + price + "$\n";
            txt += string.Join(", ", ingredientToUp) + "\n";
            return txt;

        }

    }
}


        