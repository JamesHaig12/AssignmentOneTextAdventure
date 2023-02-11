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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();          
        }
    }
}
