using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfMonster;

class Wizard
{
    public int Health { get; set; }
    public int Power { get; set; }
    public int Level { get; set; }
    public int SpellLevel { get; set; }

    public Wizard(int health, int power, int level, int spellLevel)
    {
        Health = health;
        Power = power;
        Level = level;
        SpellLevel = spellLevel;
    }

    public void Attack()
    {
        Console.WriteLine("Wizard is attacking...");
    }

    public void Spell()
    {
        Console.WriteLine("Wizard is spelling...");
    }
}
