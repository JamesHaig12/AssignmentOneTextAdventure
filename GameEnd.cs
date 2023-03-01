using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class GameEnd
    {
        public static void GameFinished()
        {
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            GameIntroScreen.timer.Stop();
            long timeDone = (GameIntroScreen.timer.ElapsedMilliseconds / 1000);
            Console.Clear();
            Console.WriteLine("\nCongratulations! You beat the pharoah and won!");
            Thread.Sleep(1000);
            Console.WriteLine("\nYou completed the game in {0} seconds", timeDone);
            Thread.Sleep(1000);
            Console.WriteLine("\nAdding your time to the leaderboard");

            FileStream f = new FileStream("E:\\Leaderboard.txt", FileMode.Append);
            //string fileName = gameIntroScreen.PlayerName + "_save.txt";
            using (StreamWriter writer = new StreamWriter(f))
            {
                // Write game state information to the file
                writer.WriteLine(GameIntroScreen.PlayerName + " " + timeDone);
                writer.Close();
                f.Close();
            }

            Console.WriteLine("Please wait...");
            Thread.Sleep(5000);
            Console.WriteLine("\nDone");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Exit");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
