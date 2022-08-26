using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args)
        {
            GameMenu gameMenu = new GameMenu();
            gameMenu.Greetings();
            gameMenu.Menu();

            GameLogic gameLogic = new GameLogic();
            gameLogic.Game();
        } 
    }
}
