int[] playerScores = [120, 75, 200, 50, 160];

void ShowScores(int[] playerScores)
{
    for (int n = 0; n < playerScores.Length; n++)
    {
        Console.WriteLine($"Player {n + 1}: {playerScores[n]}");
    }
}
int PlayerChoice(int[] playerScores)
{
    while (true)
    {

        string? text;
        int choice;
        Console.WriteLine("Alege un jucator: ");
        text = Console.ReadLine();
        if (!int.TryParse(text, out choice))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }
        else if (choice < 1 || choice > playerScores.Length)
        {
            Console.WriteLine($"Alege un jucator intre 1 si {playerScores.Length}.");
            continue;
        }
        int index;

        index = choice - 1;
        return index;

    }
}
int BonusChoice(int minim, int maxim, string mesaj)
{
    while (true)
    {
        string? text;
        int bonus;
        Console.WriteLine(mesaj);
        text = Console.ReadLine();
        if (!int.TryParse(text, out bonus))
        {
            Console.WriteLine("Input invalid.");
            continue;
        }
        else if (bonus < minim || bonus > maxim)
        {
            Console.WriteLine("Alege un bonus intre 10 si 50.");
            continue;
        }
        return bonus;
    }

}
void BonusSum(int[] playerScores, int index, int bonus)
{
    playerScores[index] += bonus;
    

}

int MaxScore(int[] playerScores)
{
    int maxScore = playerScores[0];
    for (int m = 0; m < playerScores.Length; m++)
    {
        if (maxScore < playerScores[m])
        {
            maxScore = playerScores[m];
        }
    }
    return maxScore;
}
ShowScores(playerScores);
int index = PlayerChoice(playerScores);
int bonus = BonusChoice(10, 50, "Alege un bonus(10-50): ");
BonusSum(playerScores, index, bonus);
int maxScore = MaxScore(playerScores);
ShowScores(playerScores);
Console.WriteLine($"Max score: {maxScore}");