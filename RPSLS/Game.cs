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

        //constructor
        public Game()
        {

        }
        //member methods
        public int ChooseGameType()
        {
            Console.WriteLine("Whould you like to play a solo game vs. A.I., or play against a friend?");
            Console.WriteLine("Choose '1' for solo game.  Choose '2' for friendly game: ");
            int gameTypeChoice = int.Parse(Console.ReadLine());
            if (gameTypeChoice == 1)
            {
                Console.WriteLine("Commencing solo game!");
            }
            else if (gameTypeChoice == 2)
            {
                Console.WriteLine("Commencing friendly game!");
            }
            else
            {
                Console.WriteLine("Please input a valid choice, and learn to follow instructions.");
                ChooseGameType();
            }
            
            
            return gameTypeChoice;
            
        }
    }
}
