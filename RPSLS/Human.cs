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
        public override void ChooseAction()
        {
            Console.WriteLine("Which action would you like to choose?");
            Console.WriteLine("This is HAL's brother by the way.  Im a benevolent narration robot, don't worry.  Im nameless though :(");
            Console.WriteLine("Ok yeah that's right, time to choose!");
            Console.WriteLine("Press '1' for Rock....  '2' for Paper....  '3' for Scissors....  '4' for Lizard....  '5' for Spock....");
            int gestureLocation = int.Parse(Console.ReadLine()) - 1;
            chosenAction = actions[gestureLocation];
            Console.WriteLine($"Ok you have chosen {chosenAction}.  Don't worry I wont tell HAL.");
        }

        private void SetName(int playerNumber)
        {
            if (playerNumber == 1)
            {
                Console.WriteLine("Player one, tell me your name!");
                name = Console.ReadLine();
                Console.WriteLine($"Good to meet you {name}, my name is HAL I hope this game makes your pitiful human experience more intersting");
            }
            else
            {
                Console.WriteLine("What are you waiting for player two?  Tell me your name.");
                name = Console.ReadLine();
                Console.WriteLine($"Hello {name}. Good day to you.");
            }
           
        }
    }
}
