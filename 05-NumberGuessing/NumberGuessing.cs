Random random = new();
string? text;
int correctNumber = random.Next(1,101);
int input;

for (int attempts = 0; attempts < 5; attempts++)
{
    Console.WriteLine("Welcome! I am thinking of a number between 1 and 100. You have to guess it!");
    text = Console.ReadLine();
    if (!int.TryParse(text, out input))
    {
        Console.WriteLine("Input invalid. No attempts taken.");
        attempts--;
        continue;
    }

    if (input == correctNumber)
    {
        Console.WriteLine("You win!");
        break;

    }
    if (input < correctNumber)
    {
        Console.WriteLine($"Too low. Attempts: {attempts + 1}");

    }
    else if (input > correctNumber)
    {
        Console.WriteLine($"Too high. Attempts: {attempts + 1}");

    }

    if (attempts == 4)
    {

        Console.WriteLine("You lose! Press anything to exit.");
        Console.ReadKey();
    }


}
