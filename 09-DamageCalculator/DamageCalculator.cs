
int CitesteValoare(int minim, int maxim, string mesaj)
{
    while (true)
    {
        string? text;
        int numar;
        Console.Write(mesaj);
        text = Console.ReadLine();
        if (!int.TryParse(text, out numar))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }
        if (numar < minim || numar > maxim)
        {
            Console.WriteLine("Valoare invalida.");
            continue;
        }
        return numar;
    }
}

int CalculeazaDamage(int damageInitial, int bonusDamage)
{
    int damageTotal = damageInitial + bonusDamage;
    if(damageTotal > 60)
    {
        Console.WriteLine("Damage-ul nu poate depasi 60");
        damageTotal = 60;
    }
    return damageTotal;
}

void AfiseazaRezultat(int damageInitial, int bonusDamage, int damageTotal)
{
    Console.Write($"Damage initial: {damageInitial}\nBonus de damage: {bonusDamage}\nDamage total: {damageTotal}");
}

int damageInitial = CitesteValoare(1,50, "Introdu valoarea damage-ului initial(1,50): ");
int bonusDamage = CitesteValoare(0,20, "Introdu bonusul de damage (0,20): ");
int damageTotal = CalculeazaDamage(damageInitial, bonusDamage);
AfiseazaRezultat(damageInitial, bonusDamage, damageTotal);
