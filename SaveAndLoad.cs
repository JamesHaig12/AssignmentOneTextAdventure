using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class SaveAndLoad
    {
        public static void SaveGame()
        {
            PlayerOne playerOne = new PlayerOne(); 
            GameIntroScreen gameIntroScreen = new GameIntroScreen();

            FileStream f = new FileStream("E:\\" + GameIntroScreen.PlayerName + "_save.txt", FileMode.Create);
            //string fileName = gameIntroScreen.PlayerName + "_save.txt";
            using (StreamWriter writer = new StreamWriter(f))
            {
                // Write game state information to the file
                writer.WriteLine("playerName=" + GameIntroScreen.PlayerName);               
                writer.WriteLine("playerClass=" + GameIntroScreen.PlayerClass);
                writer.WriteLine("playerLocation=" + PlayerOne.Location);
                writer.WriteLine("playerHealth=" + playerOne.Health);
                writer.WriteLine("playerMana=" + playerOne.Mana);
                writer.WriteLine("playerStamina=" + playerOne.Stamina);
                writer.WriteLine("playerArmour=" + playerOne.Armour);
                writer.WriteLine("playerDamageBuff=" + playerOne.DamageBuff);
                writer.Close();
                f.Close();
            }
        }

        public static void LoadGame()
        {
            PlayerOne playerOne = new PlayerOne();
            GameIntroScreen gameIntroScreen = new GameIntroScreen();

            FileStream f = new FileStream("E:\\" + GameIntroScreen.PlayerName + "_save.txt", FileMode.Open);
            string fileName = "E:\\" + GameIntroScreen.PlayerName + "_save.txt";
            if (File.Exists(fileName))
            {
                // Open the file containing the saved game state
                using (StreamReader reader = new StreamReader(f))
                {
                    // Read the game state data from the file
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Parse the game state data from the file
                        string[] parts = line.Split('=');
                        string key = parts[0];
                        string value = parts[1];
                        // Update the game state based on the data read from the file
                        switch (key)
                        {
                            case "playerName":
                                GameIntroScreen.PlayerName = value;
                                break;

                            case "playerClass":
                                GameIntroScreen.PlayerClass = int.Parse(value);
                                break;

                            case "playerLocation":
                                PlayerOne.Location = int.Parse(value);
                                break;

                            case "playerHealth":
                                playerOne.Health = int.Parse(value);
                                break;

                            case "playerMana":
                                playerOne.Mana = int.Parse(value);
                                break;

                            case "playerStamina":
                                playerOne.Stamina = int.Parse(value);
                                break;

                            case "playerArmour":
                                playerOne.Armour = int.Parse(value);
                                break;

                            case "playerDamageBuff":
                                playerOne.DamageBuff = int.Parse(value);
                                break;
                        }
                    }
                }
                if(PlayerOne.Location == 1)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    GameIntroScreen.GameIntro(GameIntroScreen.PlayerClass);
                }
                else if(PlayerOne.Location == 2)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    RoomOne.EntrancePuzzle();
                }
                else if(PlayerOne.Location == 3)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    RoomTwo.TreasureRoom();
                }
                else if(PlayerOne.Location == 4)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    RoomThree.WeaponRoom();
                }
                else if(PlayerOne.Location == 5)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    RoomFour.GuardsRoom();
                }
                else if(PlayerOne.Location == 6)
                {
                    Console.WriteLine("Loading... Please Wait");
                    Thread.Sleep(5000);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress Any Key To Continue");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                    RoomFive.BossRoom();
                }
            }
            else
            {
                Console.WriteLine("Save data for " + GameIntroScreen.PlayerName + " not found.");
            }
        }
    }
}
