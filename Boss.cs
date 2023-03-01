using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class Boss
    {
        public static void BossFight()
        {
            GameIntroScreen gameIntroScreen = new GameIntroScreen();
            BossNPC npc = new BossNPC();
            Console.Clear();
            Console.WriteLine("The bellow knocks you to the ground");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nCombat has begun.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("\nYou stagger up, tired, confused and disoriented, but willing to fight until you die... or make it out alive.");
            Thread.Sleep(1000);
            Console.WriteLine("The pharoahs mummy comes towards you, the ground shaking beneath its feet. Its now or never, adventurer.");

            if (GameIntroScreen.PlayerClass == 1)
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
                int timesAttacked = 0;


                while (npc.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM = random.Next(1, 10);
                    damageM = random.Next(1, 5);
                    Console.WriteLine("\nThe mummy swipes a clawed hand in your direction");
                    if (chanceToHitM > 6)
                    {
                        Console.WriteLine("The mummy lands its attack");
                        Console.WriteLine("You take {0} damage", damageM - playerOne.Armour);
                        playerOne.Health -= damageM - playerOne.Armour;
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

                    timesAttacked++;
                    if(timesAttacked == 5)
                    {
                        Console.WriteLine("\nThe mummy lets out a might bellow, making you stumble around");
                        Thread.Sleep(1000);
                        Console.WriteLine("'WHY WONT YOU DIE?'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The shockwave from its booming voice knocks you to the ground");
                        Console.WriteLine("You take 2 damage");
                        playerOne.Health -= 2;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else if(timesAttacked == 10)
                    {
                        Console.WriteLine("\n'IM SICK OF YOU PETULANT HUMAN'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The mummy becomes enraged and lets out a flurry of massive blows in your direction, too fast for you to dodge");
                        Thread.Sleep(1000);
                        Console.WriteLine("You take 10 damage");
                        playerOne.Health -= 10;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }

                    chanceToHitPL = random.Next(1, 10);
                    chanceToHitPH = random.Next(1, 10);
                    damagePL = random.Next(1, 5);
                    damagePH = random.Next(4, 10);
                    damagePS = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mummy");
                            if (chanceToHitPL > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL - npc.Armour);
                                npc.Health -= damagePL - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mummy");
                            if (chanceToHitPH > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH - npc.Armour);
                                npc.Health -= damagePH - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
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
                                Console.WriteLine("You dealt {0} damage!", damagePS - npc.Armour);
                                npc.Health -= damagePS - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mummy found the opportunity for another attack");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe mummy pauses for a second, looks down at its bleedind wounds, then looks back at you");
                Thread.Sleep(1000);
                Console.WriteLine("'impossible' the mummy wheezes with its last breath before falling to the ground");
                Thread.Sleep(1000);
                Console.WriteLine("You look down at its body, relief rushing over you, its finally dead. The pharoahs curse was gone... it was time to go home.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                GameEnd.GameFinished();
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
                int timesAttacked = 0;


                while (npc.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM2 = random.Next(1, 10);
                    damageM2 = random.Next(1, 5);
                    Console.WriteLine("\nThe mummy swipes at you with a clawed hand");
                    if (chanceToHitM2 > 6)
                    {
                        Console.WriteLine("The Mummy lands its attack");
                        Console.WriteLine("You take {0} damage", damageM2 - playerOne.Armour);
                        playerOne.Health -= damageM2 - playerOne.Armour;
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

                    timesAttacked++;
                    if (timesAttacked == 5)
                    {
                        Console.WriteLine("\nThe mummy lets out a might bellow, making you stumble around");
                        Thread.Sleep(1000);
                        Console.WriteLine("'WHY WONT YOU DIE?'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The shockwave from its booming voice knocks you to the ground");
                        Console.WriteLine("You take 2 damage");
                        playerOne.Health -= 2;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else if (timesAttacked == 10)
                    {
                        Console.WriteLine("\n'IM SICK OF YOU PETULANT HUMAN'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The mummy becomes enraged and lets out a flurry of massive blows in your direction, too fast for you to dodge");
                        Thread.Sleep(1000);
                        Console.WriteLine("You take 10 damage");
                        playerOne.Health -= 10;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }

                    chanceToHitPL2 = random.Next(1, 10);
                    chanceToHitPH2 = random.Next(1, 10);
                    damagePL2 = random.Next(1, 5);
                    damagePH2 = random.Next(4, 10);
                    damagePS2 = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mummy");
                            if (chanceToHitPL2 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL2 - npc.Armour);
                                npc.Health -= damagePL2 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mummy");
                            if (chanceToHitPH2 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH2 - npc.Armour);
                                npc.Health -= damagePH2 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
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
                                Console.WriteLine("You dealt {0} damage!", damagePS2 - npc.Armour);
                                npc.Health -= damagePS2 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mummy found the opportunity for another attack");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe mummy pauses for a second, looks down at its bleedind wounds, then looks back at you");
                Thread.Sleep(1000);
                Console.WriteLine("'impossible' the mummy wheezes with its last breath before falling to the ground");
                Thread.Sleep(1000);
                Console.WriteLine("You look down at its body, relief rushing over you, its finally dead. The pharoahs curse was gone... it was time to go home.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                GameEnd.GameFinished();
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
                int timesAttacked = 0;


                while (npc.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    chanceToHitM3 = random.Next(1, 10);
                    damageM3 = random.Next(1, 5);
                    Console.WriteLine("\nThe mummy swipes at you with a clawed hand");
                    if (chanceToHitM3 > 6)
                    {
                        Console.WriteLine("The Mummy lands its attack");
                        Console.WriteLine("You take {0} damage", damageM3 - playerOne.Armour);
                        playerOne.Health -= damageM3 - playerOne.Armour;
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


                    timesAttacked++;
                    if (timesAttacked == 5)
                    {
                        Console.WriteLine("\nThe mummy lets out a might bellow, making you stumble around");
                        Thread.Sleep(1000);
                        Console.WriteLine("'WHY WONT YOU DIE?'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The shockwave from its booming voice knocks you to the ground");
                        Console.WriteLine("You take 2 damage");
                        playerOne.Health -= 2;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }
                    else if (timesAttacked == 10)
                    {
                        Console.WriteLine("\n'IM SICK OF YOU PETULANT HUMAN'");
                        Thread.Sleep(1000);
                        Console.WriteLine("The mummy becomes enraged and lets out a flurry of massive blows in your direction, too fast for you to dodge");
                        Thread.Sleep(1000);
                        Console.WriteLine("You take 10 damage");
                        playerOne.Health -= 10;
                        Console.WriteLine("HP: {0}", playerOne.Health);
                    }

                    chanceToHitPL3 = random.Next(1, 10);
                    chanceToHitPH3 = random.Next(1, 10);
                    damagePL3 = random.Next(1, 5);
                    damagePH3 = random.Next(4, 10);
                    damagePS3 = random.Next(10, 20);
                    Console.WriteLine("\nWhat do you do?");
                    string playerAttack = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    switch (playerAttack)
                    {
                        case string a when a.Contains("light"):
                            Console.WriteLine("\nYou attempt to light attack the mummy");
                            if (chanceToHitPL3 > 2)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePL3 - npc.Armour);
                                npc.Health -= damagePL3 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You missed.");
                            }
                            break;

                        case string b when b.Contains("heavy"):
                            Console.WriteLine("\nYou attempt to heavy attack the mummy");
                            if (chanceToHitPH3 > 5)
                            {
                                Console.WriteLine("You hit it head on!");
                                Console.WriteLine("You dealt {0} damage!", damagePH3 - npc.Armour);
                                npc.Health -= damagePH3 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
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
                                Console.WriteLine("You dealt {0} damage!", damagePS3 - npc.Armour);
                                npc.Health -= damagePS3 - npc.Armour;
                                Console.WriteLine("Mummy Health: {0}", npc.Health);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough mana for this yet");
                            }
                            break;

                        case string d when d.Contains("hint"):
                            Console.WriteLine("Combat has three moves, Light Attack, Heavy Attack and Special attack");
                            Console.WriteLine("Whilst you were thinking of what to do the mummy found the opportunity for another attack");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe mummy pauses for a second, looks down at its bleedind wounds, then looks back at you");
                Thread.Sleep(1000);
                Console.WriteLine("'impossible' the mummy wheezes with its last breath before falling to the ground");
                Thread.Sleep(1000);
                Console.WriteLine("You look down at its body, relief rushing over you, its finally dead. The pharoahs curse was gone... it was time to go home.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress any key to continue...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                GameEnd.GameFinished();
            }
        }
    }   
}
