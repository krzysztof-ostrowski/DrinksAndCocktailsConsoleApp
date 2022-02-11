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
            Console.WriteLine("Enter drink name");
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
            Console.WriteLine("Enter cocktail name");
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
                    Console.WriteLine("Enter thecorrect number");
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
            string ingredientAmmountType = GetIngredientAmmountType();
            Ingredient ingredient = new Ingredient(ingredientName, ingredientAmmountType);
            Console.WriteLine($"Please enter the {ingredient.Name} ammount in {ingredient.AmmountType}:");
            ingredient.Ammount = GetIngredientAmmount();
            return ingredient;

        }
        public static string GetIngredientAmmountType()
        {
            Console.WriteLine("Chose ingredient ammount type:");
            Console.WriteLine("1.ml");
            Console.WriteLine("2.pieces");
            Console.WriteLine("3.teaspoons");
            Console.WriteLine("4.tablespoons");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return "ml";
                    case "2":
                        return "pieces";
                    case "3":
                        return "teaspoons";
                    case "4":
                        return "tablespoons";
                    default:
                        Console.WriteLine("Wrong number");
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
                    Console.WriteLine("Enter thecorrect number");
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
