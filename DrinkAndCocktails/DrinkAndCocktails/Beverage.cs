using DrinkAndCocktails;

public abstract class Beverage
{
    public abstract string Type { get; }
    public string Name { get; set; }
    public string Recipe { get; set; }
    public bool IsAlcoholic { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public Beverage(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
    }
    public abstract void ShowRecipe();
    
}
