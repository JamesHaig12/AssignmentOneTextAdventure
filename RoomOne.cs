using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomOne : Location
    {
        public static void EntrancePuzzle()
        {
            GameArtworks gameArtworks = new GameArtworks();
            PlayerOne playerOne = new PlayerOne();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("\nYou light up a torch, blazing fire lighting up the stones before you...");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(2000);
            Console.Write(gameArtworks.StonesArt);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nA large carving reveals itself in front of you, The mask of the Pharoah.");
            Thread.Sleep(1000);
            Console.WriteLine("Beneath it you spy some barely legible words...");
            Thread.Sleep(1000);
            Console.WriteLine("Walks on four in the morning... two in noon... three in the evening...");
            Thread.Sleep(1000);
            Console.WriteLine("'Appears to be a riddle of some kind' you think to yourself");

            bool continueGame = false;
            int timesHinted = 0;

            while (continueGame == false)
            {
                Console.WriteLine("\nWhat is the answer of the riddle?");
                string riddleAnswer = Console.ReadLine().ToLower();

                switch (riddleAnswer)
                {
                    case string a when a.Contains("man") || a.Contains("person") ||  a.Contains("human"):
                        Console.Clear();
                        Console.WriteLine("\n{0}! You exclaim loudly into the darkness.", riddleAnswer);
                        Thread.Sleep(1000);
                        Console.WriteLine("The eyes of the carving suddenly glow a brilliant red and you hear churning in the background");
                        Thread.Sleep(1000);
                        Console.WriteLine("Before your very eyes you see the solid wall slowly sink into the floor, revealing a pitch black hallway");
                        continueGame = true;
                        break;

                    case string b when b.Contains("hint"):                      
                        timesHinted ++;
                        Console.WriteLine("Think of the times of day more of the times of the answers lifetime.");
                        if(timesHinted > 2)
                        {
                            Console.WriteLine("Its something you see on a regular basis, if you went outside right now you would see many");
                        }
                        else if(timesHinted > 5)
                        {
                            Console.WriteLine("This is a very famous riddle, it was told by the original sphinx in egyptian folklore");
                        }
                        else if(timesHinted > 10)
                        {
                            Console.WriteLine("Really struggling with this one huh? The answer is a human.");
                        }
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 2;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("{0}! You exclaim, but nothing happened.", riddleAnswer);
                        continueGame = false;
                        break;
                }
            }
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(gameArtworks.CorridorArt);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Random rnd = new Random();
            int chance = rnd.Next(1, 10);

            if(chance > 4)
            {
                Console.WriteLine("As you step into the corridor, you hear a *cachunk* to your right");
                continueGame = false;

                while(continueGame == false)
                {
                    Console.WriteLine("What do you do?");
                    string playerTrapAnswer = Console.ReadLine().ToLower();

                    switch (playerTrapAnswer)
                    {
                        case string a when a.Contains("duck") || a.Contains("evade") || a.Contains("dodge") || a.Contains("move") || a.Contains("run"):
                            Console.WriteLine("\nYou manage to {0} out of the way in time as a large spear shoots to the other side of the hallway, sinking into the wall.", a);
                            continueGame = true;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case string b when b.Contains("hint"):
                            Console.WriteLine("Something is coming at you from the right.");
                            break;

                        case string x when x.Contains("save"):
                            Console.WriteLine("Saving game");
                            PlayerOne.Location = 2;
                            continueGame = true;
                            SaveAndLoad.SaveGame();
                            break;

                        default:
                            Console.WriteLine("\nYou were too slow, a spear shoots out the wall and catches your arm, leaving a deep gash.");
                            Thread.Sleep(1000);
                            Console.WriteLine("-5 HP");
                            GameIntroScreen gameIntroScreen = new GameIntroScreen();
                            playerOne.Health -= 5;
                            Console.WriteLine("{0} HP: {1}",GameIntroScreen.PlayerName, playerOne.Health);
                            continueGame = true;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You look up, your eyes adjusting to the dark, the light of your torch bouncing off the walls");
            Thread.Sleep(1000);
            Console.WriteLine("You see an entrance far down the corridor to the right and another door way at the very end of the corridor.");
            Thread.Sleep(1000);

            bool continueGame2 = false;

            while(continueGame2 == false)
            {
                Console.WriteLine("\nWhere would you like to go?");
                string playerMoveAnswer = Console.ReadLine().ToLower();

                switch (playerMoveAnswer)
                {
                    case string a when a.Contains("right"):
                        Console.Clear();
                        continueGame2 = true;
                        RoomTwo.TreasureRoom();
                        break;

                    case string b when b.Contains("end"):
                        Console.WriteLine("\nYou make your way to the end of the corridor towards the black space ahead");
                        Console.WriteLine("As you get close you find that there is a gate blocking your path with a shiny chrome lock");
                        continueGame = false;

                        while (continueGame == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nA key is needed to open this door");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nTry the other room?");
                            string goBackChoice = Console.ReadLine().ToLower();

                            switch (goBackChoice)
                            {
                                case string a when a.Contains("yes") || a.Contains("ok") || a.Contains("sure"):
                                    continueGame = true;
                                    Console.Clear();
                                    RoomTwo.TreasureRoom();
                                    break;

                                case string c when c.Contains("no"):
                                    break;

                                default:
                                    break;
                            }
                        }
                        continueGame2 = true;
                        break;

                    case string c when c.Contains("hint"):
                        Console.WriteLine("Choose to move to either the doorway at the end or the doorway on the right.");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 2;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("I should really choose which way to go");
                        break;
                }
            }
        }
    }
}
