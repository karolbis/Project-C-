using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TicTacToe1

{

    class Program

    {
        static char[] NumTablica =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        static int player = 1;

        static int choice;
        static bool isEnd;
        static int flag = 0;
        static void Main(string[] args)
        {
            Start();

            do
            {
                PlayGame();


                Console.WriteLine("Would you play to play again? Y or N");
            } while (Console.ReadLine().ToLower() == "y");
            if (Console.ReadLine().ToLower() == "n")
                Console.WriteLine("\nThanks for playing!");


        }

        public static void PlayGame()
        {
            if (isEnd)
            {
                Program.NumTablica = new char[]{
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

            }
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Player 1 is X || Player 2 is O");

                Console.WriteLine("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Tablica();
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                if (NumTablica[choice] != 'X' && NumTablica[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        NumTablica[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        NumTablica[choice] = 'X';
                        player++;
                    }
                }

                else
                {
                    Console.WriteLine("ALREADY TAKEN PLACE, PLEASE PICK OTHER", choice, NumTablica[choice]);
                }

                flag = Wygrana();

            } while (flag != 1 && flag != -1);

            Console.Clear();

            Tablica();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
                Console.WriteLine("Here is your trophy:");
                Console.WriteLine("  __________     ");
                Console.WriteLine(" |    XOX   |    ");
                Console.WriteLine("  |   OXO  |     ");
                Console.WriteLine("   |  XOX |      ");
                Console.WriteLine("    |____|       ");
                Console.WriteLine("      ||         ");
                Console.WriteLine("      ||         ");
                Console.WriteLine("     ||||        ");
            }
            else
            {
                Console.WriteLine("Draw");
            }

        }



        private static void Tablica()

        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  .........................");
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  :   {0}   :   {1}   :   {2}   :", NumTablica[1], NumTablica[2], NumTablica[3]);
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  .........................");
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  :   {0}   :   {1}   :   {2}   :", NumTablica[4], NumTablica[5], NumTablica[6]);
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  .........................");
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  :   {0}   :   {1}   :   {2}   :", NumTablica[7], NumTablica[8], NumTablica[9]);
            Console.WriteLine("  :       :       :       :");
            Console.WriteLine("  .........................");

        }

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         OOOO                                          XX       XX                   ");
            Console.WriteLine("      OO      OO                                        XX     XX                  ");
            Console.WriteLine("     OO        OO                                        XX   XX                     ");
            Console.WriteLine("    OOO        OOO                                        XX XX                ");
            Console.WriteLine("    OOO        OOO     AA       N     N      DDD           XXX                   ");
            Console.WriteLine("    OOO        OOO    A  A      N N   N      D  DD        XX XX               ");
            Console.WriteLine("     OO       OO     A AA A     N   N N      D  DD       XX   XX                   ");
            Console.WriteLine("       OO    OO     A      A    N     N      DDD        XX     XX                     ");
            Console.WriteLine("         OOOO                                          XX       XX      ");

            Console.ResetColor();
            Console.WriteLine("Press any key to start...");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rules of Tic Tac Toe:");
            Console.WriteLine("Tic Tac Toe is a game for a two players." +
                "\nEvery round ends when player1 or player2 finishes his move - choosing a position of X or O." +
                "\nThe frist player who score three same signatures in a row is the winner of a game." +
                "\nMay the best win!!!" +
                "\nPress any key to continue");
            Console.ReadKey();
        }


        private static int Wygrana()
        {
            //Wszystkie wygrane w pionie
            if (NumTablica[1] == NumTablica[4] && NumTablica[4] == NumTablica[7])
            {
                isEnd = true;
                return 1;
            }
            else if
            (NumTablica[2] == NumTablica[5] && NumTablica[5] == NumTablica[8])
            {
                isEnd = true;
                return 1;
            }
            else if
            (NumTablica[3] == NumTablica[6] && NumTablica[6] == NumTablica[9])
            {
                isEnd = true;
                return 1;
            }
            //Wszystkie wygrane w poziomie
            else if
            (NumTablica[1] == NumTablica[2] && NumTablica[2] == NumTablica[3])
            {
                isEnd = true;
                return 1;
            }
            else if
            (NumTablica[4] == NumTablica[5] && NumTablica[5] == NumTablica[6])
            {
                isEnd = true;
                return 1;
            }
            else if
            (NumTablica[7] == NumTablica[8] && NumTablica[8] == NumTablica[9])
            {
                isEnd = true;
                return 1;
            }
            //Wszystkie wygrane po skosie
            else if
            (NumTablica[3] == NumTablica[5] && NumTablica[5] == NumTablica[7])
            {
                isEnd = true;
                return 1;
            }
            else if
            (NumTablica[1] == NumTablica[5] && NumTablica[5] == NumTablica[9])
            {
                isEnd = true;
                return 1;
            }
            //Remisy 
            else if
            (NumTablica[1] != '1' && NumTablica[2] != '2' && NumTablica[3] != '3' && NumTablica[4] != '4' && NumTablica[5] != '5' && NumTablica[6] != '6' && NumTablica[7] != '7' && NumTablica[8] != '8' && NumTablica[9] != '9')

            {
                isEnd = true;
                return -1;

            }
            else
            {
                isEnd = true;
                return 0;
            }

        }
    }
}
