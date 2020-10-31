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
        internal static void ProcessText(string s)
        {
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }
    }
}
