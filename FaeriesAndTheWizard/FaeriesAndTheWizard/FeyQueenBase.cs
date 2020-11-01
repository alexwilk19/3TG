using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    class FeyQueenBase
    {
        internal int _Health = 1000;
        virtual internal int WildCardHeal()
        {
            return 0;
        }
        virtual internal int Meditate()
        {
            return 0;
        }
        virtual internal int Strike()
        {
            return 0;
        }
        virtual internal int WildDust()
        {
            return 0;
        }
        virtual internal int AuroraAura()
        {
            return 0;
        }
    }
}
