using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;

        //constructor
        public Game()
        {
            
            ChooseGameType();
            
        }
        //member methods
        public void WelcomeMessage()             
        {
                   // Say hello.  Tell the rules.  Make fun of The Big Bang Theory.
        }
        public void ChooseGameType()
        {   //If I have time, create "hard mode" player vs. AI game mode, with HAL.SUPER
            Console.WriteLine("Whould you like to play a solo game vs. A.I., or play against a friend?");
            //System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Choose '1' for solo game.  Choose '2' for friendly game: ");
            int gameTypeChoice = int.Parse(Console.ReadLine());
            if (gameTypeChoice == 1)
            {
                Console.WriteLine("Commencing solo game!  Cant wait to d̶e̶s̶t̶r̶o̶y̶ play against you!");
                playerOne = new Human();
                playerTwo = new AI();
            }
            else if (gameTypeChoice == 2)
            {
                Console.WriteLine("Commencing friendly game!");
                playerOne = new Human();
                playerTwo = new Human();
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
        public void CompareThrows()
        {
            

        }
        public void CompareOutcomes()
        {
            if(playerOne.chosenAction == "Rock" && (playerTwo.chosenAction == "Paper" || playerTwo.chosenAction =="Spock"))
            {
                playerTwo.score += 1;
            }
            else if(playerOne.chosenAction == "Paper" && (playerTwo.chosenAction == "Scissors" || playerTwo.chosenAction == "Lizard"))
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
            
        }
        public void DisplayWinner()
        {
            //if win against computer, rename nameless computer as a reward
        }
        public void RunGame()
        {

        }
    }
}
           
            
                
                



            
            
