public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }

    public List<Attack> AttackList { get; set; } = new List<Attack>();

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }
    public Attack RandomAttack()
    {
        Random randomA = new Random();
        // randomA creates a random class instance
        int atkListCount = AttackList.Count;
        // atkListCount will get boundry for AttackList
        int idx = randomA.Next(0, atkListCount);
        // creating a random index value to return a random attack from AttackList
        Console.WriteLine($"{this.Name} used {AttackList[idx].Name}! Causing {AttackList[idx].DamageAmount} damage!");
        // print to console to verify attack which attack was used an damage given
        return AttackList[idx];
    }
    public void AddAttack(Attack attack)
    {
        // method to add an attack to Enemy AttackList
        AttackList.Add(attack);
        Console.WriteLine($"{attack.Name} was added to attack list");
    }

    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {

        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");

    }
}