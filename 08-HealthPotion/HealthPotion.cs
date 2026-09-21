
int CitesteHealth(int minim, int maxim, string mesaj)
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
            Console.WriteLine("Limita atinsa!");
            
            continue;
            
        }
        return numar;
    }

}

int CalculeazaHealth(int hpActual, int potiuneViata)
{
    hpActual += potiuneViata;
    if (hpActual > 100)
    {
        Console.WriteLine($"Hp depasit cu {hpActual - 100}");
        hpActual = 100;
    }

    return hpActual;
}

void AfiseazaRezultat(int hpInitial, int potiuneViata, int hpFinal)
{
    Console.WriteLine($"HP initial: {hpInitial}\nVindecare: {potiuneViata}\nHP final: {hpFinal}");
}

int hpInitial = CitesteHealth(0,100, "Introdu HP-ul actual (0-100): ");
int potiuneViata = CitesteHealth(1, 50, "Introdu puterea potiunii (1-50)");
int hpFinal = CalculeazaHealth(hpInitial,potiuneViata);
AfiseazaRezultat(hpInitial,potiuneViata,hpFinal);