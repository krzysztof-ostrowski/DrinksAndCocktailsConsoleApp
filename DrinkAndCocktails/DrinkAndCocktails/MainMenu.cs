using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public class MainMenu
    {
        DrinksList drinksMenu = new DrinksList();
        CocktailsList cocktailsMenu = new CocktailsList();

        public void ShowMenu()
        {
            ConsoleMessages.ShowMainMenuOptions();
        }
        public void ChooseMenuOption(int decision)
        {
            switch (decision)
            {
                case 1:
                    ConsoleMessages.ChooseDrinkOrCocktailMessage("drink");
                    drinksMenu.GetFromConsole().ShowRecipe();
                    ConsoleMessages.PressAnyKeyMessage();
                    break;
                case 2:
                    ConsoleMessages.ChooseDrinkOrCocktailMessage("cocktail");
                    cocktailsMenu.GetFromConsole().ShowRecipe();
                    ConsoleMessages.PressAnyKeyMessage();
                    break;
                case 3:
                    drinksMenu.AddDrink(Factory.CreateDrink());
                    break;
                case 4:
                    cocktailsMenu.AddCocktail(Factory.CreateCocktail());
                    break;
                case 5:
                    switch (NavigateDrinksOrCocktails())
                    {
                        case 1:
                            drinksMenu.EditDrink();
                            break;
                        case 2:
                            cocktailsMenu.EditCocktail();
                            break;
                    }
                    ConsoleMessages.PressAnyKeyMessage();
                    break;
                case 6:
                    switch (NavigateDrinksOrCocktails())
                    {
                        case 1:
                            ConsoleMessages.ChooseDrinkOrCocktailMessage("drink");
                            drinksMenu.RemoveDrink();
                            break;
                        case 2:
                            ConsoleMessages.ChooseDrinkOrCocktailMessage("cocktail");
                            cocktailsMenu.RemoveCocktail();
                            break;
                    }
                    ConsoleMessages.PressAnyKeyMessage();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
        }
        public int NavigateDrinksOrCocktails()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int decision))
                {
                    Console.WriteLine("You have to chose a number from 1 to 2!");
                }
                else if (decision < 1 && decision > 2)
                {
                    Console.WriteLine("You have to chose a number from 1 to 2!");
                }
                else return decision;
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
                else if (decision < 1 && decision > 8)
                {
                    Console.WriteLine("You have to chose a number from 1 to 7!");
                }
                else return decision;
            }

        }

    }
}
    

    
