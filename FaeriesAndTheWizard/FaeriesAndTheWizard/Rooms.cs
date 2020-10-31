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
        internal void PrintRoom()
        {

        }
        Dictionary<int, object> Contents = new Dictionary<int, object>();
        internal Room(int id)
        {
            
            Random rand = new Random();
            int itemNumber = 0;
            string PFoe = "Possible Foe";
            string PItem = "Possible Item";
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
                                        itemNumber++;
                                        col++;
                                        col++;
                                        Console.Write($"X{itemNumber}");
                                        Contents.Add(itemNumber, PFoe);
                                        Console.Write(" ");
                                    }
                                    else
                                    {
                                        itemNumber++;
                                        col++;
                                        col++;
                                        Console.Write($"I{itemNumber}");
                                        Contents.Add(itemNumber, PItem);
                                        Console.Write(" ");
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
