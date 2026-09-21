void AfiseazaTitlu()
{
    Console.WriteLine("=== BATTLE SIMULATOR ===");
}
void AfiseazaStatus(int playerHealth, int enemyHealth)
{

    Console.WriteLine($"Player Health: {playerHealth}");

    Console.WriteLine($"Enemy Health: {enemyHealth}");
}
int playerHealth = 100;
int enemyHealth = 100;

Random damage = new();

int GenereazaDamage()
{
    int generalDamage = damage.Next(10, 26);
    return generalDamage;
}
void AfiseazaRezultat(int playerHealth, int enemyHealth)
{
    if (playerHealth <= 0 && enemyHealth <= 0)
    {
        Console.WriteLine("Draw!");
    }

    else if (playerHealth <= 0)
    {
        Console.WriteLine("Enemy Wins!");

    }
    else if (enemyHealth <= 0)
    {
        Console.WriteLine("Player Wins!");

    }
}

AfiseazaTitlu();

while ((playerHealth > 0) && (enemyHealth > 0))
{
    int playerDamage = GenereazaDamage();
    int enemyDamage = GenereazaDamage();
    playerHealth -= enemyDamage;
    enemyHealth -= playerDamage;
    AfiseazaStatus(playerHealth, enemyHealth);

}
AfiseazaRezultat(playerHealth, enemyHealth);
