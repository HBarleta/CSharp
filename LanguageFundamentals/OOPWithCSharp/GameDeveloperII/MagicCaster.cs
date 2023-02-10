public class MagicCaster : Enemy
{
    public List<Attack> MagicAtkList = new List<Attack>()
    {
        new Attack("Fireball", 25),
        new Attack("Lightning Bolt", 25),
        new Attack("Staff Strike", 25)

    };
    public MagicCaster(string name) : base(name)
    {
        Name = name;
        Health = 80;
        AttackList = MagicAtkList;

    }
    public void Heal(Enemy Target)
    {
        if (Target is RangedFighter && Target.Health > 60)
        {
            Target.Health = 100;
            Console.WriteLine($"{this.Name} casts Heal on {Target.Name} recovering 40hp. {Target.Name} now has {Target.Health}HP");
        }
        else if (Target is MagicCaster && Target.Health > 40)
        {
            Target.Health = 80;
            Console.WriteLine($"{this.Name} casts Heal on {Target.Name} recovering 40hp. {Target.Name} now has {Target.Health}HP");
        }
        else if (Target is MeleeFighter && Target.Health > 80)
        {
            Target.Health = 120;
            Console.WriteLine($"{this.Name} casts Heal on {Target.Name} recovering 40hp. {Target.Name} now has {Target.Health}HP");
        }
        else
        {
            Target.Health += 40;
            Console.WriteLine($"{this.Name} casts Heal on {Target.Name} recovering 40hp. {Target.Name} now has {Target.Health}HP");

        }


    }

}