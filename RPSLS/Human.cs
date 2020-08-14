using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables
        int playerNumber;
        


        //constructor
        public Human(int playerNumber)
        {
            this.playerNumber = playerNumber;
            
            SetName(playerNumber);
            
        }
        //member methods
        public override void ChooseAction(string otherplayerGesture = null)
        {
            bool isValid = false;
            int gestureLocation = 0;
            Console.WriteLine($"Which action would you like to choose player {playerNumber}?");
            Console.WriteLine(" ");
            Console.WriteLine("Press '1' for Rock.");
            Console.WriteLine("Press '2' for Paper.");
            Console.WriteLine("Press '3' for Scissors.");
            Console.WriteLine("Press '4' for Lizard.");
            Console.WriteLine("Press '5' for Spock.");

            while(isValid != true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        gestureLocation = 0;
                        isValid = true;
                        break;
                    case "2":
                        gestureLocation = 1;
                        isValid = true;
                        break;
                    case "3":
                        gestureLocation = 2;
                        isValid = true;
                        break;
                    case "4":
                        gestureLocation = 3;
                        isValid = true;
                        break;
                    case "5":
                        gestureLocation = 4;
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("This is invalid");
                        break;
                }
            }

           
            Console.Clear();
           
            if (gestureLocation >= 0 && gestureLocation <= 4)
            {
                chosenAction = actions[gestureLocation];
                Console.WriteLine($"Ok you have chosen {chosenAction}.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hit enter.");
                Console.ReadLine();
                Console.Clear();
                
            }
            else
            {
                Console.WriteLine("Invalid Input.  Try again, and try harder this time.");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                ChooseAction();
            }
            

        }

        private void SetName(int playerNumber)
        {
            if (playerNumber == 1)
            {
                Console.WriteLine("Player one, tell me your name!");
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Good to meet you {name}, my name is HAL I hope this game makes your pitiful human experience more intersting.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(" ");
                Console.WriteLine("Hit Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("What are you waiting for player two?  Tell me your name.");
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Hello {name}. Good day to you.");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine(" ");
                Console.WriteLine("Hit Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
           
        }
    }
}
