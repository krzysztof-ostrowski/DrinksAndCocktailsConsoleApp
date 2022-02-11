public class Drink : Beverage
{
    public override string Type => nameof(Drink);
    public Drink(string name) : base (name)
    {
        IsAlcoholic = true;
        Name = name;
        
    }
    public override void ShowRecipe()
    {
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"{ingredient.Ammount} {ingredient.AmmountType} {ingredient.Name}");
        }
        Console.WriteLine(Recipe);
    }
    
}
