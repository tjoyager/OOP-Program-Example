namespace WorldOfMonsterWithInheritance;

class Goblin : Monster
{
    public int SpeedLevel { get; set; }

    public Goblin(int health, int power, int level, int speed) :
        base(health, power, level)
    {
        SpeedLevel = speed;
    }

    public override void Attack()
    {
        Console.WriteLine("Goblin is attacking...");
    }

    public void Steal()
    {
        Console.WriteLine("Goblin is stealing...");
    }

    public void ShowLevel()
    {
        Console.WriteLine("Level: " + Level);
    }
}
