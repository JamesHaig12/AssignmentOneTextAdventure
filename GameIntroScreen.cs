using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace AssignmentOneTextAdventure
{
    public class GameIntroScreen
    {
        public static readonly Stopwatch timer = new Stopwatch();

        private static string? playerName;
        public static string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private static int playerClass;

        public static int PlayerClass
        {
            get { return playerClass; }
            set { playerClass = value; }
        }


        public static void Main(string[] args)
        {
            //Creating object of the class to access the playerName variable
            //This is handy later for using the player name in the rest of the game
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            GameArtworks gameArtworks = new GameArtworks();

            //Calls the window resizer script in my other class to maximise the window on startup
            WindowResizer.ResizeWindow();

            //Will be save load function
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("=============================");
            bool continueApp = false;

            while(continueApp == false)
            {
                Console.WriteLine("\nNew Game Or Load Save Or Display The Leaderboard?");
                string userLoadSave = Console.ReadLine().ToLower();

                switch (userLoadSave)
                {
                    case string a when a.Contains("new"):
                        continueApp = true;
                        break;

                    case string c when c.Contains("leaderboard"):
                        FileStream f = new FileStream("E:\\Leaderboard.txt", FileMode.Open);
                        string fileName = "E:\\Leaderboard.txt";
                        if (File.Exists(fileName))
                        {
                            // Open the file containing the saved game state
                            using (StreamReader reader = new StreamReader(f))
                            {
                                string text = reader.ReadToEnd();
                                Console.WriteLine("\n"+text);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("\nPress Any Key To Continue");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No leaderboard found");                  
                        }
                        continueApp = true;
                        break;

                    case string b when b.Contains("load") || b.Contains("save"):
                        SaveAndLoad saveAndLoad = new SaveAndLoad();
                        Console.WriteLine("Please enter your name you entered at the start of your game");
                        string userName = Console.ReadLine().ToLower();
                        GameIntroScreen.PlayerName = userName;
                        SaveAndLoad.LoadGame();
                        continueApp = true;
                        break;
                }

            }

            //Tutorial
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nHello and welcome to my game!");
            Console.WriteLine("Throughout the game you will be faced with questions such as 'What will you do?'");
            Console.WriteLine("Please feel free to type what ever you'd like, however you may only progress with certain actions");
            Console.WriteLine("During combat, your character has three moves. Light, heavy, and special");
            Console.WriteLine("Special moves are class specific and use either stamina or mana, these hit 100% of the time");
            Console.WriteLine("Light attacks hit more often but do the least damage");
            Console.WriteLine("Heavy attacks hit less often but do more damage than a light attack");
            Console.WriteLine("If at any point you dont understand what you need to do, just type 'Hint'");
            Console.WriteLine("At any major point where the game asks you to make an action, you may type 'Save' to save your game");
            Console.WriteLine("Please Note: Saving cannot be done during combat, please wait for comabt to end before saving your game");
            Console.WriteLine("Thank you for playing and i hope you enjoy.");
            Console.WriteLine("Now... Shall we begin?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            //Set colour of console to dark red and create ascii art for title
            Console.ForegroundColor = ConsoleColor.DarkRed;

            timer.Start();

            //Gathering players name for future
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("What is your name traveller?");
            GameIntroScreen.playerName = Console.ReadLine().ToLower();
            Console.WriteLine("\nWelcome, {0}, to...", GameIntroScreen.playerName);
            Thread.Sleep(2000);
            Console.Clear();
     
            Console.Write(gameArtworks.MenuArt);
            Console.WriteLine("\nThe great pyramid of Prestonia, known to all as the final resting place of the mighty Pharoah Uclaneses III. " +
                "\nMany fear this place, only few have dared to enter... but none have returned. Will you?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThree adventurers gather before the entrance of the pyramid. A Mage, A Warrior And A Rogue");
            ClassSelection();
        }

        public static void ClassSelection()
        {
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            //Switch statement within a while loop, allows for character selection
            //While loop allows for validation, no valid answer =  go around again
            bool continueGame = false;
            
            while(continueGame == false)
            {
                Console.WriteLine("\nYou Are?");
                string classChoice = Console.ReadLine().ToLower();
                switch (classChoice)
                {
                    case string a when a.Contains("mage"):
                        GameIntroScreen.PlayerClass = 1;
                        Console.WriteLine("\nYou, the Mage, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(GameIntroScreen.PlayerClass);
                        break;

                    case string b when b.Contains("warrior"):
                        GameIntroScreen.PlayerClass = 2;
                        Console.WriteLine("\nYou, the Warrior, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(GameIntroScreen.PlayerClass);
                        break;

                    case string c when c.Contains("rogue"):
                        GameIntroScreen.PlayerClass = 3;
                        Console.WriteLine("\nYou, the Rogue, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(GameIntroScreen.PlayerClass);
                        break;

                    case string d when d.Contains("hint"):
                        Console.WriteLine("Please type the name of the class you would like to choose");
                        break;                 

                    default:
                        Console.WriteLine("It doesnt seem like that class is present right now");
                        break;
                }
            }
        }

        //This method is catching playerClass arg as param
        public static void GameIntro(int playerClass)
        {
            GameArtworks gameArtworks = new GameArtworks();
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            PlayerOne playerOne = new PlayerOne();

            //New ascii art and colour
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(gameArtworks.EntranceArt);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThe moon looms over the pyramids, you and your party stood at the base of the largest.");

            //Thread.sleep used to space the time between lines
            Thread.Sleep(1000);

            //if else statement changes this sentence dependent on players class choice
            if (playerClass == 1) 
            {
                Console.WriteLine("'I d-dont think i want to do this anymore' your warrior stammers, your rogue nodding in agreement");
            }
            else if (playerClass == 2)
            {
                Console.WriteLine("'I d-dont think i want to do this anymore' your mage stammers, your rogue nodding in agreement");
            }
            else if (playerClass == 3 )
            {
                Console.WriteLine("'I d-dont think i want to do this anymore' your warrior stammers, your mage nodding in agreement");
            }

            //Just dialog spaced by sleeps
            Thread.Sleep(1000);
            Console.WriteLine("'Fine.. i shall go alone if you two will be such cowards' you say, glancing sternly in their direction.");
            Thread.Sleep(1000);
            Console.WriteLine("You watch as your fellow party members scamper back off to saftey, shaking your head.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("As you approach the entrance you realise in the darkness its just a solid wall");
            Thread.Sleep(1000);
            Console.WriteLine("All those people who went missing had to get in somehow though, right?");

            //Another switch in a while loop for choice validation
            bool continueGame = false;
            
            while(continueGame == false)
            {
                Console.WriteLine("\nWhat do you do?");
                string playerEntranceChoiceOne = Console.ReadLine().ToLower();

                switch (playerEntranceChoiceOne)
                {
                    case string a when a.Contains("look") || a.Contains("clue") || a.Contains("search"):
                        continueGame = true;
                        RoomOne.EntrancePuzzle();
                        break;

                    case string b when b.Contains("light") || b.Contains("torch"):
                        continueGame = true;
                        RoomOne.EntrancePuzzle();
                        break;

                    case string c when c.Contains("feel") || c.Contains("touch"):
                        Console.WriteLine("You feel about on the wall and find some carvings that you cant make out, if only you had some light.");
                        break;

                    case String d when d.Contains("hint"):
                        Console.WriteLine("There is something on the wall, maybe try lighting a torch.");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 1;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("\nHmm im not sure i can do that right now");
                        break;
                }
            }              
        }
    }
}

