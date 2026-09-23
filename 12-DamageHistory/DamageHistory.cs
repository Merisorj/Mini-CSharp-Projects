int[] damageHistory = [5, 10, 19];

void ShowDamageHistory(int[] damageHistory)
{

    for (int i = 0; i < damageHistory.Length; i++)
    {
        Console.WriteLine($"Lovitura {i + 1}: {damageHistory[i]} damage.");
    }
}
int CalculateTotalDamage()
{
    int totalDamage = 0;
    foreach (int damage in damageHistory)
    {
        totalDamage += damage;

    }
    return totalDamage;
}
int CountHighDamageHits()
{
    int hitCount = 0;
    foreach (int damage in damageHistory)
    {
        if (damage >= 20)
        {
            hitCount++;
        }
    }
    return hitCount;

}
ShowDamageHistory(damageHistory);
int totalDamage = CalculateTotalDamage();
int highDamage = CountHighDamageHits();
Console.WriteLine($"Total damage: {totalDamage}\nHits with minimum 20 damage: {highDamage}");