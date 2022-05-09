using Assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Weapon : Item
    {
        private WeaponType weaponType;
        public WeaponType WeaponType { get { return weaponType; } set { weaponType = value; } }

        public Weapon(WeaponType name, int requiredLevel, int slot) : base ()
        {

            this.WeaponType = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }

    }
}
