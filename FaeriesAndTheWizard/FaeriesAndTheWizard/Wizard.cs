using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    internal class Wizard
    {
        internal string _Name;
        internal int _Score;
        internal int _RoomsCleared;

        internal Wizard(string name)
        {
            _Score = 0;
            _Name = name;
            _RoomsCleared = 0;
        }
    }
}
