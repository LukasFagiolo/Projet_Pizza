/*
    - Class Pizza
    - nom (4 fromages)
    - prix : 11,5
    - vegetarienne (vrai ou faux)
    - constructeur
    - afficher
    - 4 framges (V) - 11,5$
    - créer une liste de pizzas
    - boucler pour afficher les pizzas.
*/

using ProjetPizza;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var listPizzas = new List<Pizza>() {
    new Pizza("4 fromages", 11.50f, true, new List<string> {"cantal", "mozzarella","gruyère","conté"}),
    new Pizza("Indienne", 10.5f, true, new List<string> {"curry","mozzarella","poulet","poivron","oignon","coriandre"}),
    new Pizza("Mexicaine", 13f, false, new List<string> {"boeuf","mozzarella","mais","tomates","oignon","coriandre"}),
    new Pizza("margherita", 8f, false, new List<string>{"sauce tomate","mozzarella","basilic"}),
    new Pizza("Calzone", 12f, false, new List<string>{"tomate","jambon","persil", "oignons"}),
    new Pizza("Complète", 9.50f, false,new List<string>{"jambon","oeuf","fromage"})
};

Pizza pizzaPriceMin = null;
Pizza pizzaPriceMax = null;

pizzaPriceMin = listPizzas[0];
pizzaPriceMax = listPizzas[0];

foreach(var onePizza in listPizzas)
{
    if (onePizza.price < pizzaPriceMin.price)
    {
        pizzaPriceMin = onePizza;
    }
    if (onePizza.price > pizzaPriceMax.price)
    {
        pizzaPriceMax = onePizza;
    }
}
//La pizza la moins cher est ?? et la pizza la plus cher est ??
Console.WriteLine($"La pizza la moins cher est: {pizzaPriceMin} \nLa pizza la plus cher est: {pizzaPriceMax}");
foreach (var onePizza in listPizzas)
{
    Console.WriteLine(onePizza);
}
