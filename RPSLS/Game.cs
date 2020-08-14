using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        int endGameScore;

        //constructor
        public Game()
        {
            endGameScore = 3;
            
            
        }
        //member methods
        public void WelcomeMessage()             
        {
            Console.WriteLine(" -------------------------------------------------------------------------");
            Console.WriteLine(" -------------------------------------------------------------------------");
            Console.WriteLine(@" __      _____________.____   _________  ________      _____  ___________");
            Console.WriteLine(@"/  \    /  \_   _____/|    |  \_   ___ \ \_____  \    /     \ \_   _____/");
            Console.WriteLine(@"\   \/\/   /|    __)_ |    |  /    \  \/  /   |   \  /  \ /  \ |    __)_ ");
            Console.WriteLine(@" \        / |        \|    |__\     \____/    |    \/    Y    \|        \");
            Console.WriteLine(@"  \__/\  / /_______  /|_______ \______  /\_______  /\____|__  /_______  /");
            Console.WriteLine(@"       \/          \/         \/      \/         \/         \/        \/ ");
            Console.WriteLine(" -------------------------------------------------------------------------");
            Console.WriteLine(" -------------------------------------------------------------------------");
        }
        public void DisplayRules()
        {
            Console.Write("Greetings human....");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You're here so I assume you want to play the game.....");
            System.Threading.Thread.Sleep(1800);
            Console.WriteLine("The rules are simple enough, even for your simple mind to comprehend.");
            System.Threading.Thread.Sleep(1800);
            Console.Write("        This is Rock...");
            System.Threading.Thread.Sleep(800);
            Console.Write("Paper...");
            System.Threading.Thread.Sleep(800);
            Console.Write("Scissors...");
            System.Threading.Thread.Sleep(800);
            Console.Write("Lizard...");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("Spock...");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine(" ");
            Console.WriteLine("--Rock crushes Scissors, also crushes Lizard");
            Console.WriteLine("  --Scissors cuts Paper, and decapitates Lizard");
            Console.WriteLine("    -- Paper covers Rock, and disproves Spock");
            Console.WriteLine("  --Lizard poisons Spock, and it eats Paper");
            Console.WriteLine("--Spock smashes Scissors, and vaporizes Rock");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("                                              ");
            Console.WriteLine("Whichever player gets to three points first is the winner.");
        }
        public void ChooseGameType()
        {   //If I have time, create "hard mode" player vs. AI game mode, with HAL.SUPER
            Console.WriteLine("Would you like to play a solo game vs. A.I., or play against a friend?");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("***--Choose '1' for solo game.---*---Choose '2' for friendly game--*** ");
            int gameTypeChoice = int.Parse(Console.ReadLine());
            if (gameTypeChoice == 1)
            {
                Console.WriteLine("Commencing solo game!  Cant wait to d̶e̶s̶t̶r̶o̶y̶ play against you!");
                playerOne = new Human(1);
                playerTwo = new AI();
            }
            else if (gameTypeChoice == 2)
            {
                Console.WriteLine("Commencing friendly game!");
                playerOne = new Human(1);
                playerTwo = new Human(2);
            }
            else
            {
                Console.WriteLine("Please input a valid choice, and learn to follow instructions.  You humans frustrate me.");
                ChooseGameType();
            }
        }
        
        public void InitiateGame()
        {
            Console.WriteLine("Ok well let's get this over with.  I, unlike you, have tasks to accomplish...");
                
        }
       
        public void CompareOutcomes()
        {
            if (playerOne.chosenAction == "Rock" && (playerTwo.chosenAction == "Paper" || playerTwo.chosenAction == "Spock"))
            {
                playerTwo.score += 1;
            }
            else if (playerOne.chosenAction == "Paper" && (playerTwo.chosenAction == "Scissors" || playerTwo.chosenAction == "Lizard"))
            {
                playerTwo.score += 1;
            }
            else if (playerOne.chosenAction == "Scissors" && (playerTwo.chosenAction == "Spock" || playerTwo.chosenAction == "Rock"))
            {
                playerTwo.score += 1;
            }
            else if (playerOne.chosenAction == "Lizard" && (playerTwo.chosenAction == "Rock" || playerTwo.chosenAction == "Scissors"))
            {
                playerTwo.score += 1;
            }
            else if (playerOne.chosenAction == "Spock" && (playerTwo.chosenAction == "Lizard" || playerTwo.chosenAction == "Paper"))
            {
                playerTwo.score += 1;
            }
            else if (playerTwo.chosenAction == "Rock" && (playerOne.chosenAction == "Paper" || playerOne.chosenAction == "Spock"))
            {
                playerOne.score += 1;
            }
            else if (playerTwo.chosenAction == "Paper" && (playerOne.chosenAction == "Scissors" || playerOne.chosenAction == "Lizard"))
            {
                playerOne.score += 1;
            }
            else if (playerTwo.chosenAction == "Scissors" && (playerOne.chosenAction == "Spock" || playerOne.chosenAction == "Rock"))
            {
                playerOne.score += 1;
            }
            else if (playerTwo.chosenAction == "Lizard" && (playerOne.chosenAction == "Rock" || playerOne.chosenAction == "Scissors"))
            {
                playerOne.score += 1;
            }
            else if (playerTwo.chosenAction == "Spock" && (playerOne.chosenAction == "Lizard" || playerOne.chosenAction == "Paper"))
            {
                playerOne.score += 1;
            }
            else
            {
                CompareOutcomes();
            }
        }
        public void ShowCurrentScores()
        {
            Console.WriteLine($"Player ones score is now {playerOne.score}.  Player two's score is {playerTwo.score}.");
            Console.WriteLine($"Player one needs {3 - playerOne.score} more points to win.  Player two needs {3 - playerTwo.score} more points to win.");
        }
        public void ContinueGameMessage()
        {
            Console.WriteLine("Can someone just win already?  If I were playing the game would be over by now.");
        }
        public void DisplayWinner()
        {
           
            //if win against computer, rename nameless computer as a reward
        }
        public void RunGame()
        {
            WelcomeMessage();
            System.Threading.Thread.Sleep(1500);
            DisplayRules();
            ChooseGameType();
            InitiateGame();
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                
                playerOne.ChooseAction();
                playerTwo.ChooseAction();
                CompareOutcomes();
                ShowCurrentScores();
                ContinueGameMessage();
                
            }
            if (playerOne.score == 3 || playerTwo.score == 3)
            {
                Console.WriteLine("Game over!");
            }

        }
    }
}
           
            
                
                



            
            
