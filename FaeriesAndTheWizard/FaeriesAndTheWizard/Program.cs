using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class Program
    {
        static int enemyNumberPerRoom;
        static int itemNumberPerRoom;
        static bool Dead = false;
        private static void Combat(ref Wizard player, int eHP, int eDMG)
        {
            Faerie enemy = new Faerie(eHP, eDMG);

            Console.WriteLine("\n\n\n\n");
            Processor.ProcessText("An evil fae! It wants to kill you for using its kindred as reagents. How foolish. Show them who has the superior magic!", 10);
            Console.WriteLine("\n");
        RetakeAttackChoice:
            Processor.ProcessText("Choose an ability to attack them:\n" +
                "1. Staff Strike --- You deal between 10-20 damage, with no miss chance.\n" +
                "2. Fireball --- You deal between 1-100 damage, with a 20% chance to instead damage yourself!\n" +
                "3. Ice Shard --- You deal 30 damage, with a 20% chance to deal double damage, or miss.\n", 10);

            switch (Console.ReadLine())
            {
                case "1":
                    enemy._Health -= player.StaffSmack();
                    Processor.ProcessText("Their remaining health = " + enemy._Health, 10);
                    break;
                case "2":
                    int tempdamage = player.Fireball();
                    if (tempdamage == 0)
                    {

                    }
                    else
                    {
                        enemy._Health -= tempdamage;
                        Processor.ProcessText("Their remaining health = " + enemy._Health, 10);
                    }

                    break;
                case "3":
                    int tdamage = player.IcicleSpear();
                    if (tdamage == 0)
                    {

                    }
                    else
                    {
                        enemy._Health -= tdamage;
                        Processor.ProcessText("Their remaining health = " + enemy._Health, 10);
                    }
                    break;
                default:
                    Console.WriteLine("Take a proper choice!");
                    goto RetakeAttackChoice;

            }
            Random r = new Random();

            if (enemy._Health > 0)
            {
                if (r.Next(2) == 0)
                {
                    player._Health -= enemy.MagicBlast();
                    Processor.ProcessText("Your remaining health = " + player._Health, 10);
                }
                else
                {
                    player._Health -= enemy.Swipe();
                    Processor.ProcessText("Your remaining health = " + player._Health, 10);
                }

                if (player._Health < 0)
                {
                    Processor.ProcessText("You have been slain! Restarting....", 10);
                    Dead = true;
                    Thread.Sleep(2200);

                }
                else
                {
                    goto RetakeAttackChoice;
                }

            }
            else
            {
                player._Score += (eHP + eDMG) / 2;
                Processor.ProcessText("The fae has been defeated!", 20);
                Processor.ProcessText($"Score: {player._Score}", 10);
            }


        }
        static void Main(string[] args)
        {
        EndOfGame2:
            Processor.ProcessText(TextStorage.IntroText, 20);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name, TextStorage.PostNameIntroP2, 20);
            Thread.Sleep(600);


            Processor.ProcessText(TextStorage.FirstChoiceO12, 20);
        NewRoom:
            Random randy = new Random();

            //Rooms happen here
            //cauldron room
            if ((player._RoomsCleared + 1) % 5 == 0 && player._RoomsCleared != 29)
            {
                bool b = false;
                Room CauldronRoom = new Room(b);
                Processor.ProcessText("A cauldron room! You have choices, yes, choices! You can either:\n" +
                    "1. Increase your health by 150\n" +
                    "2. Increase your score by 50\n" +
                    "3. Store Items\n", 10);
                WRONGCHOICE:
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Wrong choice again. Or for the first time. This tower is timeless.");
                        goto WRONGCHOICE;
                    
                }
                goto NewRoom;

            }
            //boss room 
            else if (player._RoomsCleared == 29)
            {

            }
            //normal room
            else
            {
                Room NormalRoom = new Room(randy.Next(1, 19000000));
                string newRoomText = "Ah, a lower floor of the tower.\nAt a quick glance, this room contains ";
                 enemyNumberPerRoom = 0;
                 itemNumberPerRoom = 0;
                PrintOptions(NormalRoom);
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
                Processor.ProcessText($"Inventory Space: {player._InventorySlots}/20", 10);
                Processor.ProcessText(newRoomText, 10);
            RetakeRoomChoice:
                string choice = Console.ReadLine();
                
                if (choice == "r" || choice == "R")
                {
                    player._RoomsCleared++;
                    Processor.ProcessText("",10);
                    Console.WriteLine("\n\n\n\n");
                    goto NewRoom;
                }
                else if (NormalRoom.Contents.ContainsKey(Convert.ToInt32(choice)))
                {
                    if (NormalRoom.Contents[Convert.ToInt32(choice)].Contains("I"))
                    {

                        Random rand = new Random();
                        int result = rand.Next(2);
                        if (player._InventorySlots < 20)
                        {
                            switch (result)
                            {
                                case 0:
                                    player._Score += 10;
                                    player._Potions++;
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found a potion! Plus 10 points! You take a sip and increase your health by 5.\n", 10);
                                    break;
                                case 1:
                                    player._Score += 20;
                                    player._Trinkets++;
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found a trinket! Plus 20 points!\n", 20);
                                    break;
                                case 2:
                                    player._Score += 30;
                                    player._Artifacts++;
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found an artifact! Plus 30 point!\n", 30);
                                    break;
                                default:
                                    break;
                            }
                            NormalRoom.Contents.Remove(Convert.ToInt32(choice));
                            PrintOptions(NormalRoom);
                            goto RetakeRoomChoice;
                        }
                        else
                        {
                            Processor.ProcessText("You are over encumbered! Woopsie, no item for you.\n",10);
                            NormalRoom.Contents.Remove(Convert.ToInt32(choice));
                            PrintOptions(NormalRoom);
                            goto RetakeRoomChoice;
                        }
                     
                    }

                    else if (NormalRoom.Contents[Convert.ToInt32(choice)].Contains("F")) //combat stuff happens in here
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
                        switch (crand.Next(2))
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
                        Combat(ref player, faeHP, faeDMG);
                        if (Dead == true)
                        {
                            goto EndOfGame2;
                        }
                        NormalRoom.Contents.Remove(Convert.ToInt32(choice));
                        PrintOptions(NormalRoom);
                        goto RetakeRoomChoice;
                    }

                }
                else
                {
                    Console.WriteLine("Wrong, take a listed choice.");
                    goto RetakeRoomChoice;
                }

          

            }
        }
        private static void PrintOptions(Room NormalRoom)
        {
            foreach (var item in NormalRoom.Contents)
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
            Processor.ProcessText("r. Skip room", 10);
        }
    }
}
