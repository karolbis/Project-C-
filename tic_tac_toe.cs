using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace TiCTacToe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            while (Wygrany() == false)
            {
                Gracze("x");
                if (Wygrany() == true)
                    break;
                Gracze("0");
            }
        }







        static String[] NumTablica = new String[9];
        static void zmienna()
        {
            for (int i = 0; i < 9; i++)
            {
                NumTablica[i] = i.ToString();
            }
        }
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         OOOO                                          XX       XX                   ");
            Console.WriteLine("      OO      OO                                        XX     XX                  ");
            Console.WriteLine("     OO        OO                                        XX   XX                     ");
            Console.WriteLine("    OOO        OOO                                        XX XX                ");
            Console.WriteLine("    OOO        OOO     AA          N     N   DDD           XXX                   ");
            Console.WriteLine("    OOO        OOO    A  A        N N   N    D  DD        XX XX               ");
            Console.WriteLine("     OO       OO     A AA A      N   N N     D  DD       XX   XX                   ");
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
            Console.Clear();

            static void Tablica()
            {
                Console.Clear();
                Console.WriteLine("  .........................");
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  :   1   :   2   :   3   :", NumTablica[0], NumTablica[1], NumTablica[2]);
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  .........................");
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  :   1   :   2   :   3   :", NumTablica[3], NumTablica[4], NumTablica[5]);
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  .........................");
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  :   1   :   2   :   3   :", NumTablica[6], NumTablica[7], NumTablica[8]);
                Console.WriteLine("  :       :       :       :");
                Console.WriteLine("  .........................");


            }
            
            

            }
    }
}
