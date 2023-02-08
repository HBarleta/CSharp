public class Attack
{
    // Properties for attack class
    public string Name { get; set; }
    public int DamageAmount { get; set; }

    // Attack class constructor
    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
    }
}