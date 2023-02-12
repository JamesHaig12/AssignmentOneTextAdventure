using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    internal class Mimic
    {
        public static void MimicFight()
        {
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            MimicNPC npc = new MimicNPC();
            Console.Clear();
            Console.WriteLine("The mimic springs at you but you manage to parry the first hit");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nCombat has begun.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("\nYou leap into action, sword at the ready");
            Console.WriteLine(GameIntroScreen.PlayerClass);

            if(GameIntroScreen.PlayerClass == 1)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM;
                int damagePL;
                int damagePH;
                int damagePS;
                int chanceToHitPL;
                int chanceToHitPH;
                int chanceToHitM;
                

                while(npc.Health > 0)
                {
                    chanceToHitM = random.Next(1, 10);
                    damageM = random.Next(1, 5);
                    Console.WriteLine("\nThe mimic attempts to bite you");
                    if(chanceToHitM > 6)
                    {                       
                        Console.WriteLine("The Mimic lands its bite");
                        Console.WriteLine("You take {0} damage", damageM);
                        playerOne.Health -= damageM;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("The bite misses");
                    }
                   
                    if (playerOne.Health < 0)
                    {
                        GameOver.GameoverScreen();
                    }

                    chanceToHitPL = random.Next(1, 10);
                    chanceToHitPH = random.Next(1, 10);
                    damagePL = random.Next(1, 5);
                    damagePH = random.Next(4, 10);
                    damagePS = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mimic");
                            if(chanceToHitPL > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL);
                                npc.Health -= damagePL;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mimic");
                            if(chanceToHitPH > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH);
                                npc.Health -= damagePH;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Mana > 10)
                            {
                                Console.WriteLine("You charge up your magical energy and let out a blast of blue light");
                                Console.WriteLine("You lost 10 mana.");
                                playerOne.Mana -= 10;
                                Console.WriteLine("{0} Mana remaining.", playerOne.Mana);
                                Console.WriteLine("You dealt {0} damage!", damagePS);
                                npc.Health -= damagePS;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mimic found the opportunity for another attack");
                            break;
                    }
                }
                Console.WriteLine("\nThe mimic stops in its tracks, turns lifeless and crashes to the ground.");
                Thread.Sleep(1000);
                Console.WriteLine("You won this fight... for now.");
                Thread.Sleep(1000);
                Console.WriteLine("As its corpse settles something clangs onto the floor from beneath it, the key!.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomThree.WeaponRoom();
            }
            else if (GameIntroScreen.PlayerClass == 2)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM2;
                int damagePL2;
                int damagePH2;
                int damagePS2;
                int chanceToHitPL2;
                int chanceToHitPH2;
                int chanceToHitM2;


                while (npc.Health > 0)
                {
                    chanceToHitM2 = random.Next(1, 10);
                    damageM2 = random.Next(1, 5);
                    Console.WriteLine("\nThe mimic attempts to bite you");
                    if (chanceToHitM2 > 6)
                    {
                        Console.WriteLine("The Mimic lands its bite");
                        Console.WriteLine("You take {0} damage", damageM2);
                        playerOne.Health -= damageM2;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("The bite misses");
                    }

                    if (playerOne.Health < 0)
                    {
                        GameOver.GameoverScreen();
                    }

                    chanceToHitPL2 = random.Next(1, 10);
                    chanceToHitPH2 = random.Next(1, 10);
                    damagePL2 = random.Next(1, 5);
                    damagePH2 = random.Next(4, 10);
                    damagePS2 = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mimic");
                            if (chanceToHitPL2 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL2);
                                npc.Health -= damagePL2;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mimic");
                            if (chanceToHitPH2 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH2);
                                npc.Health -= damagePH2;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Stamina > 10)
                            {
                                Console.WriteLine("You charge up all the strength you can must and let out a barrage of blows");
                                Console.WriteLine("You lost 10 stamina.");
                                playerOne.Stamina -= 10;
                                Console.WriteLine("{0} stamina remaining.", playerOne.Stamina);
                                Console.WriteLine("You dealt {0} damage!", damagePS2);
                                npc.Health -= damagePS2;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mimic found the opportunity for another attack");
                            break;
                    }
                }
                Console.WriteLine("\nThe mimic stops in its tracks, turns lifeless and crashes to the ground.");
                Thread.Sleep(1000);
                Console.WriteLine("You won this fight... for now.");
                Thread.Sleep(1000);
                Console.WriteLine("As its corpse settles something clangs onto the floor from beneath it, the key!.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomThree.WeaponRoom();
            }
            else if (GameIntroScreen.PlayerClass == 3)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM3;
                int damagePL3;
                int damagePH3;
                int damagePS3;
                int chanceToHitPL3;
                int chanceToHitPH3;
                int chanceToHitM3;


                while (npc.Health > 0)
                {
                    chanceToHitM3 = random.Next(1, 10);
                    damageM3 = random.Next(1, 5);
                    Console.WriteLine("\nThe mimic attempts to bite you");
                    if (chanceToHitM3 > 6)
                    {
                        Console.WriteLine("The Mimic lands its bite");
                        Console.WriteLine("You take {0} damage", damageM3);
                        playerOne.Health -= damageM3;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("The bite misses");
                    }

                    if (playerOne.Health < 0)
                    {
                        GameOver.GameoverScreen();
                    }

                    chanceToHitPL3 = random.Next(1, 10);
                    chanceToHitPH3 = random.Next(1, 10);
                    damagePL3 = random.Next(1, 5);
                    damagePH3 = random.Next(4, 10);
                    damagePS3 = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mimic");
                            if (chanceToHitPL3 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL3);
                                npc.Health -= damagePL3;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mimic");
                            if (chanceToHitPH3 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH3);
                                npc.Health -= damagePH3;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Stamina > 10)
                            {
                                Console.WriteLine("You let out a flurry of quick jabs at lightning speed");
                                Console.WriteLine("You lost 10 stamina.");
                                playerOne.Stamina -= 10;
                                Console.WriteLine("{0} Stamina remaining.", playerOne.Stamina);
                                Console.WriteLine("You dealt {0} damage!", damagePS3);
                                npc.Health -= damagePS3;
                                Console.WriteLine("Mimic Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mimic found the opportunity for another attack");
                            break;
                    }
                }
                Console.WriteLine("\nThe mimic stops in its tracks, turns lifeless and crashes to the ground.");
                Thread.Sleep(1000);
                Console.WriteLine("You won this fight... for now.");
                Thread.Sleep(1000);
                Console.WriteLine("As its corpse settles something clangs onto the floor from beneath it, the key!.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomThree.WeaponRoom();
            }
        }
    }
}
