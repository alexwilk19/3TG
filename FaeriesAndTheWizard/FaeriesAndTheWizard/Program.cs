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
        private void Combat(ref Wizard player, int eHP, int eDMG)
        {
            Faerie enemy = new Faerie(eHP, eDMG);
            Console.WriteLine("\n\n\n\n");
            Processor.ProcessText("An evil fae! It wants to kill you for using its kindred as reagents. How foolish. Show them who has the superior magic!",10);         
            Console.WriteLine("\n");
            Processor.ProcessText("Choose an ability to attack them:\n" +
                "1. Staff Strike --- You deal between 10-20 damage, with no miss chance.\n" +
                "2. Fireball --- You deal between 1-100 damage, with a chance to instead damage yourself!\n" +
                "3. Ice Strike --- You deal 30 damage, with a 20% chance to deal double damage, or miss.\n", 10);

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {

            Processor.ProcessText(TextStorage.IntroText, 20);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2, 20);
            Thread.Sleep(600);


            Processor.ProcessText(TextStorage.FirstChoiceO12, 20);
        NewRoom:
            Random randy = new Random();
            Room TrainingRoom = new Room(randy.Next(1,19000000));
            string newRoomText = "Ah, a lower floor of the tower.\nAt a quick glance, this room contains ";
            int enemyNumberPerRoom = 0;
            int itemNumberPerRoom = 0;

            foreach (var item in TrainingRoom.Contents)
            {

                Processor.ProcessText(item.Key + ". " + item.Value, 20);



                if (item.Value.Contains("F"))
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
            Processor.ProcessText($"Score: {player._Score}", 10);
            Processor.ProcessText($"Room Number: {player._RoomsCleared + 1}/30", 10);
            Processor.ProcessText(newRoomText, 10);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (TrainingRoom.Contents.ContainsKey(choice))
            {
                if (TrainingRoom.Contents[choice].Contains("I"))
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
                else if(TrainingRoom.Contents[choice].Contains("F")) //combat stuff happens in here
                {
                    Random crand = new Random();
                    int faeHP = 0;
                    int faeDMG = 0;
                    switch (crand.Next(2))
                    {
                        case 0:
                            faeHP = 30;
                            break;
                        case 1:
                            faeHP = 60;
                            break;
                        case 2:
                            faeHP = 90;
                            break;
                        default:
                            break;
                    }
                    switch(crand.Next(2))
                    {
                        case 0:
                            faeDMG = 20;
                            break;
                        case 1:
                            faeDMG = 40;
                            break;
                        case 2:
                            faeDMG = 60;
                            break;
                        default:
                            break;
                    }
                }

            }
            else if (!TrainingRoom.Contents.ContainsKey(choice))           
            {

            }
            player._RoomsCleared++;
            Console.WriteLine("\n\n\n\n");
            goto NewRoom;
        }
    }
}
