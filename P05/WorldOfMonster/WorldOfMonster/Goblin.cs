using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfMonster;

class Goblin
{
    public int Health { get; set; }
    public int Power { get; set; }
    public int Level { get; set; }
    public int SpeedLevel { get; set; }

    public Goblin(int health, int power, int level, int speed)
    {
        Health = health;
        Power = power;
        Level = level;
        SpeedLevel = speed;
    }

    public void Attack()
    {
        Console.WriteLine("Goblin is attacking...");
    }

    public void Steal()
    {
        Console.WriteLine("Goblin is stealing...");
    }
}
