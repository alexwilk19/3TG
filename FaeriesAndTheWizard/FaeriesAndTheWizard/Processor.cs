using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    static class Processor
    {
        /// <summary>
        /// This is called from anywhere and fed a string to print the output to the console. 
        /// </summary>
        /// <param name="s"></param>
        internal static void ProcessText(string s, int t)
        {
            s += "\n";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(t);
            }
        }
        internal static void ProcessText(string s, string colour, int t)
        {
            switch (colour)
            {
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkcyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                default:
                    break;
            }
            s += "\n";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(t);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal static void ProcessText(string s, string add, string f, int t)
        {
            s += add;
            s += f;
            s += "\n";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(t);
            }
        }

        internal static void PresentOptions(string[] options)
        {
            int i = 0;
            foreach (var item in options)
            {
                i++;
                ProcessText(item, 10);
            }      
        }

    }
}
