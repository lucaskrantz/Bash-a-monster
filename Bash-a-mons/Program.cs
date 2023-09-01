using Namespace;


Gubbe g = new();
Enemy e = new();
Box b = new();

Random generator = new Random();
int r = generator.Next(3);


g.hp = 200;
g.attack = 20;
e.enemyHp = 100;
b.hp = 10;
b.heal = 40;

while (g.hp > 0)
{
    Console.WriteLine("Du möter en fiende i skogen.");
    Console.WriteLine("Tryck på 'a' för att attackera, och 'h' för att bli healad.");
    string action = Console.ReadLine().ToLower();
    if (action == "a")
    {
        e.enemyHp -= g.attack;
        Console.WriteLine($"You attacked! Enemy has {e.enemyHp}hp left. You have {g.hp}hp left!");
    }


    if (action == "h")
    {
        g.hp += b.heal;
        Console.WriteLine($"You healed! Enemy has {e.enemyHp}hp left. You have {g.hp}hp left!");
    }

    Console.WriteLine("Du blir attackerad tillbaka.");


    e.Attack(g);

    if (r == 3)
    {
        e.SpecialAttack(g, r);
    }

    Console.WriteLine($"Du har nu {g.hp} hp kvar!");


}


Console.ReadLine();