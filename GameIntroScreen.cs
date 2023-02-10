using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace AssignmentOneTextAdventure
{
    public class GameIntroScreen
    {
        //This whole section is made to auto resize the console window to full screen... yes its that bad
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        public static void Main(string[] args)
        {
            //Resize console window
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            //Set colour of console to dark red and create ascii art for title
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
                        string menuArt = @"
             ____  _                           _            ____                    
            |  _ \| |__   __ _ _ __ __ _  ___ | |__  ___   / ___|   _ _ __ ___  ___ 
            | |_) | '_ \ / _` | '__/ _` |/ _ \| '_ \/ __| | |  | | | | '__/ __|/ _ \
            |  __/| | | | (_| | | | (_| | (_) | | | \__ \ | |__| |_| | |  \__ \  __/
            |_|   |_| |_|\__,_|_|  \__,_|\___/|_| |_|___/  \____\__,_|_|  |___/\___|
                                                                        
                                                                             ";

            Console.Write(menuArt);
            Console.WriteLine("\nThe great pyramid of Prestonia, known to all as the final resting place of the mighty Pharoah Uclaneses III. " +
                "\nMany fear this place, only few have dared to enter... but none have returned. Will you?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThree adventurers gather before the entrance of the pyramid. A Mage, A Warrior And A Rogue");
            ClassSelection();
        }

        public static void ClassSelection()
        {
            //Switch statement within a while loop, allows for character selection
            //While loop allows for validation, no valid answer =  go around again
            bool continueGame = false;
            
            while(continueGame == false)
            {
                Console.WriteLine("\nYou Are?");
                string classChoice = Console.ReadLine().ToLower();
                int playerClass;
                switch (classChoice)
                {
                    case string a when a.Contains("mage"):
                        playerClass = 1;
                        Console.WriteLine("\nYou, the Mage, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(playerClass);
                        break;

                    case string c when c.Contains("warrior"):
                        playerClass = 2;
                        Console.WriteLine("\nYou, the Warrior, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(playerClass);
                        break;

                    case string e when e.Contains("rogue"):
                        playerClass = 3;
                        Console.WriteLine("\nYou, the Rogue, approach the entrance first...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        continueGame = true;
                        GameIntro(playerClass);
                        break;

                    default:
                        Console.WriteLine("It doesnt seem like that class is present right now");
                        continueGame = false;
                        break;
                }
            }
        }

        //This method is catching playerClass arg as param
        public static void GameIntro(int playerClass)
        {
            //New ascii art and colour
            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            string entranceArt = @"
                                .,aadd""'    `""bbaa,.
                            ,ad8888P'          `Y8888ba,
                         ,a88888888              88888888a,
                       a88888888888              88888888888a
                     a8888888888888b,          ,d8888888888888a
                    d8888888888888888b,_    _,d8888888888888888b
                   d88888888888888888888888888888888888888888888b
                  d8888888888888888888888888888888888888888888888b
                 I888888888888888888888888888888888888888888888888I
                ,88888888888888888888888888888888888888888888888888,
                I8888888888888888PY8888888PY88888888888888888888888I
                8888888888888888""  ""88888""  ""88888888888888888888888
                8::::::::::::::'    `:::'    `:::::::::::::::::::::8
                Ib:::::::::::""        ""        `::::::' `:::::::::dI
                `8888888888P            Y88888888888P     Y88888888'
                 Ib:::::::'              `:::::::::'       `:::::dI
                  Yb::::""                  "":::::""           ""::dP
                   Y88P                      Y8P               `P
                    Y'                        ""
                                                `:::::::::::;8""
                       ""888888888888888888888888888888888888""
                         `""8;::::::::::::::::::::::::::;8""'
                            `""Ya;::::::::::::::::::;aP""'
                                ``""""YYbbaaaaddPP""""''
                                                                                 ";

            Console.Write(entranceArt);
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
            else if (playerClass ==3 )
            {
                Console.WriteLine("'I d-dont think i want to do this anymore' your rogue stammers, your mage nodding in agreement");
            }

            //Just dialog spaced by sleeps
            Thread.Sleep(1000);
            Console.WriteLine("'Fine.. i shall go alone if you two will be such cowards' you say, glancing sternly in their direction.");
            Thread.Sleep(1000);
            Console.WriteLine("You watch as your fellow party members scamper back off to saftey, shaking your head.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("As you approach the entrance you realise in the darkness its just a solid wall");
            Thread.Sleep(1000);
            Console.WriteLine("All those people who went missing had to get in somehow though, right?");

            //Another switch in a while for choice validation
            //NEEDS OPTIMISING WIP
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

                    default:
                        Console.WriteLine("Hmm im not sure i can do that right now");
                        break;
                }
            }              
        }
    }
}

