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
        public Human(string name, Action choice)
        {
            this.name = name;
        }
        //member methods
        public override void ChooseAction()
        {
           
        }
    }
}
