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
        internal int _Potions;
        internal int _Trinkets;
        internal int _Artifacts;
        internal int _InventorySlots;
        internal int _RoomsCleared;
        internal int _Health;
        internal int _FaeSlain;
        internal int _Mana;
        internal Wizard(string name)
        {
            _Score = 0;
            _Name = name;
            _RoomsCleared = 0;
            _Health = 200;
            _Potions = 0;
            _Artifacts = 0;
            _Trinkets = 0;
            _InventorySlots = 0;
            _FaeSlain = 0;
            _Mana = 50;
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

        internal int ManaDrain()
        {
            _Mana += 20;
            int damage = 5;
            Processor.ProcessText($"You grab hold of the fae with your magic, and slowly drain the mana from them - knowing just how to make it as painful for them as possible\nYou deal {damage} points of damage", 10);
            return damage;
        }

        internal int TimeFreeze()
        {
            int damage = 25;
            Processor.ProcessText($"You tell the Fae that it is TIME TO STOP, dealing {damage} points of damage and preventing the Faerie from attacking on this turn.", 10);
            return damage;
        }
    }
}
