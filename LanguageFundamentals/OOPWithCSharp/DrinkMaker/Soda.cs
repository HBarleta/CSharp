public class Soda : Drink
{
    public bool IsDiet;

    public Soda(string name, bool isDiet) : base(name, "Brown", 23.5, true, 500)
    {
        Name = name;
        IsDiet = isDiet;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet? : {this.IsDiet}");
    }
}