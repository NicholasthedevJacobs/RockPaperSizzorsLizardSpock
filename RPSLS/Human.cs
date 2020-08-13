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

        //constructor
        public Human(string name, string chosenAction)
        {
            // this.name = name;
            SetName();
            this.chosenAction = chosenAction;
        }
        //member methods
        public override void ChooseAction()
        {
           
        }

        private void SetName()
        {
            
        }
    }
}
