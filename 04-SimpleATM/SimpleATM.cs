
decimal baniCard = 1000m;

int input;
do
{

Console.WriteLine("=== SIMPLE ATM ===");
Console.Write("1. Vezi soldul\n2. Retrage bani\n3. Depune bani\n4. Iesire\nAlege o optiune:");
    input = int.Parse(Console.ReadLine());
    if (input == 1)
    {
        Console.WriteLine($"Sold curent: {baniCard} lei.");
        
    }

    else if(input == 2)
    {
        Console.WriteLine("Ce suma doresti sa retragi?");
        decimal retragere = decimal.Parse(Console.ReadLine());
        if (retragere > baniCard)
        {
            Console.WriteLine("Fonduri insuficiente!");
            
        }
        else
        {
            baniCard -= retragere;
            Console.WriteLine($"Sold nou: {baniCard}");

        }
    }
    else if(input == 3)
    {
        Console.WriteLine("Ce suma doresti sa depui?");
        decimal depunere = decimal.Parse(Console.ReadLine());
        baniCard += depunere;

        Console.WriteLine($"Sold now: {baniCard}");
        
    }

    else if(input == 4)
    {
        Console.WriteLine("Va uram o zi frumoasa! Apasati orice tasta pentru a iesi din aplicatie!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Optiune invalida.");
        
    }
    
} while (input != 4);



