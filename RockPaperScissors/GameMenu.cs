using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameMenu
    {
        public void Greetings()
        {
            Console.WriteLine("Welcome to the rock, paper, scissors game!\n");
        }
        public void Menu()
        {
            Console.WriteLine("Please choose which figure you will walk!");
            Console.WriteLine("Enter 'R' to choose Rock.");
            Console.WriteLine("Enter 'P' to choose Papar.");
            Console.WriteLine("Enter 'S' to choose Scissors.\n");

        }
        public static void WannaPlayAgain()
        {
            Console.WriteLine("\nWould you like to play again? Type: Y/N\n");
            string answerToContinue = Console.ReadLine().ToUpper().Trim();

            if (answerToContinue == "Y")
            {
                Console.Clear();
                GameMenu gameMenu = new GameMenu();
                gameMenu.Menu();
                GameLogic gameLogic = new GameLogic();
                gameLogic.Game();
            }
            else if (answerToContinue == "N")
            {
                Console.Clear();
                EndGame();
            }
        }
        public static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Good game, see you later.");
            Environment.Exit(0);
        }

    }
}
