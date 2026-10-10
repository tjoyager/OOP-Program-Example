// See https://aka.ms/new-console-template for more information

using WorldOfMonster;

Goblin goblin = new Goblin(100, 100, 1, 100);
goblin.Attack();
goblin.Steal();

Wizard budi = new Wizard(100, 100, 1, 100);
budi.Attack();
budi.Spell();

Orc orc = new Orc(100, 100, 1, 100);
orc.Attack();
orc.ClubAttack();