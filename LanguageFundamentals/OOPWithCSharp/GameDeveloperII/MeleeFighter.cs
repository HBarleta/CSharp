

public class MeleeFighter : Enemy
{
    Attack Punch = new Attack("Punch", 20);
    Attack Kick = new Attack("Kick", 15);
    Attack Tackle = new Attack("Tackle", 25);

    public MeleeFighter(string name) : base(name)
    {
        Name = name;
        Health = 120;
    }
}