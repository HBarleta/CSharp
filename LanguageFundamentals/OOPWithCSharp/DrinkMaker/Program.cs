Soda Coke = new Soda("Coke", true);


Coffee Sbux = new Coffee("Sbux", "Light", "Whole");



Wine Merlot = new Wine("Merlot", "France", 1776);



List<Drink> DrinksList = new List<Drink>() { Sbux, Coke, Merlot };

foreach (Drink d in DrinksList)
{
    d.ShowDrink();
}