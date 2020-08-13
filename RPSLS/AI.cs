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
            //this.chosenAction = chosenAction;
        }
        //member methods
        public override void ChooseAction()
        {
            chosenAction = rand.Next(actions.Count);
        }
    }
}
