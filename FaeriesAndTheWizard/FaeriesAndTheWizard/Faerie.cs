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

        Random rand = new Random();

        internal int Swipe()
        {
            Processor.ProcessText($"The fae swipes at you for {(_Damage / 2)} points of damage", 10);
            return (_Damage / 2);
        }

        internal int MagicBlast()
        {
            int finalDamage = ((_Damage * 3) / (rand.Next(2,4)));
            Processor.ProcessText($"The fae blasts you with magic, dealing {finalDamage} points of Damage", 10);
            return finalDamage;
        }
    }
}
