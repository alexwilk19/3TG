using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Processor.ProcessText(TextStorage.IntroText);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2);

            Console.Read();
        }
    }
}
