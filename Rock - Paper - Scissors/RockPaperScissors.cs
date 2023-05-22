using System;

namespace Rock___Paper___Scissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            Console.Write("Choose [r]ock, [p]aper pr [s]cissors: ");
            string playerMove = Console.ReadLine();
            if (playerMove == "r" || playerMove == "rock")
                playerMove = Rock;
            else if (playerMove == "p" || playerMove == "paper")
                playerMove = Paper;
            else if (playerMove == "s" || playerMove == "scissors")
                playerMove = Scissors;
            else
            {
                Console.WriteLine("Invalid input. Try again....");
                return;
            }
        }
    }
}
