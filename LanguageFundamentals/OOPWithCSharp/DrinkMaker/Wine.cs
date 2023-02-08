public class Wine : Drink
{
    public string Region;
    public int YearBottled;

    public Wine(string name, string region, int yearbottled) : base(name, "red", 14.5, false, 100)
    {
        Name = name;
        Region = region;
        YearBottled = yearbottled;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {this.Region}");
        Console.WriteLine($"Year Bottled: {this.YearBottled}");
    }
}