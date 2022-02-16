using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public static class Factory
    {
        public static Drink CreateDrink()
        {
            ConsoleMessages.GetNameMessage("drink");
            Drink drink = new Drink(GetName());
            Console.WriteLine("How much ingredients does your drink require?");
            int numberOfIngredients = GetNumberOfIngredients();
            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.WriteLine($"Create your {i+1} ingredient");
                Ingredient ingredient = GetIngredient();
                drink.Ingredients.Add(ingredient);
            }
            Console.WriteLine("Write your drink recipe");
            drink.Recipe = GetRecipe();
            return drink;
        }
        public static Cocktail CreateCocktail()
        {
            ConsoleMessages.GetNameMessage("cocktail");
            Cocktail cocktail = new Cocktail(GetName());
            Console.WriteLine("How much ingredients does your cocktail require?");
            int numberOfIngredients = GetNumberOfIngredients();
            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.WriteLine($"Create your {i + 1} ingredient");
                Ingredient ingredient = GetIngredient();
                cocktail.Ingredients.Add(ingredient);
            }
            Console.WriteLine("Write your cocktail recipe");
            cocktail.Recipe = GetRecipe();
            return cocktail;
        }
        public static int GetNumberOfIngredients()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int ammount) || ammount < 0||ammount>10)
                {
                    ConsoleMessages.CorrectNumberMessage();
                }
                else return ammount;
            }
        }
        public static string GetName()
        {
           return Console.ReadLine();
        }
        public static Ingredient GetIngredient()
        {
            Console.WriteLine("Enter ingredient name");
            string ingredientName = GetName();
            IngredientType ingredientAmmountType = GetIngredientAmmountType();
            Ingredient ingredient = new Ingredient(ingredientName, ingredientAmmountType);
            Console.WriteLine($"Please enter the {ingredient.Name} ammount in {ingredient.AmmountType}:");
            ingredient.Ammount = GetIngredientAmmount();
            return ingredient;

        }
        public static IngredientType GetIngredientAmmountType()
        {
            ConsoleMessages.ChooseIngredientAmmountType();
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return IngredientType.ml;
                    case "2":
                        return IngredientType.pieces;
                    case "3":
                        return IngredientType.whole;
                    case "4":
                        return IngredientType.teaspoon;
                    case "5":
                        return IngredientType.tablespoon;
                    default:
                        ConsoleMessages.CorrectNumberMessage();
                        GetIngredientAmmountType();
                        break;
                }
            }
        }
        public static int GetIngredientAmmount()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int ammount) || ammount < 0)
                {
                    ConsoleMessages.CorrectNumberMessage();
                }
                else return ammount;
            }
        }
        public static string GetRecipe()
        {
            return Console.ReadLine();
        }

    }
}
