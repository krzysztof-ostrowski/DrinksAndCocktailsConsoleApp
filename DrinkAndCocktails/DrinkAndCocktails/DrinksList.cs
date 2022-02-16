using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public class DrinksList
    {
        private List<Drink> drinksMenu;
        public DrinksList()
        {
            drinksMenu = new List<Drink>();
        }
        public void AddDrink(Drink drink)
        {
            drinksMenu.Add(drink);
        }
        public void ShowDrinksInMenu()
        {
            foreach (var drink in drinksMenu)
            {
                int index = drinksMenu.IndexOf(drink);
                Console.WriteLine($"{index+1} {drink.Name}");
            }
        }
        public Drink GetFromConsole()
        {
            Console.Clear();
            ShowDrinksInMenu();
            while (true)
            {
                int chosenDrink = ChooseDrinkOrCocktail();
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
        public int ChooseDrinkOrCocktail()
        {
            {
                int choose;
                while (true)
                {

                    if (!int.TryParse(Console.ReadLine(), out choose))
                    {
                        Console.WriteLine("Please select a number");
                    }
                    else break;
                }

                return choose-1;
            }
        }
        public void EditDrink()
        {
            ShowDrinksInMenu();
            int choice;
            while (true)
            {
                choice = ChooseDrinkOrCocktail();
                try
                {
                    drinksMenu[choice] = Factory.CreateDrink();
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Wrong Index");

                }
            }
        }
        public void RemoveDrink()
        {
            ShowDrinksInMenu();
            int choice;
            while (true)
            {
                choice = ChooseDrinkOrCocktail();
                try
                {
                    drinksMenu.RemoveAt(choice);
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Wrong Index");

                }

            }
        }
    }
}
