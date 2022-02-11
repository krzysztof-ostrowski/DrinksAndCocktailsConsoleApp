public class Cocktail : Beverage
{
    public override string Type => nameof(Cocktail);
    public Cocktail(string name) :base(name)
    {
        IsAlcoholic = false;
        Name=name;
        
    }
    public override void ShowRecipe()
    {
        foreach(var ingredient in Ingredients)
        {
            Console.WriteLine($"{ingredient.Ammount} {ingredient.AmmountType} {ingredient.Name}");
            
        }
        Console.WriteLine(Recipe);
    }
}