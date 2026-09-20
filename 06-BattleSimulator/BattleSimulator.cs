void AfiseazaTitlu()
{
    Console.WriteLine("=== BATTLE SIMULATOR ===");
}
int playerHealth = 100;
int enemyHealth = 100;
Random damage = new();

AfiseazaTitlu();

while((playerHealth > 0) && (enemyHealth > 0))
{
    int playerDamage = damage.Next(10,26);
    int enemyDamage = damage.Next(10,26);
    playerHealth -=enemyDamage;
    Console.WriteLine($"Player Health: {playerHealth}");
    enemyHealth -=playerDamage;
    Console.WriteLine($"Enemy Health: {enemyHealth}");
}
