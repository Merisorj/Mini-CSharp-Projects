int[] enemyHP = { 80, 50, 100, 30 };

void AfiseazaInamici(int[] enemyHP)
{
    for (int n = 0; n < enemyHP.Length; n++)
    {

        Console.WriteLine($"Inamicul {n + 1} are {enemyHP[n]} HP");

    }
}

int AlegeInamic(int[] enemyHP)
{
    while (true)
    {

        string? text;
        int alegere;
        Console.WriteLine("Alege un inamic: ");
        text = Console.ReadLine();
        if (!int.TryParse(text, out alegere))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }
        else if (alegere < 1 || alegere > enemyHP.Length)
        {
            Console.WriteLine($"Alege un inamic intre 1 si {enemyHP.Length}.");
            continue;
        }
        int index;

        index = alegere - 1;
        return index;

    }
}
int CitesteDamage(int minim, int maxim, string mesaj)
{
    while (true)
    {
        string? text;
        int damage;
        Console.WriteLine(mesaj);
        text = Console.ReadLine();
        if (!int.TryParse(text, out damage))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }
        else if (damage < minim || damage > maxim)
        {
            Console.WriteLine("Alege un damage intre 1 si 50.");
            continue;
        }
        return damage;
    }

}
void CalculeazaDamage(int[]enemyHP, int index, int damage)
{
    enemyHP[index] -= damage;
    if (enemyHP[index] < 0)
    {
        Console.WriteLine("Prea mult damage.");
        enemyHP[index] = 0;
    }
    
}

AfiseazaInamici(enemyHP);
int index = AlegeInamic(enemyHP);
int damage = CitesteDamage(1, 50, "Alege damage-ul (1, 50): ");
CalculeazaDamage(enemyHP, index, damage);
AfiseazaInamici(enemyHP);


