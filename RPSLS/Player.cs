using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string name;
        public int chosenAction;
        public List<string> actions;
        

        //constructor
        public Player()
        {
            actions = new List<string>();
            
            
            actions.Add("Rock");
            actions.Add("Paper");
            actions.Add("Scissors");
            actions.Add("Lizard");
            actions.Add("Spock");

        }
        //member methods
        public abstract void ChooseAction();

    }
}
