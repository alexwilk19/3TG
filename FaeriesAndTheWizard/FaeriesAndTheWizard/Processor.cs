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
                ProcessText(item, 40);
            }      
        }

    }
}
