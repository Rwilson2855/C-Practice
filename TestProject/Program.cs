/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroDamageDealt = random.Next (1, 11);
    int monsterDamageDealt = random.Next (1, 11);
    

    monsterHealth -= heroDamageDealt;
    Console.WriteLine($"Monster  takes {heroDamageDealt} and has {monsterHealth}");
    if (monsterHealth <= 0) continue;
    heroHealth -= monsterDamageDealt;
    Console.WriteLine($"Hero takes {monsterDamageDealt} and has {heroHealth}");
    
} while (monsterHealth > 0 && heroHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");