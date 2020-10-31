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

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2, 20);
            Thread.Sleep(600);
        

            Processor.ProcessText(TextStorage.FirstChoiceO12, 20);
            NewRoom:
            Room TrainingRoom = new Room(1);
            Processor.ProcessText(("Score: " + player._Score), 20);
            Processor.ProcessText(("Room: " + (player._RoomsCleared /10) + 1), 20);
            foreach (var item in TrainingRoom.Contents)
            {
                Processor.ProcessText(item.Key + ". " +item.Value, 20);
            }

            if (TrainingRoom.Contents.ContainsKey(Convert.ToInt32(Console.ReadLine())))
            {
                Random rand = new Random();
                int result = rand.Next(9);
                switch (result)
                {
                    case 0:
                        player._Score += 10;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 1:
                        player._Score += 10;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 2:
                        player._Score += 10;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 3:
                        player._Score += 10;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 4:
                        player._Score += 10;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 5:
                        player._Score += 30;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a trinket! Plus 30 points!", 20);
                        break;
                    case 6:
                        player._Score += 30;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a trinket! Plus 30 points!", 20);
                        break;
                    case 7:
                        player._Score += 30;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found a trinket! Plus 30 points!", 20);
                        break;
                    case 8:
                        player._Score += 100;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found an artifact! Plus 100 point!", 20);
                        break;
                    case 9:
                        player._Score += 100;
                        player._RoomsCleared += 1;
                        Processor.ProcessText("You have found an artifact! Plus 100 point!", 20);
                        break;
                    default:
                        break;
                }
            }
            goto NewRoom;
        }
    }
}
