
// MeleeFighter Barbarian = new MeleeFighter("Conan");
// Console.WriteLine(Barbarian.Health);
// Console.WriteLine(JohnCena.Health);
// JohnCena.PerformAttack(Barbarian, JohnCena.AttackList[0]);
// Barbarian.Rage(JohnCena);
// Console.WriteLine(Barbarian.Health);

// Console.WriteLine(Oscar.Distance);
// Console.WriteLine(JohnCena.Health);
// Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
// Oscar.Dash();
// Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[1]);
// Console.WriteLine(Oscar.Distance);
MeleeFighter JohnCena = new MeleeFighter("John Cena");
RangedFighter Oscar = new RangedFighter("Oscar");
MagicCaster Jerry = new MagicCaster("Jerry");
JohnCena.PerformAttack(Oscar, JohnCena.AttackList[1]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.Dash();
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Jerry.Heal(Oscar);
Jerry.Heal(Jerry);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
Oscar.PerformAttack(JohnCena, Oscar.RangedAtkList[0]);
JohnCena.Rage(Jerry);



