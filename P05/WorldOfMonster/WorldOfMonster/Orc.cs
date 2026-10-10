using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfMonster;

class Orc
{
    public int Health { get; set; }
    public int Power { get; set; }
    public int Level { get; set; }
    public int ClubLevel { get; set; }

    public Orc(int health, int power, int level, int clubLevel)
    {
        Health = health;
        Power = power;
        Level = level;
        ClubLevel = clubLevel;
    }

    public void Attack()
    {
        Console.WriteLine("Orc is attacking...");
    }

    public void ClubAttack()
    {
        Console.WriteLine("Orc is attacking...");
    }
}
