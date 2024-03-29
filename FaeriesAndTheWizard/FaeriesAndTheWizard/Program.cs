﻿using System;
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
        static int TotalInventorySpace = 20;
        private static void Combat(ref Wizard player, int eHP, int eDMG)
        {
            Faerie enemy = new Faerie(eHP, eDMG);

            Console.WriteLine("\n\n\n\n");
            Processor.ProcessText("An evil fae! It wants to kill you for using its kindred as reagents. How foolish. Show them who has the superior magic!", "magenta",10);
            Processor.ProcessText("Your remaining health = " + player._Health, "green",10);
            Processor.ProcessText("Your remaining mana = " + player._Mana, "blue",10);
            Processor.ProcessText("\nTheir remaining health = " + enemy._Health, "red", 10);
        RetakeAttackChoice:
            Processor.ProcessText("Choose an ability to attack them:\n" +
            "1. Staff Strike --- You deal between 10-20 damage, with no miss chance - Costs 0 Mana.\n" +
            "2. Fireball --- You deal between 1-100 damage, with a 20% chance to instead damage yourself! - Costs 5 Mana\n" +
            "3. Ice Shard --- You deal 30 damage, with a 20% chance to deal double damage, or miss - Costs 10 Mana\n" +
            "4. Mana Drain --- You only deal 5 damage but recover 20 mana\n" +
            "5. Stop Time --- You deal 25 damage and stop the fae from attacking this turn. - Costs 15 Mana\n", "yellow", 10);

            switch (Console.ReadLine())
            {
                case "1":
                    enemy._Health -= player.StaffSmack();

                    break;
                case "2":
                    if (player._Mana >= 5)
                    {
                        player._Mana -= 5;
                        int tempdamage = player.Fireball();
                        if (tempdamage == 0)
                        {

                        }
                        else
                        {
                            enemy._Health -= tempdamage;

                        }

                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }


                    break;
                case "3":
                    if (player._Mana >= 10)
                    {
                        player._Mana -= 10;
                        int tdamage = player.IcicleSpear();
                        if (tdamage == 0)
                        {

                        }
                        else
                        {
                            enemy._Health -= tdamage;

                        }

                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }
                    break;
                case "4":
                    enemy._Health -= player.ManaDrain();
                    break;
                case "5":
                    if (player._Mana >= 15)
                    {
                        enemy._Health -= player.TimeFreeze();
                        Processor.ProcessText("\nTheir remaining health = " + enemy._Health, "red", 10);
                        goto RetakeAttackChoice;
                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }

                default:
                    Processor.ProcessText("\nTake a proper choice!", "red", 10);
                    goto RetakeAttackChoice;

            }
            Random r = new Random();
            Processor.ProcessText("\nTheir remaining health = " + enemy._Health, "red", 10);
            if (enemy._Health > 0)
            {
                switch (r.Next(5))
                {
                    case 0:
                        player._Health -= enemy.Swipe();
                        break;
                    case 1:
                        player._Health -= enemy.MagicBlast();
                        break;
                    case 2:
                        player._Health -= enemy.Swipe();
                        break;
                    case 3:
                        player._Health -= enemy.LesserWildDust();
                        break;
                    case 4:
                        player._Health -= enemy.Swipe();
                        break;
                    default:
                        player._Health -= enemy.Swipe();
                        break;
                }
   
                Processor.ProcessText("\nYour remaining health = " + player._Health, "green", 10);
                Processor.ProcessText("Your remaining mana = " + player._Mana, "blue", 10);
                if (player._Health < 0)
                {
                    Processor.ProcessText("\nYou have been slain! Restarting....", 10);
                    Dead = true;
             

                }
                else
                {
                    goto RetakeAttackChoice;
                }

            }
            else
            {
                player._FaeSlain++;
                player._Score += (eHP + eDMG) / 2;
                Processor.ProcessText("The fae has been defeated!", "magenta",20);
                Processor.ProcessText($"Score: {player._Score}", "yellow",10);
            }


        }
        private static void FinalCombat(ref Wizard player)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(600);
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(600);
            Console.BackgroundColor = ConsoleColor.Blue;
            Thread.Sleep(600);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Thread.Sleep(600);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(600);
            Console.BackgroundColor = ConsoleColor.Black;
            FeyQueenBase enemy;
            if(player._FaeSlain >= 25)
            {                
                enemy = new HellFae();

            }
            else
            {
                enemy = new BossFae();
                enemy._Health -= 250;
            }

            Processor.ProcessText("\nYour remaining health = " + player._Health, "green", 10);
            Processor.ProcessText("Your remaining mana = " + player._Mana, "blue", 10);
            Processor.ProcessText("\nTheir remaining health = " + enemy._Health, "red", 10);
        RetakeAttackChoice:
            Processor.ProcessText("Choose an ability to attack them:\n" +
               "1. Staff Strike --- You deal between 10-20 damage, with no miss chance - Costs 0 Mana.\n" +
               "2. Fireball --- You deal between 1-100 damage, with a 20% chance to instead damage yourself! - Costs 5 Mana\n" +
               "3. Ice Shard --- You deal 30 damage, with a 20% chance to deal double damage, or miss - Costs 10 Mana\n" +
               "4. Mana Drain --- You only deal 5 damage but recover 20 mana\n" +
               "5. Stop Time --- You deal 25 damage and stop the fae from attacking this turn. - Costs 15 Mana\n", "yellow", 10);

            switch (Console.ReadLine())
            {
                case "1":
                    enemy._Health -= player.StaffSmack();

                    break;
                case "2":
                    if (player._Mana >= 5)
                    {
                        player._Mana -= 5;
                        int tempdamage = player.Fireball();
                        if (tempdamage == 0)
                        {

                        }
                        else
                        {
                            enemy._Health -= tempdamage;

                        }

                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }


                    break;
                case "3":
                    if (player._Mana >= 10)
                    {
                        player._Mana -= 10;
                        int tdamage = player.IcicleSpear();
                        if (tdamage == 0)
                        {

                        }
                        else
                        {
                            enemy._Health -= tdamage;

                        }

                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }
                    break;
                case "4":
                    enemy._Health -= player.ManaDrain();
                    break;
                case "5":
                    if (player._Mana >= 15)
                    {
                        enemy._Health -= player.TimeFreeze();
                        goto RetakeAttackChoice;
                    }
                    else
                    {
                        Processor.ProcessText("\nNot enough mana! Your mana: " + player._Mana + ". Make another choice.", "blue", 10);
                        goto RetakeAttackChoice;
                    }
                  
                default:
                    Processor.ProcessText("\nTake a proper choice!", "red", 10);
                    goto RetakeAttackChoice;

            }
            Random r = new Random();
            Processor.ProcessText("\nTheir remaining health = " + enemy._Health,"red" ,10);
            if (enemy._Health > 0)
            {
                int ability = r.Next(6);
                switch (ability)
                {
                    case 0:
                        player._Health -= enemy.Strike();
                        break;
                    case 1:
                        player._Health -= enemy.Strike();
                        break;
                    case 2:
                        player._Health -= enemy.Strike();
                        break;
                    case 3:
                        enemy.Meditate();
                        break;
                    case 4:
                        player._Health -= enemy.WildDust();                           
                        break;
                    case 5:
                        player._Health -= enemy.WildCardHeal();
                        break;
                    case 6:
                        player._Health -= enemy.AuroraAura();
                        break;
                    default:
                        goto RetakeAttackChoice;
                }
                Processor.ProcessText("\nYour remaining health = " + player._Health, "green",10);
                Processor.ProcessText("Your remaining mana = " + player._Mana,"blue" ,10);



                if (player._Health < 0)
                {
                    Processor.ProcessText("\nYou have been slain! Restarting....","red",10);

                    Dead = true;


                }
                else
                {
                    goto RetakeAttackChoice;
                }
                Processor.ProcessText("\nYour remaining health = " + player._Health,"green" ,10);
            }
            else
            {
                player._FaeSlain++;
                if(player._FaeSlain >= 26)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    player._Score += 5000;
                    Processor.ProcessText("\nThe Fey Queen HELL MODE has been defeated!\nWell Done", 20);
                    Processor.ProcessText($"Congratulations, {player._Name}! You have beaten the tower and the Secret Boss\nFor the extra effort and skill, +5000 Points", 20);
                }
                else
                {
                    player._Score += 1000;
                    Processor.ProcessText("\nThe Fey Queen has been defeated!", 20);
                    Processor.ProcessText($"Congratulations, {player._Name}! You have beaten the tower +1000 Points", 20);                    
                }              
                
                Processor.ProcessText($"TOTAL FAERIES KILLED: {player._FaeSlain}", 10);
                Processor.ProcessText($"TOTAL POTIONS COLLECTED: {player._Potions}", 10);
                Processor.ProcessText($"TOTAL TRINKETS FOUND: {player._Trinkets}", 10);
                Processor.ProcessText($"TOTAL ARTIFACTS RECOVERED: {player._Artifacts}", 10);
                Processor.ProcessText($"TOTAL ROOMS CLEARED: {player._RoomsCleared}", 10);
                Processor.ProcessText($"TOTAL SCORE: {player._Score}", 10);
                string credits = "you win!";
                Room CreditRoom = new Room(credits);
                Console.ReadKey();
            }


        }
        static void Main(string[] args)
        {
            foreach (var item in TextStorage.three)
            {
                Console.WriteLine(item);
            }
       
            Thread.Sleep(1200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            foreach (var item in TextStorage.thing)
            {
                Console.WriteLine(item);
            }
            Thread.Sleep(1200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            foreach (var item in TextStorage.game)
            {
                Console.WriteLine(item);
            }
            Thread.Sleep(1200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            foreach (var item in TextStorage.threethinggame)
            {
                Console.WriteLine(item);
            }
            Thread.Sleep(1200);
            Console.Write("\n\n\n\n");

        EndOfGame2:
            Processor.ProcessText(TextStorage.IntroText, 20);

            Wizard player = new Wizard(Console.ReadLine());

            Processor.ProcessText(TextStorage.PostNameIntroP1, player._Name + ",", TextStorage.PostNameIntroP2, 20);
            Thread.Sleep(600);


            Processor.ProcessText("You have 30 floors ahead of you to clear.. they are filled with Items and Fae! You can get and fight everything in a room,\n" +
                                  "or you can skip it entirely. Every 5 floors has a cauldron. With this, you can heal yourself, increase your standing with\n" +
                                  "the gods(+35 mana), or increase your inventory to enable you to pick up more items.", 20);
        NewRoom:
            Random randy = new Random();

            //Rooms happen here
            //cauldron room
            if ((player._RoomsCleared + 1) % 5 == 0 && player._RoomsCleared != 29)
            {
                player._RoomsCleared++;
                bool b = false;
                Room CauldronRoom = new Room(b);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Processor.ProcessText("A cauldron room! You have choices, yes, choices! You can either:\n" +
                    "1. Increase your health by 150\n" +
                    "2. Increase your mana by 35\n" +
                    "3. Increase inventory space by 10\n", 10);
                WRONGCHOICE:
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        player._Health += 150;
                        break;
                    case "2":
                        player._Mana += 35;
                        break;
                    case "3":
                        TotalInventorySpace += 10;
                        break;
                    default:
                        Console.WriteLine("Wrong choice again. Or for the first time. This tower is timeless.");
                        goto WRONGCHOICE;
                    
                }
                Console.BackgroundColor = ConsoleColor.Black;
                goto NewRoom;

            }
            //boss room 
            else if (player._RoomsCleared == 29)
            {
                char c = '~';
                char d = '#';
                int version = 2;
                Room finalRoom;
                if(player._FaeSlain >= 25)
                {                    
                    finalRoom = new Room(d, version);
                }
                else
                {
                    finalRoom = new Room(c);
                }
                
                FinalCombat(ref player);
                if (Dead == false)
                {
                    string credits = "you win!";
                    Room CreditRoom = new Room(credits);
                }
                else
                {
                    if (Dead == true)
                    {
                        Processor.ProcessText($"TOTAL FAERIES KILLED: {player._FaeSlain}", 10);
                        Processor.ProcessText($"TOTAL POTIONS COLLECTED: {player._Potions}", 10);
                        Processor.ProcessText($"TOTAL TRINKETS FOUND: {player._Trinkets}", 10);
                        Processor.ProcessText($"TOTAL ARTIFACTS RECOVERED: {player._Artifacts}", 10);
                        Processor.ProcessText($"TOTAL ROOMS CLEARED: {player._RoomsCleared}", 10);
                        Processor.ProcessText($"TOTAL SCORE: {player._Score}", 10);
                        Console.ReadKey();

                        goto EndOfGame2;


                    }
                }
                
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
                Processor.ProcessText($"Score: {player._Score}","yellow" ,10);
                Processor.ProcessText($"Health: {player._Health}","green", 10);
                Processor.ProcessText($"Mana: {player._Mana}","blue" ,10);
                Processor.ProcessText($"Room Number: {player._RoomsCleared + 1}/30", 10);
                Processor.ProcessText($"Inventory Space: {player._InventorySlots}/{TotalInventorySpace}", 10);
                Processor.ProcessText(newRoomText, 10);
            RetakeRoomChoice:
                string choice = Console.ReadLine();
                
                if (choice == "r" || choice == "R")
                {
                    player._RoomsCleared++;
                    player._Mana+=5;
                    Processor.ProcessText("Heading to the next room. You gain +5 mana.",10);
                    Console.WriteLine("\n");

                    goto NewRoom;
                }
                if (!Char.IsDigit(Convert.ToChar(choice)))
                {
                    goto RetakeRoomChoice;
                }
                else if (NormalRoom.Contents.ContainsKey(Convert.ToInt32(choice)))
                {
                    if (NormalRoom.Contents[Convert.ToInt32(choice)].Contains("I"))
                    {

                        Random rand = new Random();
                        int result = rand.Next(3);
                        if (player._InventorySlots < TotalInventorySpace)
                        {
                            switch (result)
                            {
                                case 0:
                                    player._Score += 10;
                                    player._Potions++;
                                    player._InventorySlots++;
                                    player._Health += 5;
                                    Processor.ProcessText("You have found a potion! Plus 10 points! You take a sip and increase your health by 5.\n","cyan" ,10);
                                    Processor.ProcessText($"Inventory Space: {player._InventorySlots}/{TotalInventorySpace}", 10);
                                    Processor.ProcessText($"Score: {player._Score}","yellow" ,10);
                                    Processor.ProcessText($"Health: {player._Health}","green" ,10);
                                    break;
                                case 1:
                                    player._Score += 20;
                                    player._Trinkets++;
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found a trinket! Plus 20 points!\n","darkcyan" ,20);
                                    Processor.ProcessText($"Inventory Space: {player._InventorySlots}/{TotalInventorySpace}", 10);
                                    Processor.ProcessText($"Score: {player._Score}","yellow" ,10);
                                    break;
                                case 2:
                                    player._Score += 30;
                                    player._Artifacts++;
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found an artifact! Plus 30 point!\n","darkblue" ,30);
                                    Processor.ProcessText($"Inventory Space: {player._InventorySlots}/{TotalInventorySpace}", 10);
                                    Processor.ProcessText($"Score: {player._Score}", "yellow",10);
                                    break;
                                default:
                                    player._Score += 5;
                             
                                    player._InventorySlots++;
                                    Processor.ProcessText("You have found an marble! Plus 5 points!\n", "cyan", 30);
                                    Processor.ProcessText($"Inventory Space: {player._InventorySlots}/{TotalInventorySpace}", 10);
                                    Processor.ProcessText($"Score: {player._Score}", "yellow", 10);
                                    break;
                            }
                            NormalRoom.Contents.Remove(Convert.ToInt32(choice));
                            PrintOptions(NormalRoom);
                            goto RetakeRoomChoice;
                        }
                        else
                        {
                            Processor.ProcessText("You are over encumbered! Woopsie, no item for you.\n","red",10);
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
                                faeHP = 40;
                                break;
                            case 1:
                                faeHP = 80;
                                break;
                            case 2:
                                faeHP = 120;
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
                            Processor.ProcessText($"TOTAL FAERIES KILLED: {player._FaeSlain}", 10);
                            Processor.ProcessText($"TOTAL POTIONS COLLECTED: {player._Potions}", 10);
                            Processor.ProcessText($"TOTAL TRINKETS FOUND: {player._Trinkets}", 10);
                            Processor.ProcessText($"TOTAL ARTIFACTS RECOVERED: {player._Artifacts}", 10);
                            Processor.ProcessText($"TOTAL ROOMS CLEARED: {player._RoomsCleared}", 10);
                            Processor.ProcessText($"TOTAL SCORE: {player._Score}", "yellow",10);
                            Console.ReadKey();
                            
                             goto EndOfGame2;
                            
                        
                        }
                        NormalRoom.Contents.Remove(Convert.ToInt32(choice));
                        PrintOptions(NormalRoom);
                        goto RetakeRoomChoice;
                    }

                }
                else
                {
                    Processor.ProcessText("Wrong, take a listed choice.", "red", 10);
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
            Processor.ProcessText("r. Next room", 10);
        }
    }
}
