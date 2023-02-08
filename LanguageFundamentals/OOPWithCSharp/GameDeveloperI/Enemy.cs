public class Enemy
{
    public string Name { get; set; }
    private int Health { get; set; }
    public int DisplayHealth { get; }
    public List<Attack> AttackList { get; set; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        DisplayHealth = Health;
        AttackList = new List<Attack>();
    }
    public Attack RandomAttack()
    {
        Random randomA = new Random();
        int atkListCount = AttackList.Count + 1;
        int idx = randomA.Next(0, atkListCount);
        Console.WriteLine($"{this.Name} used {AttackList[idx].Name}! Causing {AttackList[idx].DamageAmount} damage!");
        return AttackList[idx];
    }
    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
        Console.WriteLine($"{attack.Name} was added to attack list");
    }
}