using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string nameAction;
        public string chosenAction;
        public List<Action> actions;
        //member variables

        //constructor
        public Player(Action action, string nameAction)
        {
            actions = new List<Action>();
            Action chooseRock = new Action(action);
            Action choosePaper = new Action(action);
            Action chooseScissors = new Action(action);
            Action chooseLizard = new Action(action);
            Action chooseSpock = new Action(action);
            actions.Add(chooseRock);
            actions.Add(choosePaper);
            actions.Add(chooseScissors);
            actions.Add(chooseLizard);
            actions.Add(chooseSpock);

        }
        //member methods
        public abstract void ChooseAction()

    }
}
