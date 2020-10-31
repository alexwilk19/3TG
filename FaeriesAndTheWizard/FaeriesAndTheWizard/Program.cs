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
            Random randy = new Random();
            Room TrainingRoom = new Room(randy.Next(19000000)); 
            string newRoomText = "Ah, a lower floor of the tower.\nAt a quick glance, this room contains ";
            int enemyNumberPerRoom = 0;
            int itemNumberPerRoom = 0;
            foreach (var item in TrainingRoom.Contents)
            {
                Processor.ProcessText(item.Key + ". " +item.Value, 20);

                if (item.Value.Contains("X"))
                {
                    enemyNumberPerRoom++;
                }
                if (item.Value.Contains("I"))
                {
                    itemNumberPerRoom++;
                }
            }
            newRoomText += $"{enemyNumberPerRoom} possible faeries, and {itemNumberPerRoom} items in the room!";
            if (itemNumberPerRoom > 3 && enemyNumberPerRoom > 3)
            {
                newRoomText += $"\nIt seems you have a lot of choice here. But choose carefully!";
            }
            else if (itemNumberPerRoom > 3)
            {
                newRoomText += $"\nThis room is a treasure trove, it seems! Choose wisely.";
            }
            else if (enemyNumberPerRoom > 3)
            {
                newRoomText += $"\nBe careful in this room, for you sense many faeries in here!";
            }
            else
            {
                newRoomText += $"\nIt seems this will be a quiet room... perhaps...";
            }
            Processor.ProcessText($"Score: {player._Score}",10);
            Processor.ProcessText($"Room Number: {player._RoomsCleared + 1}/30", 10);
           

            if (TrainingRoom.Contents.ContainsKey(Convert.ToInt32(Console.ReadLine())))
            {
                Random rand = new Random();
                int result = rand.Next(2);
                switch (result)
                {
                    case 0:
                        player._Score += 10;
                        Processor.ProcessText("You have found a potion! Plus 10 points!", 10);
                        break;
                    case 1:
                        player._Score += 20;
                        Processor.ProcessText("You have found a trinket! Plus 20 points!", 20);
                        break;
                    case 2:
                        player._Score += 30;
                        Processor.ProcessText("You have found an artifact! Plus 30 point!", 30);
                        break;
                    default:
                        break;
                }
            }
            player._RoomsCleared++;
            goto NewRoom;
        }
    }
}
