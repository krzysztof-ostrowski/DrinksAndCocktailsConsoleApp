using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public class MainMenu
    {
        protected List<Drink> drinksMenu = new List<Drink>();
        protected List<Cocktail>cocktailsMenu = new List<Cocktail>();
            public void ShowMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome!\nWhat would you like to do?");
                Console.WriteLine("1. I want to see drinks recipes!");
                Console.WriteLine("2. I want to see cocktails recipes!");
                Console.WriteLine("3. I want to add a new drink!");
                Console.WriteLine("4. I want to add a new cocktail!");
                Console.WriteLine("5. I want to edit existing drink or cocktail!");
                Console.WriteLine("6. I want to delete existing drink or cocktail!");
                Console.WriteLine("7. NOTHING I JUST WANT TO LEAVE!");
            }
            public void ChooseMenuOption(int decision)
            {
                switch (decision)
                {
                    case 1:
                    Console.Clear();
                    GetDrinkFromConsole().ShowRecipe();
                    Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                    drinksMenu.Add(Factory.CreateDrink());
                        break;
                    case 4:
                    cocktailsMenu.Add(Factory.CreateCocktail());
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }
            }
            public int NavigateMenu()
            {
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int decision))
                    {
                        Console.WriteLine("You have to chose a number from 1 to 7!");
                    }
                    else if (decision < 0 || decision > 7)
                    {
                        Console.WriteLine("You have to chose a number from 1 to 7!");
                    }
                    else return decision;
                }

            }
        public void ShowDrinksInMenu()
        {
            foreach (var drink in drinksMenu)
            {
                int index = drinksMenu.IndexOf(drink);
                Console.WriteLine($"{index} {drink.Name}");
            }
        }
        public Drink GetDrinkFromConsole()
        {
            Console.Clear();
            ShowDrinksInMenu();
            while (true)
            {
                int chosenDrink = ChooseDrink();
                try
                {
                    return drinksMenu[chosenDrink];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Wrong Index");
                   
                }
            }
        }
        public int ChooseDrink()
        {
            {
                int choose;
                while (true)
                {

                    if (!int.TryParse(Console.ReadLine(), out choose))
                    {
                        Console.WriteLine("Proszę wybrać numer");
                    }
                    else break;
                }

                return choose;
            }
        }
    }
}
    
