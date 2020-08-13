﻿using System;
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
        public Game(Player player1, Player player2)
        {
            ChooseGameType();
            
        }
        //member methods
        public void ChooseGameType()
        {
            Console.WriteLine("Whould you like to play a solo game vs. A.I., or play against a friend?");
            Console.WriteLine("Choose '1' for solo game.  Choose '2' for friendly game: ");
            int gameTypeChoice = int.Parse(Console.ReadLine());
            if (gameTypeChoice == 1)
            {
                Console.WriteLine("Commencing solo game!  Cant wait to 𝚍̶𝚎̶𝚜̶𝚝̶𝚛̶𝚘̶𝚢̶  play against you!");
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
        public void InitiateGame (int choice)
        {

        }
    }
}
                
                



            
            
