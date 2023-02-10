

public class MeleeFighter : Enemy
{

    public List<Attack> MeleeAtkList = new List<Attack>()
    {
        new Attack("Tackle", 25),
        new Attack("Kick", 15),
        new Attack("Punch", 20)

    };
    public MeleeFighter(string name) : base(name)
    {
        Name = name;
        Health = 120;
        AttackList = MeleeAtkList;
    }

    public void Rage(Enemy Target)
    {
        if (this.Health <= 0)
        {
            Console.WriteLine($"{this.Name} has been defeated and cannot attack!");
        }
        else
        {

            Random randomAtk = new Random();
            int atkListCount = AttackList.Count;
            int idx = randomAtk.Next(0, atkListCount);
            Attack randomAttack = AttackList[idx];
            randomAttack.DamageAmount += 10;
            Console.WriteLine($"{this.Name} used RAGE!");
            this.PerformAttack(Target, randomAttack);
        }
    }
}