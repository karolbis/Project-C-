using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiCTacToe1
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";

            Console.WriteLine("         OOOO                                          XX       XX                   ");
            Console.WriteLine("      OO      OO                                        XX     XX                  ");
            Console.WriteLine("     OO        OO                                        XX   XX                     ");
            Console.WriteLine("    OOO        OOO                                        XX XX                ");
            Console.WriteLine("    OOO        OOO     AA          N     N   DDD           XXX                   ");
            Console.WriteLine("    OOO        OOO    A  A        N N   N    D  DD        XX XX               ");
            Console.WriteLine("     OO       OO     A AA A      N   N N     D  DD       XX   XX                   ");
            Console.WriteLine("       OO    OO     A      A    N     N      DDD        XX     XX                     ");
            Console.WriteLine("         OOOO                                          XX       XX      ");
            Console.ReadLine();
            Console.WriteLine("Press any key to start a game");
        }
    }
}
