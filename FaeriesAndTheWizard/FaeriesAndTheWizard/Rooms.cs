using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    public class Room
    {

        public Dictionary<int, string> Contents = new Dictionary<int, string>();
        internal Room(int id)
        {

            Random rand = new Random();
            int itemNumber = 0;
            int variableCount = 0;
            string PFoe = "Fight Faerie";
            string PItem = "Unknown Item";
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
                            if (col == 18)
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
                                if (rand.Next(95) == 0)
                                {
                                    if (rand.Next(3) == 0)
                                    {
                                        variableCount++;
                                        if (variableCount < 9)
                                        {
                                            itemNumber++;
                                            col++;
                                            col++;

                                            Console.Write($"X{itemNumber}");
                                            Contents.Add(itemNumber, PFoe);
                                            Console.Write(" ");
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                      
                                    }
                                    else
                                    {
                                        variableCount++;
                                        if (variableCount < 9)
                                        {
                                            itemNumber++;
                                            col++;
                                            col++;

                                            Console.Write($"I{itemNumber}");
                                            Contents.Add(itemNumber, PItem);
                                            Console.Write(" ");
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }

                            }

                        }
                    }
                }
                Console.Write("\n");

            }
        }
        internal Room(bool b)
        {
            Processor.PresentOptions(TextStorage.CauldronLevel);
        }

        internal Room(char c)
        {
            Processor.ProcessText("Aha, the big one! Imagine how many spells you can cast if you chop off her wings and turn them into potions!\n" +
                                  "But she will put up quite the fight, and you had better be prepared. She has a lot of health, but if you can\n" +
                                  "pull this off, then those damned faeries will leave you alone!", 10);
            Processor.PresentOptions(TextStorage.BossFloor);
        }
        internal Room(char c, int ver)
        {            
            Processor.ProcessText("Aha, the big one! Imagine how many spells you can cast if you chop off her wings and turn them into potions!\n" +
                                   "But something seems....off\nShe feels much more powerful than you first thought\nPrepare for a very\nvery\nvery hard fight", 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Processor.PresentOptions(TextStorage.BossFloorHard);
        }

        internal Room(string credits)
        {
            Processor.PresentOptions(TextStorage.CreditRoom);
        }
    }
    internal class Rooms
    {
        public Room Training;
        internal Rooms(int i)
        {
            Training = new Room(i);
        }

    }
}
