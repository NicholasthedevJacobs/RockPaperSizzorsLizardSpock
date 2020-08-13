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

        //constructor
        public AI(string name, string chosenAction)
        {
            this.name = name;
            this.chosenAction = chosenAction;
        }
        //member methods
        public override void ChooseAction()
        {
           
        }
    }
}
