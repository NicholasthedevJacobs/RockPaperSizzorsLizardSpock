﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HardMode : Player
    {
      
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
                chosenAction = " Scissors";
            }
            else if(otherplayerGesture == "Spock")
            {
                chosenAction = "Paper";
            }
        }
    }
}
