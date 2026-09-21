using System.Text.Json.Serialization;

void AfiseazaTitlu()
{
    Console.WriteLine("=== CHARACTER CREATOR ===");
}


int CitesteNivelul()
{
    string? text;
    int nivel;
    while (true)
    {
        text = Console.ReadLine();
        if (!int.TryParse(text, out nivel))
        {
            Console.WriteLine("Optiune Invalida.");
            continue;

        }
        if (nivel < 1 || nivel > 10)
        {
            Console.WriteLine("Nivel invalid.");
            continue;
        }
        return nivel;
    }


}

void AfiseazaPersonaj(string nume, int nivel)
{

    Console.WriteLine($"Nume: {nume}\nNivel: {nivel}");
}

AfiseazaTitlu();
Console.Write("Introdu numele personajului: ");
string? nume =  Console.ReadLine();
Console.Write("Introdu nivelul: ");
int nivel = CitesteNivelul();
AfiseazaPersonaj(nume, nivel);