using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollForInitiative.Data
{
    public class Combatant
    {
        public string Name { get; private set; }
        public int HitPointsCurrent { get; private set; }
        public int HitPointsMax { get; private set; }
        public int InitiativeBonus { get; private set; }

        public float InitiativeCurrent { get; private set; }
        public int ArmorClass { get; private set; }

        public Combatant(string name, int hitPointsCurrent, int hitPointsMax, int initiativeBonus, int armorClass)
        {
            Name = name;
            HitPointsCurrent = hitPointsCurrent;
            HitPointsMax = hitPointsMax;
            InitiativeBonus = initiativeBonus;
            ArmorClass = armorClass;
        }
    }
}