using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player test = new Human("Mike", "");



            Game game = new Game();
            game.InitiateGame();

            Console.ReadLine();
        }
    }
}
