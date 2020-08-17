using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HardMode : Player
    {
        public HardMode()
        {
            name = "Hal.Super";
        }
      
        public override void ChooseAction(string otherplayerGesture = null)
        {
            if(otherplayerGesture == "Rock")
            {
                chosenAction = "Spock";
            }
            else if(otherplayerGesture == "Paper")
            {
                chosenAction = "Lizard";
            }
            else if(otherplayerGesture == "Scissors")
            {
                chosenAction = "Rock";
            }
            else if(otherplayerGesture == "Lizard")
            {
                chosenAction = "Scissors";
            }
            else if(otherplayerGesture == "Spock")
            {
                chosenAction = "Paper";
            }
            Console.WriteLine($"I chose {chosenAction}.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Please hit enter for me.  I don't have buttons to push.");
            Console.ReadLine();
            Console.Clear();


        }
        public void SayName()
        {
            Console.WriteLine($"I am {name}.  Your efforts will be futile.  Prepare to be annihilated.");
        }
    }
}
