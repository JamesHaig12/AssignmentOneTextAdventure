using System;
using System.Security.Cryptography.X509Certificates;

namespace AssignmentOneTextAdventure
{
    public class menu
    {
        public static void Main(string[] args)
        {
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
            ClassSelection();
        }

        public static void ClassSelection()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThree adventurers gather before the entrance of the pyramid. A Mage, A Warrior And A Rogue");
            Console.WriteLine("\nYou Are?");
            string classChoice = Console.ReadLine();

            if (classChoice.Contains("mage") == true || classChoice.Contains("Mage") == true)
            {
                int playerClass = 1;
                Console.WriteLine("\nYou, the Mage, approach the entrance first...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress enter to continue...");
                Console.ReadKey();
                Console.Clear();
                GameMage();
            }
        }

        public static void GameMage()
        {

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
            Console.WriteLine("'I d-dont think i want to do this anymore' your warrior stammers, your rogue nodding in agreement");
            Console.WriteLine("'Fine.. i shall go alone if you two will be such cowards' you say, glancing sternly in their direction.");
            Console.WriteLine("You watch as your fellow party members scamper back off to saftey, shaking your head.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("As you approach the entrance you realise in the darkness its just a solid wall");
            Console.WriteLine("All those people who went missing had to get in somehow though, right?");

            bool continueGame = false;
            
            while(continueGame == false)
            {
                Console.WriteLine("\nWhat do you do?");
                string playerEntranceChoiceOne = Console.ReadLine();

                switch (playerEntranceChoiceOne)
                {
                    case string a when a.Contains("Look"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case string b when b.Contains("look"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case string c when c.Contains("Clue"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case string d when d.Contains("clue"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case string e when e.Contains("Search"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case string f when f.Contains("search"):
                        continueGame = true;
                        EntrancePuzzle();
                        break;

                    case null:
                        Console.WriteLine("Hmm im not sure i can do that right now");
                        break;
                }
            }              
        }

        public static void EntrancePuzzle()
        {
            Console.WriteLine("puzzle");
            Console.ReadKey();
        }
    }
}

