public class Coffee : Drink
{
    public string Roast;
    public string BeanType;

    public Coffee(string name, string roast, string beantype) : base(name, "black", 120.2, false, 250)
    {
        Name = name;
        Roast = roast;
        BeanType = beantype;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast: {this.Roast}");
        Console.WriteLine($"Bean Type: {this.BeanType}");
    }
}