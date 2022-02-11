using DrinkAndCocktails;
MainMenu mainMenu = new MainMenu();
List<Drink> drinks = new List<Drink>();
List<Cocktail> cocktails = new List<Cocktail>();
while (true)
{
    mainMenu.ShowMenu();
    mainMenu.ChooseMenuOption(mainMenu.NavigateMenu());
}
