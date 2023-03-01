using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class GameOver
    {
        public static void GameoverScreen()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER");
            Thread.Sleep(1000);
            Console.WriteLine("\nYou died, better luck next time");
            Thread.Sleep(1000);
            Console.WriteLine("Please be sure to come back and try again");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Exit");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
