
Attack FireBall = new Attack("Fireball", 20);
Attack SnowStorm = new Attack("Snow Storm", 15);
Attack ThrowBone = new Attack("Throw Bone", 10);


Enemy Skeleton = new Enemy("Skeleton");
Skeleton.AddAttack(ThrowBone);
Skeleton.AddAttack(FireBall);
Skeleton.AddAttack(SnowStorm);

foreach (Attack attk in Skeleton.AttackList)
{
    Console.WriteLine($"Attack on list : {attk.Name}");
}

Skeleton.RandomAttack();
Console.WriteLine(Skeleton.DisplayHealth);