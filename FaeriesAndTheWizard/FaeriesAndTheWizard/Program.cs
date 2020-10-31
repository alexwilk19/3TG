using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Processor.ProcessText(TextStorage.IntroText, 60);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2, 60);
            Thread.Sleep(600);
            Processor.ProcessText(TextStorage.FirstChoicesT1, 60);
            Processor.PresentOptions(TextStorage.FirstChoices);

            Console.Read();
        }
    }
}
