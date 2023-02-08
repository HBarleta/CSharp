Soda Coke = new Soda("Coke", true);

Console.WriteLine($"Name: {Coke.Name}");
Console.WriteLine($"Color: {Coke.Color}");
Console.WriteLine($"Temp: {Coke.Temperature}");
Console.WriteLine($"Carbonated? :{Coke.IsCarbonated}");
Console.WriteLine($"Diet? : {Coke.IsDiet}");
Console.WriteLine($"Calories: {Coke.Calories}");

Coffee Sbux = new Coffee("Sbux", "Light", "Whole");

Console.WriteLine($"Name: {Sbux.Name}");
Console.WriteLine($"Color: {Sbux.Color}");
Console.WriteLine($"Roast: {Sbux.Roast}");
Console.WriteLine($"Temp: {Sbux.Temperature}");
Console.WriteLine($"Carbonated? :{Sbux.IsCarbonated}");
Console.WriteLine($"Bean Type : {Sbux.BeanType}");
Console.WriteLine($"Calories: {Sbux.Calories}");

Wine Merlot = new Wine("Merlot", "France", 1776);

Console.WriteLine($"Name: {Merlot.Name}");
Console.WriteLine($"Color: {Merlot.Color}");
Console.WriteLine($"Year Bottled: {Merlot.YearBottled}");
Console.WriteLine($"Temp: {Merlot.Temperature}");
Console.WriteLine($"Carbonated? :{Merlot.IsCarbonated}");
Console.WriteLine($"Region : {Merlot.Region}");
Console.WriteLine($"Calories: {Merlot.Calories}");

List<Drink> DrinksList = new List<Drink>() { Sbux, Coke, Merlot };

foreach (Drink d in DrinksList)
{
    d.ShowDrink();
}