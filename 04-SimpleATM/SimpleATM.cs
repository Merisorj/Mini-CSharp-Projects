
decimal baniCard = 1000m;
string? text;
int input;
decimal retragere;
decimal depunere;
do
{

    Console.WriteLine("=== SIMPLE ATM ===");
    Console.Write("1. Vezi soldul\n2. Retrage bani\n3. Depune bani\n4. Iesire\nAlege o optiune:");
    text = Console.ReadLine();
    if (!int.TryParse(text, out input))
    {
        Console.WriteLine("Input invalid.");
        continue;
    }


    if (input == 1)
    {
        Console.WriteLine($"Sold curent: {baniCard} lei.");

    }

    else if (input == 2)
    {
        Console.WriteLine("Ce suma doresti sa retragi?");
        text = Console.ReadLine();
        if (!decimal.TryParse(text, out retragere))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }

        if (retragere <= 0)
        {
            Console.WriteLine("Suma invalida.");
        }
        else if (retragere > baniCard)
        {
            Console.WriteLine("Fonduri insuficiente!");
        }
        else
        {
            baniCard -= retragere;
            Console.WriteLine($"Sold nou: {baniCard}");

        }

    }
    else if (input == 3)
    {
        Console.WriteLine("Ce suma doresti sa depui?");
        text = Console.ReadLine();
        if (!decimal.TryParse(text, out depunere))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }

        if (depunere <= 0)
        {
            Console.WriteLine("Suma invalida.");
        }
        else
        {
            baniCard += depunere;
            Console.WriteLine($"Sold nou: {baniCard}");
        }

    }

    else if (input == 4)
    {
        Console.WriteLine("Va uram o zi frumoasa! Apasati orice tasta pentru a iesi din aplicatie!");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Optiune invalida.");

    }

} while (input != 4);



