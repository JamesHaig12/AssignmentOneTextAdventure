using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomFive
    {
        public static void BossRoom()
        {
            GameArtworks gameArtworks = new GameArtworks();
            Console.Clear();
            Console.WriteLine("\nYou take a deep breath, everything in here has tried to kill you so far...");
            Thread.Sleep(1000);
            Console.WriteLine("In the centre of the wall to the right two holes appear, big enough to fit your hands into");
            Thread.Sleep(1000);
            Console.WriteLine("Above them you see words carved into the wall");
            Thread.Sleep(1000);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(gameArtworks.BloodArt);

            bool continueGame = false;

            while(continueGame == false)
            {
                Console.WriteLine("\nWhat do you do?");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case string a when a.Contains("sacrifice") || a.Contains("hands"):
                        Console.WriteLine("\nScared, but adamant, you shove your hands into the wall and close your eyes");
                        Thread.Sleep(1000);
                        Console.WriteLine("You feel a searing hot pain shoot up your left arm");
                        Thread.Sleep(1000);
                        Console.WriteLine("Adrenaline kicks in and you yank your arms out of the wall, you see blood leaking from your forearm");
                        Thread.Sleep(1000);
                        Console.WriteLine("A sliver of a cut, only about a millimeter deep from the top of your forearm to your wrist leaks blood onto the floor");
                        Thread.Sleep(1000);
                        Console.WriteLine("The blood sacrfice had been made, a slab from the wall falls backwards revealing a small entrance.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress Any Key To Continue");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.ReadKey();
                        continueGame = true;
                        break;

                    case string b when b.Contains("guards"):
                        Console.WriteLine("\nYou had an idea!");
                        Thread.Sleep(1000);
                        Console.WriteLine("You race over to the guards lifeless bodies and grab one of them, dragging it to the holes");
                        Thread.Sleep(1000);
                        Console.WriteLine("You shove its arms in and listen... A clunk, then a grinding noise");
                        Thread.Sleep(1000);
                        Console.WriteLine("The blood sacrfice had been made, a slab from the wall falls backwards revealing a small entrance.");
                        continueGame = true;
                        break;

                    case string c when c.Contains("hint"):
                        Console.WriteLine("\nSacrifice some of your blood, or something else?");
                        break;

                    default:
                        Console.WriteLine("\nHmm not sure i can do that right now");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Clambering through the entrance you have to light up another torch");
            Thread.Sleep(1000);
            Console.WriteLine("As it bursts into flame you realise what you have stumbled into");
            Thread.Sleep(1000);
            Console.WriteLine("To your right is a torch holder, you place your torch into it");
            Thread.Sleep(1000);
            Console.WriteLine("Fire lights up beside you and spreads through the room, to each brazier one by one");
            Thread.Sleep(1000);
            Console.WriteLine("The room is enermous, at least 200 feet long, pillars on either side holding the structure up beneath the weight of the pyramid");
            Thread.Sleep(1000);
            Console.WriteLine("A long, large red carpet stretches down the entire room");
            Thread.Sleep(1000);
            Console.WriteLine("At the end of the carpet you see a sarcophagus of immense size, behind it a large golden throne that twinkles in the fire light");
            Thread.Sleep(1000);
            Console.WriteLine("A deep rumbling emits from the room around you... Dust displacing itself from the cieling");
            Thread.Sleep(1000);
            Console.WriteLine("You watch as the lid of the sarcophagus starts to move and a booming voice is heard");
            Thread.Sleep(1000);
            Console.WriteLine("'WHO DARES AWAKEN ME?'");
            Thread.Sleep(1000);
            Console.WriteLine("The pharoah himself. Awoken from his slumber.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Continue");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Boss.BossFight();
        }
    }
}
