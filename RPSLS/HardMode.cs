using System;
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
        }
    }
}
