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
        public Human()
        {
            
            SetName();
            
        }
        //member methods
        public override void ChooseAction()
        {
           
        }

        private void SetName()
        {
            Console.WriteLine("Please tell me your name!");
            name = Console.ReadLine();
            Console.WriteLine($"Good to meet you {name}, my name is HAL I hope this game makes your pitiful human experience more intersting");
        }
    }
}
