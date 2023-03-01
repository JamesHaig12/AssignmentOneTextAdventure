using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomTwo
    {
        public static void TreasureRoom()
        {
            PlayerOne playerOne = new PlayerOne();
            Console.WriteLine("You enter the room to the right, your torch lighting the entire area");
            Random rnd = new Random();
            int chance = rnd.Next(1, 10);

            if(chance > 4)
            {
                Console.WriteLine("The light glints off some dust from the cieling, a shift in the tiles above, a quick breeze from above");

                bool continueGame = false;
                while(continueGame == false)
                {
                    Console.WriteLine("\nWhat do you do?");
                    string playerTrapChoice = Console.ReadLine().ToLower();

                    switch (playerTrapChoice)
                    {
                        case string a when a.Contains("duck"):
                            Console.WriteLine("\nJust in time you manage to crash to the floor as spikes shoot down from the cieling");
                            Thread.Sleep(1000);
                            Console.WriteLine("You look up to see them slowly retracting");
                            Thread.Sleep(1000);
                            Console.WriteLine("You got lucky this time.");
                            continueGame = true;
                            break;

                        case string b when b.Contains("forward") || b.Contains("back"):
                            Console.WriteLine("You manage to step {0} in time as the spikes shoot down from the cieling", b);
                            Thread.Sleep(1000);
                            Console.WriteLine("You look up to see them slowly retracting");
                            Thread.Sleep(1000);
                            Console.WriteLine("You got lucky this time.");
                            continueGame = true;
                            break;

                        case String c when c.Contains("hint"):
                            Console.WriteLine("Theres a trap above, how do you try to avoid it?");
                            break;

                        case string x when x.Contains("save"):
                            Console.WriteLine("Saving game");
                            PlayerOne.Location = 3;
                            SaveAndLoad.SaveGame();
                            break;

                        default:
                            GameIntroScreen gameIntroScreen = new GameIntroScreen();
                            Console.WriteLine("Spikes shoot down from the cieling, you try to evade them but you get struck on the way out");
                            Thread.Sleep(1000);
                            Console.WriteLine("-5 HP");
                            Thread.Sleep(1000);
                            playerOne.Health -= 5;
                            Console.WriteLine("{0} HP: {1}", GameIntroScreen.PlayerName, playerOne.Health);
                            continueGame = true;
                            break;
                    }
                }
                Console.WriteLine("\nAs the dust settles you examine your surroundings");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            GameArtworks gameArtworks = new GameArtworks();
            Console.Clear();
            Console.WriteLine("\nThe room is not too large, about 10 meters each way");
            Thread.Sleep(1000);
            Console.WriteLine("To the right of the doorway is a table, its chairs in disarray as though rushed out of");
            Thread.Sleep(1000);
            Console.WriteLine("In each corner is something different, to the left barrels, far right... crates");
            Thread.Sleep(1000);
            Console.WriteLine("And in the far left?... Nice");
            Thread.Sleep(1000);
            Console.WriteLine("You see something that would excite any adventurer..");
            Thread.Sleep(1000);
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(gameArtworks.ChestArt);
            Console.ForegroundColor = ConsoleColor.DarkRed;

            bool continueGame2 = false;
            int timesNo = 0;

            while (continueGame2 == false)
            {
                Console.WriteLine("\nSearch the chest?");
                string chestChoice = Console.ReadLine().ToLower();

                switch (chestChoice)
                {
                    case string a when a.Contains("yes"):
                        Random rnd2 = new Random();
                        int chance2 = rnd2.Next(1, 20);
                        if(chance2 > 0)
                        {
                            GameIntroScreen gameIntroScreen = new GameIntroScreen();
                            Console.WriteLine("As you approach, the chest rumbles for a second...");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nThe chest bursts open! Revealing shiny white teeth and a glistening purple tongue");
                            Thread.Sleep(1000);
                            Console.WriteLine("A Mimic!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            continueGame2 = true;
                            Mimic.MimicFight();
                        }
                        break;

                    case string b when b.Contains("no"):                       
                        timesNo++;
                        Console.WriteLine("But it's so shiny though");
                        if(timesNo > 1)
                        {
                            Console.WriteLine("Seriously, look at how shiny it is!");
                        }
                        else if(timesNo > 2)
                        {
                            Console.WriteLine("Just open the chest god damnit what kind of adventurer are you?");
                        }
                        break;

                    case string c when c.Contains("hint"):
                        Console.WriteLine("Yes or No");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 3;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("Is that a yes or a no?");
                        break;
                }
            }
        }
    }
}
