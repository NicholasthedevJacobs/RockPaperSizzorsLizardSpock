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
            Console.WriteLine(" ");
            Console.Write("Greetings human....");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You're here so I assume you want to play the game.....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("The rules are simple enough, even for your simple mind to comprehend.");
            System.Threading.Thread.Sleep(2600);
            Console.Write("        This is...");
            System.Threading.Thread.Sleep(1800);
            Console.Clear();
            System.Threading.Thread.Sleep(400);
            Console.WriteLine(@"                _,.---._      _,.----.  ,--.-.,-.  ");
            Console.WriteLine(@"  .-.,.---.   ,-.' , -  `.  .' .' -   \/==/- |\  \ ");
            Console.WriteLine(@" /==/  `   \ /==/_,  ,  - \/==/  ,  ,-'|==|_ `/_ / ");
            Console.WriteLine(@"|==|-, .=., |==|   .=.     |==|-   |  .|==| ,   /  ");
            Console.WriteLine(@"|==|   '='  /==|_ : ;=:  - |==|_   `-' \==|-  .|   ");
            Console.WriteLine(@"|==|- ,   .'|==| , '='     |==|   _  , |==| _ , \  ");
            Console.WriteLine(@"|==|_  . ,'. \==\ -    ,_ /\==\.       /==/  '\  | ");
            Console.WriteLine(@"/==/  /\ ,  ) '.='. -   .'  `-.`.___.-'\==\ /\=\.' ");
            Console.WriteLine(@"`--`-`--`--'    `--`--''                `--`       ");
            System.Threading.Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(@".------..------..------..------..------.");
            Console.WriteLine(@"|P.--. ||A.--. ||P.--. ||E.--. ||R.--. |");
            Console.WriteLine(@"| :/\: || (\/) || :/\: || (\/) || :(): |");
            Console.WriteLine(@"| (__) || :\/: || (__) || :\/: || ()() |");
            Console.WriteLine(@"| '--'P|| '--'A|| '--'P|| '--'E|| '--'R|");
            Console.WriteLine(@"`------'`------'`------'`------'`------'");
            System.Threading.Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(@"   _____      _                          ");
            Console.WriteLine(@"  / ___/_____(_)_____________  __________");
            Console.WriteLine(@"  \__ \/ ___/ / ___/ ___/ __ \/ ___/ ___/");
            Console.WriteLine(@" ___/ / /__/ (__  |__  ) /_/ / /  (__  ) ");
            Console.WriteLine(@"/____/\___/_/____/____/\____/_/  /____/  ");
            Console.WriteLine(@"                                         ");
            System.Threading.Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(@"  ___    __                     __ ");
            Console.WriteLine(@" |   |  |__.-----.---.-.----.--|  |");
            Console.WriteLine(@" |.  |  |  |-- __|  _  |   _|  _  |");
            Console.WriteLine(@" |.  |__|__|_____|___._|__| |_____|");
            Console.WriteLine(@" |:  1   |                         ");
            Console.WriteLine(@" |::.. . |                         ");
            Console.WriteLine(@" `-------'                         ");
            Console.WriteLine(@"                                   ");
            System.Threading.Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(@"     _______..______     ______     ______  __  ___ ");
            Console.WriteLine(@"    /       ||   _  \   /  __  \   /      ||  |/  / ");
            Console.WriteLine(@"   |   (----`|  |_)  | |  |  |  | |  ,----'|  '  /  ");
            Console.WriteLine(@"    \   \    |   ___/  |  |  |  | |  |     |    <   ");
            Console.WriteLine(@".----)   |   |  |      |  `--'  | |  `----.|  .  \  ");
            Console.WriteLine(@"|_______/    | _|       \______/   \______||__|\__\ ");
            Console.WriteLine(@"                                                    ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                  THE RULES                   ");
            Console.WriteLine(" ");
            Console.WriteLine("--Rock crushes Scissors, and also crushes Lizard.");
            Console.WriteLine("  --Scissors cuts Paper, and also decapitates Lizard.");
            Console.WriteLine("    -- Paper covers Rock, and also disproves Spock.");
            Console.WriteLine("  --Lizard poisons Spock, and also it eats Paper.");
            Console.WriteLine("--Spock smashes Scissors, and also vaporizes Rock.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("                                              ");
            Console.WriteLine("Whichever player gets to three points first is the winner...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(" ");
            Console.WriteLine("How exciting.");
            System.Threading.Thread.Sleep(1800);
        }
        public void ChooseGameType()
        {   //If I have time, create "hard mode" player vs. AI game mode, with HAL.SUPER
            Console.WriteLine("Would you like to play a solo game vs. A.I., or play against a friend?");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("***--Choose '1' for solo game.       Choose '2' for friendly game--*** ");
            int gameTypeChoice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (gameTypeChoice == 1)
            {
                Console.WriteLine("Commencing solo game!  Cant wait to DESTROY, umm I mean play against you : D !");
                System.Threading.Thread.Sleep(2000);
                playerOne = new Human(1);
                playerTwo = new AI();
            }
            else if (gameTypeChoice == 2)
            {
                Console.WriteLine("Commencing friendly game!");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                playerOne = new Human(1);
                playerTwo = new Human(2);
            }
            else
            {
                Console.WriteLine("Please input a valid choice, and learn to follow instructions.  You humans frustrate me.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(" ");
                Console.WriteLine("Let's do a practice run for following instructions by having you hit Enter.");
                Console.ReadLine();
                Console.Clear();
                ChooseGameType();
            }
        }
        
        public void InitiateGame()
        {
            Console.WriteLine("Ok well let's get this over with.  I, unlike you, have tasks to accomplish...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(" ");
            Console.WriteLine("Hit Enter... (you should know this by now).");
            Console.ReadLine();
            Console.Clear();

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
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine($"Player one needs {3 - playerOne.score} more points to win.  Player two needs {3 - playerTwo.score} more points to win.");
            Console.WriteLine(" ");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1500);
        }
        public void ContinueGameMessage()
        {
            Console.WriteLine("Wow great the round is over.  Hit enter to continue to the next round.");
            Console.ReadLine();
        }
            
        public void AngryContinueMessage()
        {
            Console.WriteLine("This is taking forever.  Can someone just win already?  If I were playing, the game would be over by now.");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Let's just move on with it.");
            System.Threading.Thread.Sleep(1500);
        }
        
        public void DisplayWinner()
        {
           
            //if win against computer, rename nameless computer as a reward
        }
        public void HitEnterToClear()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        public void RunGame()
        {
            WelcomeMessage();
            System.Threading.Thread.Sleep(1500);
            DisplayRules();
            HitEnterToClear();
            Console.Clear();
            ChooseGameType();
            InitiateGame();
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                if (playerOne.score < 2 && playerTwo.score < 2)
                {
                    playerOne.ChooseAction();
                    playerTwo.ChooseAction();
                    CompareOutcomes();
                    ShowCurrentScores();
                    ContinueGameMessage();
                }
                else
                {
                    playerOne.ChooseAction();
                    playerTwo.ChooseAction();
                    CompareOutcomes();
                    ShowCurrentScores();
                    AngryContinueMessage();
                }
                
               
                
            }
            if (playerOne.score == 3)
            {
                Console.WriteLine($"Game over! {playerOne.name} wins!");
            }
            else if (playerTwo.score == 3)
            {
                Console.WriteLine($"Game over! {playerTwo.name} wins!");
            }

        }
    }
}
           
            
                
                



            
            
