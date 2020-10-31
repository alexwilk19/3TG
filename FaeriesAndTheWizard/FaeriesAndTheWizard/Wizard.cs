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
        internal int _Health;
        internal Wizard(string name)
        {
            _Score = 0;
            _Name = name;
            _RoomsCleared = 0;
            _Health = 200;
        }

        Random rand = new Random();

        internal int Fireball()
        {
            int damage = rand.Next(1, 100);
            if(rand.NextDouble() < 0.1)
            {
                _Health -= (damage / 2);
                Processor.ProcessText($"You got caught in the fireball and took {damage} points of damage", 10);
                return 0;
            }
            Processor.ProcessText($"You launch a fireball and hit the fae, you deal {damage} points of damage", 10);
            return damage;
        }

        internal int StaffSmack()
        {
            int damage = rand.Next(10, 20);
            Processor.ProcessText($"You cast staff, and hit the fae with your staff, dealing {damage} points of damage", 10);
            return damage;
        }

        internal int IcicleSpear()
        {
            int damage = 30;
            if(rand.NextDouble() < 0.2)
            {
                damage = (damage * 2);
                Processor.ProcessText($"You fire an icicle spear\nCRITICAL HIT! You deal {damage} points of damage", 10);
            }
            if(rand.NextDouble() > 0.2 && rand.NextDouble() < 0.4)
            {
                damage = 0;
                Processor.ProcessText($"You fire an icicle spear\nYou miss, no damage dealt", 10);
            }
            else
            {
                Processor.ProcessText($"You fire an icicle spear\nHit, you deal {damage} points of damage", 10);
            }
            

            return damage;
        }
    }
}
