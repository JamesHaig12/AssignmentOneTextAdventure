using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class Guards
    {
        public static void GuardFight()
        {
            Console.Clear();
            Console.WriteLine("\nA thud from the base of the statues catches your attention");
            Thread.Sleep(1000);
            Console.WriteLine("A horrible cracking sound begins and echos around you.");
            Thread.Sleep(1000);
            Console.WriteLine("You watch the first foot lift off the pedastal, and then the second... third.... fourth");
            Thread.Sleep(1000);
            Console.WriteLine("You look up in horror and see both statues coming to life, brandishing their blades, one with an axe, one with a lance.");
            Thread.Sleep(4000);

            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            GuardNPC1 npc = new GuardNPC1();
            GuardNPC2 npc2 = new GuardNPC2();
            Console.Clear();
            Console.WriteLine("\nThe first guard lunges at you but you manage to parry the first hit");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nCombat has begun.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("\nYou leap into action, your weapon ready to strike");

            if (GameIntroScreen.PlayerClass == 1)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM;
                int damageM2;
                int damagePL;
                int damagePH;
                int damagePS;
                int chanceToHitPL;
                int chanceToHitPH;
                int chanceToHitM;
                int chanceToHitM2;
                int whichGuard;


                while ((npc.Health > 0) && (npc2.Health > 0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM = random.Next(1, 10);
                    damageM = random.Next(1, 5);
                    Console.WriteLine("\nThe axe guard swings his giant waraxe in your direction");
                    if (chanceToHitM > 6)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM - playerOne.Armour);
                        playerOne.Health -= damageM - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You dodge the attack");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM2 = random.Next(1, 10);
                    damageM2 = random.Next(1, 5);
                    Console.WriteLine("\nThe lance guard lunges at you at lightning speed");
                    if (chanceToHitM2 > 6)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM2 - playerOne.Armour);
                        playerOne.Health -= damageM2 - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You parry its lunge and stagger back");
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
                    whichGuard = random.Next(1, 2);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack on of the guards");
                            if (chanceToHitPL > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL + playerOne.DamageBuff);
                                if(whichGuard == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePL + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if(whichGuard == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePL + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack one of the guards");
                            if (chanceToHitPH > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH + playerOne.DamageBuff);
                                if (whichGuard == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePH + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePH + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Mana > 10)
                            {
                                Console.WriteLine("\nYou charge up your magical energy and let out a blast of blue light");
                                Console.WriteLine("You lost 10 mana.");
                                playerOne.Mana -= 10;
                                Console.WriteLine("{0} Mana remaining.", playerOne.Mana);
                                Console.WriteLine("You dealt {0} damage!", damagePS);
                                if (whichGuard == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePS + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePS + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the guards found the opportunity for another attack");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBoth guards bodies lie lifeless on the ground. You won, again.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress Any Key To Continue");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomFive.BossRoom();
            }
            else if (GameIntroScreen.PlayerClass == 2)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM3;
                int damageM4;
                int damagePL2;
                int damagePH2;
                int damagePS2;
                int chanceToHitPL2;
                int chanceToHitPH2;
                int chanceToHitM3;
                int chanceToHitM4;
                int whichGuard2;


                while ((npc.Health > 0) && (npc2.Health > 0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM3 = random.Next(1, 10);
                    damageM3 = random.Next(1, 5);
                    Console.WriteLine("\nThe axe guard swings his giant waraxe in your direction");
                    if (chanceToHitM3 > 6)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM3 - playerOne.Armour);
                        playerOne.Health -= damageM3 - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You dodge the attack");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM4 = random.Next(1, 10);
                    damageM4 = random.Next(1, 5);
                    Console.WriteLine("\nThe lance guard lunges at you at lightning speed");
                    if (chanceToHitM4 > 6)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM4 - playerOne.Armour);
                        playerOne.Health -= damageM4 - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You parry its lunge and stagger back");
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
                    whichGuard2 = random.Next(1, 2);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack one of the guards");
                            if (chanceToHitPL2 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL2 + playerOne.DamageBuff);
                                if (whichGuard2 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePL2 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard2 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePL2 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack one of the guards");
                            if (chanceToHitPH2 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH2 + playerOne.DamageBuff);
                                if (whichGuard2 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePH2 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard2 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePH2 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Stamina > 10)
                            {
                                Console.WriteLine("\nYou charge up all the strength you can muster and let out a barrage of blows");
                                Console.WriteLine("You lost 10 stamina.");
                                playerOne.Stamina -= 10;
                                Console.WriteLine("{0} stamina remaining.", playerOne.Stamina);
                                Console.WriteLine("You dealt {0} damage!", damagePS2 + playerOne.DamageBuff);
                                if (whichGuard2 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePS2 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard2 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePS2 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the guards found the opportunity for another attack");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBoth guards bodies lie lifeless on the ground. You won, again.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress Any Key To Continue");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomFive.BossRoom();
            }
            else if (GameIntroScreen.PlayerClass == 3)
            {
                PlayerOne playerOne = new PlayerOne();
                Random random = new Random();
                int damageM5;
                int damageM6;
                int damagePL3;
                int damagePH3;
                int damagePS3;
                int chanceToHitPL3;
                int chanceToHitPH3;
                int chanceToHitM5;
                int chanceToHitM6;
                int whichGuard3;


                while ((npc.Health > 0 && npc2.Health > 0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM5 = random.Next(1, 10);
                    damageM5 = random.Next(1, 5);
                    Console.WriteLine("\nThe axe guard swings his giant waraxe in your direction");
                    if (chanceToHitM5 > 5)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM5 - playerOne.Armour);
                        playerOne.Health -= damageM5 - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You dodge the attack");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM6 = random.Next(1, 10);
                    damageM6 = random.Next(1, 5);
                    Console.WriteLine("\nThe lance guard lunges at you at lightning speed");
                    if (chanceToHitM6 > 5)
                    {
                        Console.WriteLine("The guard lands its hit");
                        Console.WriteLine("You take {0} damage", damageM6 - playerOne.Armour);
                        playerOne.Health -= damageM6 - playerOne.Armour;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else
                    {
                        Console.WriteLine("You parry its lunge and stagger back");
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
                    whichGuard3 = random.Next(1, 2);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack one of the guards");
                            if (chanceToHitPL3 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL3 + playerOne.DamageBuff);
                                if (whichGuard3 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePL3 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard3 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePL3 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack one of the guards");
                            if (chanceToHitPH3 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH3 + playerOne.DamageBuff);
                                if (whichGuard3 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePH3 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard3 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePH3 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string c when c.Contains("special"):
                            if (playerOne.Stamina > 10)
                            {
                                Console.WriteLine("\nYou let out a flurry of quick jabs at lightning speed");
                                Console.WriteLine("You lost 10 stamina.");
                                playerOne.Stamina -= 10;
                                Console.WriteLine("{0} Stamina remaining.", playerOne.Stamina);
                                Console.WriteLine("You dealt {0} damage!", damagePS3 + playerOne.DamageBuff);
                                if (whichGuard3 == 1 && npc.Health > 0)
                                {
                                    npc.Health -= damagePS3 + playerOne.DamageBuff;
                                    Console.WriteLine("Axe Guard Health: {0}", npc.Health);
                                }
                                else if (whichGuard3 == 2 && npc2.Health > 0)
                                {
                                    npc2.Health -= damagePS3 + playerOne.DamageBuff;
                                    Console.WriteLine("Lance Guard Health: {0}", npc2.Health);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mimic found the opportunity for another attack");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBoth guards bodies lie lifeless on the ground. You won, again.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress Any Key To Continue");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                RoomFive.BossRoom();
            }
        }
    }
}
