using System;

Fighter hero = new Fighter();
hero.name = "Riddaren";
hero.weapon = new Weapon();
hero.weapon.name = "Boxar";

Fighter Villain = new Fighter();
hero.name = "Trollet";
hero.weapon = new Weapon();
hero.weapon.name = "Boxar";

Random generator = new Random();

while (hero.Health > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{hero.name}: {hero.Health}  {Villain.name}: {Villain.Health}\n");

  int heroDamage = generator.Next(30);
  Villain.Health -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

  Console.WriteLine("Tryck på vilken knapp du vill för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} vann!");
}
else
{
  Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("Tryck på vilken knapp du vill för att fortsätta.");
Console.ReadKey();
