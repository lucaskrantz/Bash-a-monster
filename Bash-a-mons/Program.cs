using Namespace;


Gubbe g = new();
Enemy e = new();
Game game = new();

Random generator = new Random();
int r = generator.Next(2);


g.hp = 200;
g.attack = 20;
e.enemyHp = 100;


while (g.hp > 0)
{
    Console.WriteLine("Du möter en fiende i skogen.");
    Console.WriteLine("Tryck på 'a' för att attackera, och 'h' för att bli healad.");
    string action = Console.ReadLine().ToLower();

    game.Action(action, e, g);

    Console.WriteLine("Du blir attackerad tillbaka.");


    e.Attack(g);

    if (r == 1)
    {
        e.SpecialAttack(g, r);
    }

    Console.WriteLine($"Du har nu {g.hp} hp kvar!");


}


Console.ReadLine();