// Attack Punch = new Attack("Punch", 20);
// Attack Kick = new Attack("Kick", 15);
// Attack Tackle = new Attack("Tackle", 25);
// // adding all MeleeFighter attacks to this list
// List<Attack> MeleeAtkList = new List<Attack>() { Punch, Kick, Tackle };

// Attack ShootArrow = new Attack("Shoot an Arrow", 20);
// Attack ThrowKnife = new Attack("Throw a Knife", 25);
// // adding all RangedFighter attacks to this list
// List<Attack> RangedFighterAtkList = new List<Attack>() { ShootArrow, ThrowKnife, };

// Attack Fireball = new Attack("Fireball", 25);
// Attack LightningBolt = new Attack("Lightning Bolt", 25);
// Attack StaffStrike = new Attack("Staff Strike", 25);
// // adding all MagicCaster attacks to this list
// List<Attack> MagicCasterAtkList = new List<Attack>() { Fireball, LightningBolt, StaffStrike };

MeleeFighter Barbarian = new MeleeFighter("Conan");
MeleeFighter JohnCena = new MeleeFighter("John Cena");
Console.WriteLine(Barbarian.Health);
Console.WriteLine(JohnCena.Health);
JohnCena.PerformAttack(Barbarian, JohnCena.AttackList[0]);
Barbarian.Rage(JohnCena);
Console.WriteLine(Barbarian.Health);
Console.WriteLine(JohnCena.Health);




