namespace Namespace;
public class Enemy
{
    public float enemyHp;
    public int dmg = 20;



    public void Attack(Gubbe g)
    {
        g.hp -= dmg;
    }

    public void SpecialAttack(Gubbe g, int random)
    {
        g.hp -= dmg * random;
    }
}
