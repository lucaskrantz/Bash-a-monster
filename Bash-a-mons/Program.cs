using Namespace;


Gubbe g = new();
Enemy e = new();
Box b = new();



g.hp = 200;
g.attack = 20;
e.hp = 100;
e.attack = 10;
b.hp = 10;
b.heal = 40;

while (g.hp > 0)
{
    Console.WriteLine("Du möter en fiende i skogen.");
    Console.WriteLine("Tryck på 'a' för att attackera, och 'h' för att bli healad.");
    string action = Console.ReadLine().ToLower();
    if (action == "a")
    {
        e.hp -= g.attack;
        Console.WriteLine($"You attacked! Enemy has {e.hp}hp left. You have {g.hp}hp left!");
    }

    if (action == "h")
    {
        g.hp += b.heal;
        Console.WriteLine($"You healed! Enemy has {e.hp}hp left. You have {g.hp}hp left!");
    }
}


Console.ReadLine();