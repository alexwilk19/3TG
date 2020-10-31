using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    internal class Item
    {
        internal Item(int pInvId, int[] pIntArray, bool[] pBoolArray, string pDesctiption)
        {
            invID = pInvId;
            damageBoost = pIntArray[0];
            damageReduction = pIntArray[1];
            healAmount = pIntArray[2];

            isConsumable = pBoolArray[0];
            isKey = pBoolArray[1];
        }
        internal int invID;
        internal int damageBoost;
        internal int damageReduction;
        internal int healAmount;
        
        internal bool isConsumable;
        internal bool isKey;
        
        internal string description;

    }

    internal class InitialiseItems
    {
        internal Item InitialiseItems(int pItemID, int pInvID)
        {
            int[] itemIntArray;
            bool[] itemBoolArray;
            string description = "";
            if(pItemID == 1)
            {
                itemIntArray = new int[] {10, 0, 0};
                itemBoolArray = new bool[] { true, false };
                description = "A Damage Boosting Potion";
            }

            return new Item(pInvID, itemIntArray, itemBoolArray, description);
        }
    }
}
