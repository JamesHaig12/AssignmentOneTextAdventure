using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomFour
    {
        public static void GuardsRoom()
        {
            PlayerOne playerOne = new PlayerOne();
            Console.Clear();
            Console.WriteLine("\nYou look up from the weapon to see a bright light, shining onto the pillar with the bear, straight north");
            Thread.Sleep(1000);
            Console.WriteLine("As you watch with awe, the pillar shifts and starts to sink into the floor, allowing for the light to shine onto the wall behind it");
            Thread.Sleep(1000);
            Console.WriteLine("Then, the seams between the stones crack, opening up like the maw of a giant beast");
            Thread.Sleep(1000);
            Console.WriteLine("You head inside the new room, its the only way to go thats not back.");
            Thread.Sleep(1000);
            
            Console.WriteLine("\nThe room is a hexagonal shape, a large round table in the very centre of the room");
            Thread.Sleep(1000);
            Console.WriteLine("In the back two corners stands two statues of Anubis, wearing armour and weilding massive blades");
            Thread.Sleep(1000);
            Console.WriteLine("To the left, once again... a chest");

            bool continueGame = false;

            while(continueGame == false)
            {
                Console.WriteLine("\nWhat do you do?");
                string playerAnswer = Console.ReadLine().ToLower();

                switch (playerAnswer)
                {
                    case string a when a.Contains("chest"):                    
                        Console.WriteLine("\nYou move over to the chest, very cautiosly this time, your wounds from the mimic still fresh");
                        Thread.Sleep(1000);
                        Console.WriteLine("You swing it open, its a real chest. Inside is a glistening plate of armour");
                        Thread.Sleep(1000);
                        Console.WriteLine("You decide putting it on couldnt hurt any more than getting hit without it...");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n+5 Armour: -5 To Incoming Damage");
                        playerOne.Armour += 5;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        continueGame = true;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress Any Key To Continue");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.ReadKey();
                        Guards.GuardFight();
                        break;

                    case string b when b.Contains("statue"):
                        Console.WriteLine("\nYou approach the statues, willing to examine them...");
                        continueGame = true;
                        Guards.GuardFight();
                        break;

                    case string c when c.Contains("hint"):
                        Console.WriteLine("\nWould you like to examine the chest or the statues?");
                        break;

                    case string x when x.Contains("save"):
                        Console.WriteLine("Saving game");
                        PlayerOne.Location = 5;
                        continueGame = true;
                        SaveAndLoad.SaveGame();
                        break;

                    default:
                        Console.WriteLine("\nNot sure i can do that right now");
                        break;
                }
            }

        }
    }
}
