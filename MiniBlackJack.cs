Random rand = new();

// 1. Tragi prima carte si a doua carte pentru jucator
int card1 = rand.Next(1, 12);
int card2 = rand.Next(1, 12);
int dealerCard1 = rand.Next(1,12);
int dealerCard2 = rand.Next(1,12);

int dealerScore = dealerCard1 + dealerCard2;
// 2. Calculezi scorul initial
int playerScore = card1 + card2;


Console.WriteLine($"You pulled {card1} and {card2}.");
Console.WriteLine($"Score: {playerScore}\n\n");

Console.WriteLine($"Dealer pulled {dealerCard1}");
Console.WriteLine($"Dealer score: {dealerScore}\n\n");

string? playerChoice = "";
if(playerScore == 21)
{
    Console.WriteLine("Congratulations! You've just hit a BlackJack!");
}

else
{
    do
    {
        Console.WriteLine("Hit or stand? (Hit/H or Stand/S)");
        playerChoice = Console.ReadLine()?.ToLower();
        
        if(playerChoice =="hit" || playerChoice =="h" && playerScore < 21)
        {
            int pulledCard = rand.Next(1,12);
            playerScore += pulledCard;
            Console.WriteLine($"\nYou pulled {pulledCard}. Current Score: {playerScore}\n");
            if (playerScore > 21)
            {
                Console.WriteLine($"That's a bust! You lose with {playerScore}");
                break;
            }

        }
    } while((playerChoice == "hit" || playerChoice == "h") && playerScore <21);
}


if (playerChoice == "stand" || playerChoice =="s" || playerScore == 21)
{
    
        Console.WriteLine($"Current Player Score: {playerScore}");
            while(dealerScore < 17)
            {
                int dealerCard = rand.Next(1,12);
                dealerScore +=dealerCard;
                Console.WriteLine($"Dealer pulls a card({dealerCard}). Dealer Score: {dealerScore}.");
            }    
            if(dealerScore > 21 || playerScore > dealerScore)
            {
                Console.WriteLine($"You WIN! Player: {playerScore} vs Dealer: {dealerScore}");
            }
            else if(dealerScore == playerScore)
            {
                Console.WriteLine($"It's a DRAW at {playerScore} points!");
            }
                
            
            if((dealerScore > playerScore) && (dealerScore ==21 || dealerScore <=21))
                {
                    Console.WriteLine($"Dealer Wins with Score {dealerScore}.");
                }
}

