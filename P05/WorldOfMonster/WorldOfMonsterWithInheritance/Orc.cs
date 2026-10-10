namespace WorldOfMonsterWithInheritance;

class Orc : Monster
{
    public int ClubLevel { get; set; }

    public Orc(int health, int power, int level, int clubLevel) :
        base(health, power, level)
    {
        ClubLevel = clubLevel;
    }

    public void ClubAttack()
    {
        Console.WriteLine("Orc is attacking...");
    }
}
