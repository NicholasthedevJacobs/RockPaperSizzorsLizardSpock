using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player 
    {
        //member variables
        Random rand;
        

        //constructor
        public AI()
        {
            rand = new Random();
            name = "HAL";
            
        }
        //member methods
        public override void ChooseAction(string otherplayerGesture = null)
        {
            int chosenActionInt = rand.Next(actions.Count);
            chosenAction = actions[chosenActionInt];
            //CHECK HERE DAWG Finish the computers choice message if need be
            Console.WriteLine($"I chose {chosenAction}.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Please hit enter for me.  I don't have buttons to push.");
            Console.ReadLine();
        }
        public void SayName()
        {
            Console.WriteLine($"Hello, I'll be playing against you today.  My name is {name}.");
        }
    }
}
