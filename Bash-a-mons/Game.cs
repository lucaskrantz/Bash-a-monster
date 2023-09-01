namespace Namespace;
public class Game
{
    public int heal = 40;


    public void Action(string action, Enemy e, Gubbe g)
    {
        if (action == "a")
        {
            e.enemyHp -= g.attack;
            Console.WriteLine($"You attacked! Enemy has {e.enemyHp}hp left. You have {g.hp}hp left!");
        }


        if (action == "h")
        {
            g.hp += heal;
            Console.WriteLine($"You healed! Enemy has {e.enemyHp}hp left. You have {g.hp}hp left!");
        }
    }
}
