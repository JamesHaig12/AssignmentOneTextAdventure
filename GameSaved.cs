using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class GameSaved
    {
        public static void GameSavedScreen()
        {
            Console.Clear();
            Console.WriteLine("GAME SAVED");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
