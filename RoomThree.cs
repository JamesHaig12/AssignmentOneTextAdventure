using System;
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

                    default:
                        Console.WriteLine("Not sure i can do that right now");
                        break;
                }
            }
        }

        public static void WeaponRoomPuzzle()
        {
            GameArtworks gameArtworks = new GameArtworks();
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
            Console.WriteLine("In the middle of the compass you see a plinth");
            if(GameIntroScreen.PlayerClass == 1)
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
            string[] riddle = { "The Grizzly Apex Predator", "The Mountain Climber", "The Ship Of The Desert", "The Venomous Reptile", "The School Of The Sea",
                                "The Bird Of Freedom", "The Tail Of A Spear", "The Brain Of The Ocean" };

            Random rand = new Random();
            int index = rand.Next(riddle.Length);
            do
            {
                index = rand.Next(riddle.Length);
            }
            while(index == 1 || index == 2 || index == 6 || index == 4 || index == 3);
            int index2 = rand.Next(riddle.Length);
            do
            {
                index2 = rand.Next(riddle.Length);
            }
            while ((index2 == index) && (index == 1 || index == 2 || index == 6 || index == 4 || index == 3));
            int index3 = rand.Next(riddle.Length);
            do
            {
                index3 = rand.Next(riddle.Length);
            }
            while ((index3 == index || index3 == index2) && (index == 1 || index == 2 || index == 6 || index == 4 || index == 3));

            Console.WriteLine("\nAround the plinth is a metal cage, you cannot fit your hand through the bars");
            Console.WriteLine("There is a plaque attached to the plinth");
            Console.WriteLine($"The plaque reads: {riddle[index]}, {riddle[index2]}, {riddle[index3]}");
            Console.WriteLine("There is a button on the plinth that can be pressed");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Figure out the compass points the riddle aludes to");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            bool continueGame = false;

            while (continueGame == false)
            {
                Console.WriteLine("Enter a compass point to examine or submit your answer?");
                string playerChoice = Console.ReadLine().ToLower();

                switch (playerChoice)
                {
                    case ("north"):
                        if(index == 0)
                        {
                            Console.WriteLine("Bear");
                        }
                        else if(index == 5)
                        {
                            Console.WriteLine("Eagle");
                        }
                        else if(index == 7)
                        {
                            Console.WriteLine("Octopus");
                        }
                        break;

                    case ("north east"):
                        Console.WriteLine("Goat");
                        break;

                    case ("east"):
                        if (index2 == 0)
                        {
                            Console.WriteLine("Bear");
                        }
                        else if (index2 == 5)
                        {
                            Console.WriteLine("Eagle");
                        }
                        else if (index2 == 7)
                        {
                            Console.WriteLine("Octopus");
                        }
                        break;

                    case ("south east"):
                        Console.WriteLine("Camel");
                        break;

                    case ("south"):
                        Console.WriteLine("Fish");
                        break;

                    case ("south west"):
                        if (index3 == 0)
                        {
                            Console.WriteLine("Bear");
                        }
                        else if (index3 == 5)
                        {
                            Console.WriteLine("Eagle");
                        }
                        else if (index3 == 7)
                        {
                            Console.WriteLine("Octopus");
                        }
                        break;

                    case ("west"):
                        Console.WriteLine("Scorpion");
                        break;

                    case ("north west"):
                        Console.WriteLine("Snake");
                        break;

                    case string a when a.Contains("submit"):
                        bool continueGame2 = false;

                        while(continueGame2 == false)
                        {
                            Console.WriteLine("What is your final guess of compass points?");
                            string playerGuess = Console.ReadLine().ToLower();

                            switch (playerGuess)
                            {
                                case ("north east southwest"):
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
                }
            }
        }

        public static void PuzzleWinner()
        {
            Console.WriteLine("Win");
            Console.ReadKey();
        }

        public static void PuzzleLoser()
        {
            Console.WriteLine("Lose");
            Console.ReadKey();
        }
    }
}
