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
        internal static void ProcessText(string s)
        {
            s += "\n";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }
        internal static void ProcessText(string s, string add, string f)
        {
            s += add;
            s += f;
            s += "\n";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }

    }
}
