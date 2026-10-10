using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfMonsterWithInheritance;

class Monster
{
    private int Health { get; set; }
    private int Power { get; set; }
    protected int Level { get; set; }

    public Monster(int health, int power, int level)
    {
        Health = health;
        Power = power;
        Level = level;
    }

    public virtual void Attack()
    {
        Console.WriteLine("Monster2 is attacking...");
    }

}
