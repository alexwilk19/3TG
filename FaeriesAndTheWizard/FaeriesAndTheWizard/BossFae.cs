using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class BossFae
    {
        internal int _Health = 1000;
        internal Random rand = new Random();

        internal int WildCardHeal()
        {
            int playerHealthMod = 0;
            int baseDamage = 15;

            if(rand.NextDouble() < 33.3)
            {
                int critMod = (rand.Next(2, 5));
                baseDamage = (baseDamage * critMod);
                Processor.ProcessText($"Critical! {critMod}x Damage!", 10);
            }            

            int wildCard = rand.Next(1, 100);
            if(wildCard % 2 == 0)
            {
                //player heal
                playerHealthMod = -baseDamage;
                _Health -= baseDamage;
                Processor.ProcessText($"The Fey Queen is radiating the chaos of the Fey Wilds\nYou recover {baseDamage} health and The Fey Queen takes {baseDamage} damage", 10);
            }
            else
            {
                //boss heal
                playerHealthMod = baseDamage;
                _Health += baseDamage;
                Processor.ProcessText($"The Fey Queen is radiating the chaos of the Fey Wilds\nYou take {baseDamage} damage and The Fey Queen recovers {baseDamage} health", 10);
            }

            return playerHealthMod;
        }        

        internal int Meditate()
        {
            int heal = rand.Next(10, 50);
            _Health += heal;

            Processor.ProcessText($"The Fey Queen Meditates and recovers {heal} health", 10);
            return 0;
        }

        internal int Strike()
        {
            int damage = rand.Next(5, 45);
            Processor.ProcessText($"The Fey Queen strikes you with blunt force, you take {damage} damage", 10);
            return damage;
        }

        internal int WildDust()
        {
            int healthMod = rand.Next(-50, 50);
            if(healthMod < 0)
            {
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\nYou are healed by {-(healthMod)} health", 10);
            }
            else if(healthMod > 0)
            {
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\nYou take {healthMod} damage", 10);
            }
            else if(healthMod == 0)
            {
                Processor.ProcessText($"The Fey Queen sprinkles fae dust over you\n...\nNothing happens!", 10);
            }
            else
            {
                Processor.ProcessText($"i have no clue what happened", 10);
            }
            return healthMod;
        }

        internal int AuroraAura()
        {
            int damage = rand.Next(10, 60);
            int selfDamage = rand.Next(20, 50);
            _Health -= selfDamage;
            Processor.ProcessText($"The Fey Queen emmits a powerful Aurora of Magic\nYou take {damage} points of damage and The Fey Queen takes {selfDamage} points of damage", 10);
            return damage;
        }
    }
}
