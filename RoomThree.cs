﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomThree
    {
        public static void WeaponRoom()
        {
            PlayerOne playerOne = new PlayerOne();
            Console.Clear();
            Console.WriteLine("'Ah finally! The Key!'");
            Console.WriteLine("You take a last scan of the room, noticing some more carvings on the wall but not much more of interest");

            bool continueGame = false;

            while(continueGame == false)
            {
                Console.WriteLine("\nWould you like to go back to the gate?");
                string playerMovement = Console.ReadLine().ToLower();

                switch (playerMovement)
                {
                    case string a when a.Contains("yes") || a.Contains("sure") || a.Contains("ok"):
                        Console.WriteLine("\nYou head back to the gate, key in hand.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You insert the key into the lock and turn.");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(3000);
                        Console.WriteLine("*click*");
                        Thread.Sleep(1000);
                        Console.WriteLine("It Unlocked!");
                        WeaponRoomPuzzle();
                        continueGame = true;
                        break;

                    case string b when b.Contains("no"):
                        Console.WriteLine("\nYou make your way out of the room and back to the entrance of the pyramid, key in hand");
                        Thread.Sleep(1000);
                        Console.WriteLine("I cant go back now, Surely.");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 4;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("Not sure i can do that right now");
                        break;
                }
            }
        }

        public static void WeaponRoomPuzzle()
        {
            GameArtworks gameArtworks = new GameArtworks();
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pushing the gate aside your eyes need a moment to adjust once again");
            Thread.Sleep(1000);
            Console.WriteLine("Before you on the floor is a massive compass...");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(gameArtworks.CompassFloor);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nAt the end of each compass point is a pillar, each with a unique carving of an animal on it");
            Thread.Sleep(1000);
            Console.WriteLine("In the middle of the compass you see a plinth");
            Thread.Sleep(1000);
            if (GameIntroScreen.PlayerClass == 1)
            {
                Console.WriteLine("Upon the plinth you see an almighty staff, carved from what seems to be old mahogany wood");
                WeaponPuzzle();
            }
            else if(GameIntroScreen.PlayerClass == 2)
            {
                Console.WriteLine("Upon the plinth you see an almighty great axe, its shiny blade glinting in the light");
                WeaponPuzzle();
            }
            else if(GameIntroScreen.PlayerClass == 3)
            {
                Console.WriteLine("Upon the plinth you see finely crafted daggers, their shiny blades glinting in the light");
                WeaponPuzzle();
            }
        }

        public static void WeaponPuzzle()
        {
            PlayerOne playerOne = new PlayerOne();
            Thread.Sleep(1000);
            Console.WriteLine("\nAround the plinth is a metal cage, you cannot fit your hand through the bars");
            Thread.Sleep(1000);
            Console.WriteLine("There is a plaque attached to the plinth");
            Thread.Sleep(1000);
            Console.WriteLine("\nThe plaque reads: The Grizzly Apex Predator, The Bird Of Freedom, The School Of The Sea");
            Thread.Sleep(1000);
            Console.WriteLine("There is a button on the plinth that can be pressed");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nFigure out the compass points the riddle aludes to");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            bool continueGame = false;

            while (continueGame == false)
            {
                Console.WriteLine("\nEnter a compass point to examine or type submit to take a guess");
                string playerChoice = Console.ReadLine().ToLower();

                switch (playerChoice)
                {
                    case string a when a.Contains("north") && (!a.Contains("east") && (!a.Contains("west") && (!a.Contains("south")))):
                        Console.WriteLine("Bear");                       
                        break;

                    case string b when b.Contains("north") && b.Contains("east") && (!b.Contains("west") && (!b.Contains("south"))):
                        Console.WriteLine("Goat");
                        break;

                    case string c when c.Contains("east") && (!c.Contains("north") && (!c.Contains("south") && (!c.Contains("west")))):
                        Console.WriteLine("Eagle");
                        break;

                    case string d when d.Contains("south") && d.Contains("east") && (!d.Contains("west") && (!d.Contains("north"))):
                        Console.WriteLine("Camel");
                        break;

                    case string e when e.Contains("south") && (!e.Contains("east") && (!e.Contains("west") && (!e.Contains("north")))):
                        Console.WriteLine("Octopus");
                        break;

                    case string f when f.Contains("south") && f.Contains("west") && (!f.Contains("north") && (!f.Contains("east"))):
                        Console.WriteLine("Fish");
                        break;

                    case string g when g.Contains("west") && (!g.Contains("east") && (!g.Contains("north") && (!g.Contains("south")))):
                        Console.WriteLine("Scorpion");
                        break;

                    case string h when h.Contains("north") && h.Contains("west") && (!h.Contains("east") && (!h.Contains("south"))):
                        Console.WriteLine("Snake");
                        break;

                    case string i when i.Contains("submit"):
                        bool continueGame2 = false;

                        while(continueGame2 == false)
                        {
                            Console.WriteLine("\nWhat is your final guess of compass points?");
                            string playerGuess = Console.ReadLine().ToLower();

                            switch (playerGuess)
                            {
                                case string k when k.Contains("north") && k.Contains("east") && k.Contains("southwest"):
                                    Console.Clear();
                                    Console.WriteLine("North, East, Southwest you say, and press the button.");
                                    PuzzleWinner();
                                    continueGame2 = true;
                                    break;

                                default:
                                    Console.WriteLine("You press the button to lock in your answer");
                                    PuzzleLoser();
                                    continueGame2 = true;
                                    break;
                            }
                        }
                        continueGame = true;
                        break;

                    case string j when j.Contains("hint"):
                        Console.WriteLine("\nThe compass points to eight different carvings on the wall. " +
                            "\nFigure out what the riddle on the plaque means, then submit the corresponding compass points");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 4;
                        SaveAndLoad.SaveGame();
                        break;
                }
            }
        }

        public static void PuzzleWinner()
        {
            PlayerOne playerOne = new PlayerOne();
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            int newWeapon = 1;
            playerOne.DamageBuff += 5;
            
            Console.WriteLine("\nYou hear a click, then another and another and another");
            Thread.Sleep(1000);

            if (GameIntroScreen.PlayerClass == 1)
            {
                Console.WriteLine("You watch as the metal cage surrounding the staff lifts away, allowing you to grab it");
            }
            else if (GameIntroScreen.PlayerClass == 2)
            {
                Console.WriteLine("You watch as the metal cage surrounding the axe lifts away, allowing you to grab it");
            }
            else if (GameIntroScreen.PlayerClass == 3)
            {
                Console.WriteLine("You watch as the metal cage surrounding the daggers lifts away, allowing you to grab them");
            }

            Console.WriteLine("\nYou reach out to grab the new weapon and admire its fine craftsmanship");
            Thread.Sleep(1000);
            Console.WriteLine("An overwhelimg sense of power rushes over you and you feel reinvigorated by it");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Continue");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            RoomFour.GuardsRoom();
        }

        public static void PuzzleLoser()
        {
            int newWeapon = 0;
            GameIntroScreen gameIntroScreen = new GameIntroScreen();

            Console.WriteLine("\nYou hear a click, then another and another and another");
            Thread.Sleep(1000);

            if (GameIntroScreen.PlayerClass == 1)
            {
                Console.WriteLine("You watch as the metal cage surrounding the staff slams down, sending the staff down into the plinth never to be seen again");
            }
            else if (GameIntroScreen.PlayerClass == 2)
            {
                Console.WriteLine("You watch as the metal cage surrounding the axe slams down, sending the axe down into the plinth never to be seen again");
            }
            else if (GameIntroScreen.PlayerClass == 3)
            {
                Console.WriteLine("You watch as the metal cage surrounding the daggers slams down, sending the daggers down into the plinth never to be seen again");
            }

            Thread.Sleep(1000);
            Console.WriteLine("'All that effort, for nothing....' you think to yourself");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Continue");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            RoomFour.GuardsRoom();
        }
    }
}
