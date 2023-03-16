
using System;

Console.WriteLine("Hi, would you like to play rock, paper and scissors? Y/N");

string response;
Boolean isPlaying;
isPlaying = true;
response = Console.ReadLine();

Console.WriteLine("Enter your move, rock, paper or scissors");

string playerMove = Console.ReadLine();

Random randomChoice = new Random();

int computerMove = randomChoice.Next(1, 4);

while(isPlaying)
{
    switch(computerMove)
    {
        case 1:
            Console.WriteLine("Computer played rock.");
            if (playerMove == "rock")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerMove == "paper")
            {
                Console.WriteLine("You win!");
            }
            else if (playerMove == "scissors")
            {
                Console.WriteLine("Computer wins!");
            }
            break;
        case 2:
            Console.WriteLine("Computer played paper.");
            if (playerMove == "rock")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (playerMove == "paper")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerMove == "scissors")
            {
                Console.WriteLine("You win!");
            }
            break;
        case 3:
            Console.WriteLine("Computer played scissors.");
            if (playerMove == "rock")
            {
                Console.WriteLine("You win!");
            }
            else if (playerMove == "paper")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (playerMove == "scissors")
            {
                Console.WriteLine("It's a tie!");
            }
            break;
        default:
            Console.WriteLine("Invalid move. Please try again.");
            break;
    }


    Console.WriteLine("Thanks for playing! would you like to play again? Y/N");


    string playAgainOrNot = Console.ReadLine();

    if(playAgainOrNot == "N" || playAgainOrNot == "n")
    {
       isPlaying = false; 
    }

}

Console.ReadLine();