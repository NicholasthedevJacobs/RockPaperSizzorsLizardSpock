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
        //***maybe add a variable for points***

        //constructor
        public AI()
        {
            rand = new Random();
            name = "HAL";
            //this.chosenAction = chosenAction;
        }
        //member methods
        public override void ChooseAction()
        {
            int chosenActionInt = rand.Next(actions.Count);
            chosenAction = actions[chosenActionInt];
        }
        public void SayName()
        {
            Console.WriteLine($"Hello, I'll be playing against you today.  My name is {name}.");
        }
    }
}
