using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class RoomOne
    {
        public static void EntrancePuzzle()
        {
                                string stonesArt = @"                                   _
                                                     ,d8b,
                                             _,,aadd8888888bbaa,,_
                                        _,ad88P""""""8,  I8I  ,8""""""Y88ba,_
                                     ,ad88P"" `Ya  `8, `8' ,8'  aP' ""Y88ba,
                                   ,d8""' ""Yb   ""b, `b  8  d' ,d""   dP"" `""8b,
                                  dP""Yb,  `Yb,  `8, 8  8  8 ,8'  ,dP'  ,dP""Yb
                               ,ad8b, `Yb,  ""Ya  `b Y, 8 ,P d'  aP""  ,dP' ,d8ba,
                              dP"" `Y8b, `Yb, `Yb, Y,`8 8 8',P ,dP' ,dP' ,d8P' ""Yb
                             ,88888888Yb, `Yb,`Yb,`8 8 8 8 8',dP',dP' ,dY88888888,
                             dP     `Yb`Yb, Yb,`8b 8 8 8 8 8 d8',dP ,dP'dP'     Yb
                            ,8888888888b ""8, Yba888888888888888adP ,8"" d8888888888,
                            dP        `Yb,`Y8P""""'             `""""Y8P',dP'        Yb
                           ,88888888888P""Y8P'_.---.._     _..---._`Y8P""Y88888888888,
                           dP         d'  8 '  ____  `. .'  ____  ` 8  `b         Yb
                          ,888888888888   8   <(@@)>  | |  <(@@)>   8   888888888888,
                          dP          8   8    `""""""         """"""'    8   8          Yb
                         ,8888888888888,  8          ,   ,          8  ,8888888888888,
                         dP           `b  8,        (.-_-.)        ,8  d'           Yb
                        ,88888888888888Yaa8b      ,'       `,      d8aaP88888888888888,
                        dP               """"8b     _,gd888bg,_     d8""""               Yb
                       ,888888888888888888888b,    """"Y888P""""    ,d888888888888888888888,
                       dP                   ""8""b,             ,d""8""                   Yb
                      ,888888888888888888888888,""Ya,_,ggg,_,aP"",888888888888888888888888,
                      dP                      ""8,  ""8""\x/""8""  ,8""                      Yb
                     ,88888888888888888888888888b   8\\x//8   d88888888888888888888888888,
                     8888bgg,_                  8   8\\x//8   8                  _,ggd8888
                      `""Yb, """"8888888888888888888   Y\\x//P   8888888888888888888"""" ,dP""'
                        _d8bg,_""8,              8   `b\x/d'   8              ,8""_,gd8b_
                      ,iP""   ""Yb,8888888888888888    8\x/8    8888888888888888,dP""  `""Yi,
                     ,P""    __,888              8    8\x/8    8              888,__    ""Y,
                    ,8baaad8P"""":Y8888888888888888 aaa8\x/8aaa 8888888888888888P:""""Y8baaad8,
                    dP""':::::::::8              8 8::8\x/8::8 8              8:::::::::`""Yb
                    8::::::::::::8888888888888888 8::88888::8 8888888888888888::::::::::::8
                    8::::::::::::8,             8 8:::::::::8 8             ,8::::::::::::8
                    8::::::::::::8888888888888888 8:::::::::8 8888888888888888::::::::::::8
                    8::::::::::::Ya             8 8:::::::::8 8             aP::::::::::::8
                    8:::::::::::::888888888888888 8:::::::::8 888888888888888:::::::::::::8
                    8:::::::::::::Ya            8 8:::::::::8 8            aP:::::::::::::8
                    Ya:::::::::::::88888888888888 8:::::::::8 88888888888888:::::::::::::aP
                    `8;:::::::::::::Ya,         8 8:::::::::8 8         ,aP:::::::::::::;8'
                     Ya:::::::::::::::""Y888888888 8:::::::::8 888888888P"":::::::::::::::aP
                     `8;::::::::::::::::::::""""""""Y8888888888888P""""""""::::::::::::::::::::;8'
                      Ya:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::aP
                       ""b;:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;d""
                        `Ya;:::::::::::::::::::::::::::::::::::::::::::::::::::::::;aP'
                          `Ya;:::::::::::::::::::::::::::::::::::::::::::::::::::;aP'
                             ""Ya;:::::::::::::::::::::::::::::::::::::::::::::;aP""
                                ""Yba;;;:::::::::::::::::::::::::::::::::;;;adP""
                                    `""""""""""""""Y888888888888888888888P""""""""""""""'
                    ";


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("\nYou light up a torch, blazing fire lighting up the stones before you...");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(2000);
            Console.Write(stonesArt);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nA large carving reveals itself in front of you, The mask of the Pharoah.");
            Console.WriteLine("Beneath it you spy some barely legible words...");
            Console.WriteLine("Walks on four in the morning... two in noon... three in the evening...");
            Console.WriteLine("'Appears to be a riddle of some kind' you think to yourself");

            bool continueGame = false;

            while(continueGame == false)
            {
                Console.WriteLine("\nWhat is the answer of the riddle?");
                string riddleAnswer = Console.ReadLine();

                switch (riddleAnswer)
                {
                    case string a when a.Contains("Man") || a.Contains("man") || a.Contains("Person") || a.Contains("person") || a.Contains("Human") || a.Contains("human"):
                        Console.WriteLine("\nThe eyes of the carving suddenly glow a brilliant red and you hear churning in the background");
                        Console.WriteLine("Before your very eyes you see the solid wall slowly sink into the floor, revealing a pitch black hallway");
                        continueGame = true;
                        break;

                    default:
                        Console.WriteLine("Nothing Happened");
                        continueGame = false;
                        break;
                }
            }
        }
    }
}
