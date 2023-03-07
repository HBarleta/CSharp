public class RangedFighter : Enemy
{
    public int Distance = 5;
    public List<Attack> RangedAtkList = new List<Attack>()
    {
        new Attack("Shoot an Arrow", 20),
        new Attack("Throw a Knife", 15),
    };
    public RangedFighter(string name) : base(name)
    {
        Name = name;
        AttackList = RangedAtkList;

    }
    public void Dash()
    {
        this.Distance = 20;
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (this.Distance < 20)
        {
            Console.WriteLine("Cannot perform ranged attack if distance is less than 20");
        }
        else
        {

            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name} attack, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }

    }
}