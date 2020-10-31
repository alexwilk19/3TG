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
            Random rand = new Random();
            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 41; col++)
                {
                    if (row == 0 || row == 19)//top or bottom rows
                    {

                        if (col == 0 || col == 40)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            if (col == 18 )
                            {
                                Console.Write("<");
                            }
                            else if (col == 22)
                            {
                                Console.Write(">");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                         
                        }
                    }
      
                    else
                    {
                      
                         if (col == 0 || col == 40)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            if (row == 18 && col == 20)
                            {
                               
                                    Console.Write("@");
                                

                            }
                            else
                            {
                                 Console.Write(" ");
                            }
                       
                        }
                    }
                }
                Console.Write("\n");

            }
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
                //case "i":
                default:
                    break;
            }
            Console.Read();
        }
    }
}
