using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class HellFae : FeyQueenBase
    {
        new internal int _Health = 1850;
        internal Random rand = new Random();

        override internal int WildCardHeal()
        {
            int playerHealthMod = 0;
            int baseDamage = 15;

            if (rand.NextDouble() < 33.3)
            {
                int critMod = (rand.Next(2, 5));
                baseDamage = (baseDamage * critMod);
                Processor.ProcessText($"Critical! {critMod}x Damage!", 10);
            }
            
            int wildCard = rand.Next(1, 100);
            if (wildCard % 2 == 0)
            {
                //player heal
                playerHealthMod = -baseDamage;
                _Health -= baseDamage;
                Processor.ProcessText($"The Fey Queen is radiating the chaos of the Fey Wilds\nYou recover {baseDamage} health and The Fey Queen takes {baseDamage} damage", 10);
            }
            else
            {
                //boss heal
                baseDamage = (baseDamage * 2);
                playerHealthMod = baseDamage;
                _Health += baseDamage;
                Processor.ProcessText($"The Fey Queen is radiating the chaos of the Fey Wilds\nYou take {baseDamage} damage and The Fey Queen recovers {baseDamage} health", 10);
            }

            return playerHealthMod;
        }

        override internal int Meditate()
        {
            int heal = rand.Next(10, 50);
            heal = (heal * 2);
            _Health += heal;

            Processor.ProcessText($"The Fey Queen Meditates and recovers {heal} health", 10);
            return 0;
        }

        override internal int Strike()
        {
            int damage = rand.Next(5, 45);
            damage = (damage * 2);
            Processor.ProcessText($"The Fey Queen strikes you with blunt force, you take {damage} damage", 10);
            return damage;
        }

        override internal int WildDust()
        {
            int healthMod = rand.Next(-50, 50);
            if (healthMod < 0)
            {
                healthMod = (healthMod / 2);
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\nYou are healed by {-(healthMod)} health", 10);
            }
            else if (healthMod > 0)
            {
                healthMod = (healthMod * 2);
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\nYou take {healthMod} damage", 10);
            }
            else if (healthMod == 0)
            {
                
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\n...\nNothing happens!", 10);
            }
            else
            {
                Processor.ProcessText($"i have no clue what happened", 10);
            }
            return healthMod;
        }

        override internal int AuroraAura()
        {
            //randomness
            int damage = rand.Next(10, 60);
            int selfDamage = rand.Next(20, 50);
            damage = (damage * 2);
            selfDamage = (selfDamage / 2);
            _Health -= selfDamage;
            Processor.ProcessText($"The Fey Queen emmits a powerful Aurora of Magic\nYou take {damage} points of damage and The Fey Queen takes {selfDamage} points of damage", 10);
            return damage;
        }
    }
}
