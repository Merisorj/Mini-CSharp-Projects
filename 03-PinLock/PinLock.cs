
int pinCorect = 2460;

Console.WriteLine("Trebuie sa gasesti PIN-ul in maxim 3 incercari!: ");
int incercari = 3;

while (incercari > 0)
{
    
    int input = int.Parse(Console.ReadLine());
    if (input == pinCorect)
        {
            Console.WriteLine("Felicitari! Ai gasit PIN-ul");
            break;
        }
    
    else
    {
        incercari--;
        if(incercari == 0)
        {
            Console.WriteLine("Card Blocat!");
            break;
        }
        Console.WriteLine($"PIN gresit! Mai ai {incercari} incercari!");
    }
}
Console.WriteLine("Apasa ENTER ca sa iesi");
Console.ReadLine();
Console.Clear();