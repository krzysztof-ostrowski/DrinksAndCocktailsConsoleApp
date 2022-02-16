using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public class CocktailsList
    {
        private List<Cocktail> cocktailsMenu;
        public CocktailsList()
        {
            cocktailsMenu = new List<Cocktail>();
        }
        public void AddCocktail(Cocktail cocktail)
        {
            cocktailsMenu.Add(cocktail);
        }
        public Cocktail GetFromConsole()
        {
            Console.Clear();
            ShowCocktailsInMenu();
            while (true)
            {
                int chosen = ChooseDrinkOrCocktail();
                try
                {
                    return cocktailsMenu[chosen];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Wrong Index");

                }
            }
        }
        
        public void EditCocktail()
        {
            ShowCocktailsInMenu();
            int choice;
            while (true)
            {
                choice = ChooseDrinkOrCocktail();
                try
                {
                    cocktailsMenu[choice] = Factory.CreateCocktail();
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Wrong Index");

                }
            }
        }
            public void ShowCocktailsInMenu()
            {
                foreach (var cocktail in cocktailsMenu)
                {
                    int index = cocktailsMenu.IndexOf(cocktail); ;
                    Console.WriteLine($"{index} {cocktail.Name}");
                }
            }
        public void RemoveCocktail()
        {
            ShowCocktailsInMenu();
            int choose;
            while (true)
            {
                choose = ChooseDrinkOrCocktail();
                try
                {
                    cocktailsMenu.RemoveAt(choose);
                    break;
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
                                Console.WriteLine("Proszę wybrać numer");
                            }
                            else break;
                        }

                        return choose;
                    }
                }
            } } 
