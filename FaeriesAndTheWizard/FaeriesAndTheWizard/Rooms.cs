using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    public class Room
    {
        Dictionary<int, string> Contents = new Dictionary<int, string>();
        internal Room(int id)
        {
            string[,] DrawRoom = new string[20, 20];
            for (int i = 0; i < DrawRoom.GetLength(0); i++)
            {
                for (int x = 0; x < DrawRoom.GetLength(1); x++)
                {
                    if (i == 0)
                    {
                        if (x == 0 || x == 19)
                        {

                        }
                    }
                }
                Console.Write("-");
            }
        }
       

    }
    internal class Rooms
    {
        Room Training;
        internal Rooms(int i)
        {
            Training = new Room(i);
        }
      
    }
}
