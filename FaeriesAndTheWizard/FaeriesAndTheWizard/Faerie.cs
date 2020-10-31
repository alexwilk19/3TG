using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{

    internal class Faerie
    {
        internal int _Health;
        internal int _Damage;
        internal int _Score;

        internal Faerie(int pHealth, int pDamage)
        {
            _Health = pHealth;
            _Damage = pDamage;

            _Score = ((_Health + _Damage) / 2);
        }
    }
}
