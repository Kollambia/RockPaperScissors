using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameLogic
    {
        public void Game()
        {
            string answer = Console.ReadLine().ToUpper().Trim();
            Console.Clear();

            Random random = new Random();
            int randomChoice = random.Next(1, 4);

            switch (randomChoice)
            {
                case 1:
                    Console.WriteLine("AI chooe the rock\n");
                    Console.WriteLine("[]");
                    if (answer == "R")
                    {
                        Console.WriteLine("[]");
                        Console.WriteLine("\nYou chose the rock\n");
                        Console.WriteLine("\nIt's a draw!\n");
                    }
                    else if (answer == "P")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("\nYou chose the paper\n");
                        Console.WriteLine("\nYou win!\n");
                    }
                    else if (answer == "S")
                    {
                        Console.WriteLine("%<");
                        Console.WriteLine("\nYou chose the scissors\n");
                        Console.WriteLine("\nYou lose\n");
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid value");
                        Game();
                    }
                break;
                case 2:
                    Console.WriteLine("AI choose the paper\n");
                    Console.WriteLine("---");
                    if (answer == "R")
                    {
                        Console.WriteLine("[]");
                        Console.WriteLine("\nYou chose the rock\n");
                        Console.WriteLine("\nYou lose\n");
                    }
                    else if (answer == "P")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("\nYou chose the paper\n");
                        Console.WriteLine("\nIt's  draw\n");
                    }
                    else if (answer == "S")
                    {
                        Console.WriteLine("%<");
                        Console.WriteLine("\nYou chose the scissors\n");
                        Console.WriteLine("\nYou win\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value");
                        Game();
                    }
                    break;
                case 3:
                    Console.WriteLine("AI chooe the scissors\n");
                    Console.WriteLine("%<");
                    if (answer == "R")
                    {
                        Console.WriteLine("[]");
                        Console.WriteLine("\nYou chose the rock\n");
                        Console.WriteLine("\nYou win\n");
                    }
                    else if (answer == "P")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("\nYou chose the paper\n");
                        Console.WriteLine("\nYou lose\n");
                    }
                    else if (answer == "S")
                    {
                        Console.WriteLine("%<");
                        Console.WriteLine("\nYou chose the scissors\n");
                        Console.WriteLine("\nit's a draw\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value");
                        Game();
                    }
                    break;
            }
            GameMenu.WannaPlayAgain();
        }
        
    }
}
