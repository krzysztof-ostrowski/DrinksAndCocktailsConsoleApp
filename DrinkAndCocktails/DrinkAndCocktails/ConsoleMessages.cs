using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public static class ConsoleMessages
    {
        public static void ShowMainMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Welcome!\nWhat would you like to do?");
            Console.WriteLine("1. I want to see drinks recipes!");
            Console.WriteLine("2. I want to see cocktails recipes!");
            Console.WriteLine("3. I want to add a new drink!");
            Console.WriteLine("4. I want to add a new cocktail!");
            Console.WriteLine("5. I want to edit an existing drink or cocktail!");
            Console.WriteLine("6. I want to delete an existing drink or cocktail!");
            Console.WriteLine("7. NOTHING I JUST WANT TO LEAVE!");
        }
        public static void ChooseDrinkOrCocktailMessage(string beverage)
        {
            Console.Clear();
            Console.WriteLine($"Choose your {beverage} by entering its index");
        }
        public static void PressAnyKeyMessage()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public static void ChooseIngredientAmmountType()
        {
            Console.WriteLine("Chose ingredient ammount type:");
            Console.WriteLine("1.ml");
            Console.WriteLine("2.pieces");
            Console.WriteLine("3.whole");
            Console.WriteLine("4.teaspoons");
            Console.WriteLine("5.tablespoons");
        }
        public static void GetNameMessage(string drinkOrCocktail)
        {
            Console.WriteLine($"Enter {drinkOrCocktail} name");
        }
        public static void CorrectNumberMessage()
        {
            Console.WriteLine("Enter the correct number");
        }

    }
}
