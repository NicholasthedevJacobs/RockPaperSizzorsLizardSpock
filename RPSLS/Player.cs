using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public List<Action> choice;
        //member variables

        //constructor
        public Player()
        {
            choice = new List<Action>();
            Action chooseRock = new Action();

        }
        //member methods
        public abstract void ChooseAction()

    }
}
