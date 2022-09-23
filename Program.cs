namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            //declare variables

            string playerOption = "none",
                   computerOption = "none",
                   win;
            int playerNum,
                compNum;

            //input rock paper or scissors

            Console.Write("Rock(1), Paper(2), or Scissors(3): ");
            playerNum = int.Parse(Console.ReadLine());

            switch (playerNum)
            {
                case 1:
                    playerOption = "Rock";
                    break;

                case 2:
                    playerOption = "Paper";
                    break;

                case 3:
                    playerOption = "Scissors";
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            //computer chooses rock paper or scissors
            if (playerNum == 1 || playerNum == 2 || playerNum == 3)
            {
                compNum = random.Next(1, 4);

                if (compNum == 1)
                {
                    computerOption = "Rock";
                }
                else if (compNum == 2)
                {
                    computerOption = "Paper";
                }
                else if (compNum == 3)
                {
                    computerOption = "Scissors";
                }

                //display who wins

                if (playerNum == compNum)
                {
                    win = "Tie";
                }
                else if (playerNum == 1 && compNum == 3)
                {
                    win = "true";
                }
                else if (playerNum == 2 && compNum == 1)
                {
                    win = "true";
                }
                else if (playerNum == 3 && compNum == 2)
                {
                    win = "true";
                }
                else
                {
                    win = "false";
                }

                Console.WriteLine($"You chose {playerOption}, the computer chose {computerOption}");
                Console.WriteLine($"Winner? {win}");
                Console.ReadLine();


            }
            else
            {
                Console.ReadLine ();    
            }
        }
    }
}