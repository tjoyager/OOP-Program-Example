namespace WorldOfMonsterWithInheritance;

class Wizard : Monster
{
    public int SpellLevel { get; set; }

    public Wizard(int health, int power, int level, int spellLevel) :
        base(health, power, level)
    {
        SpellLevel = spellLevel;
    }

    public void Spell()
    {
        Console.WriteLine("Wizard is spelling...");
    }
}
