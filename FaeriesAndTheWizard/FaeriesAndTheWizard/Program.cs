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
           
            Processor.ProcessText(TextStorage.IntroText, 20);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2, 60);
            Thread.Sleep(600);
            Processor.ProcessText(TextStorage.FirstChoicesT1, 20);
            Processor.PresentOptions(TextStorage.FirstChoices);
            Rooms AllRooms = new Rooms(10);

            switch (Console.ReadLine())
            {
                case "1":
                    Processor.ProcessText(TextStorage.FirstChoiceO1, 20);
                    Processor.ProcessText(TextStorage.FirstChoiceO12, 20);
                    if (Console.ReadLine() == "r")
                    {
                        Processor.PresentOptions(TextStorage.TrainingRoomDraw);
                    }
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
