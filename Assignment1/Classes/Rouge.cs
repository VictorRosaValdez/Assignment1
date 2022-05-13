using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Rouge : Character
    {
        // Constructor
        public Rouge(string name) : base(name, 1, 2, 6, 1, 1.06)
        {
            CharacterName = name;
       

        }

        /*
         * Every time a rouge levels up, they gain: 
         * Strenght 1
         * Dexterity 4
         * Intelligence 1
        
        */
        public override void IncreaseLevel()
        {

            CharacterLevel++;
            Strength++;
            Dexterity += 4;
            Intelligence++;


        }

        /*
      Determines the characters ability to attack with speed and nimbleness.
      Each point of dexterity increase a rogues damage by 1%.

      */

        // Override abstract method to calculate character damage
        public override double CharacterDamage(int level, bool weaponEquipped, bool armorEquipped)
        {
            // With weapon and armor level 1
            if (CharacterLevel == level && weaponEquipped == true && armorEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + ((Dexterity + 1.00) / 100.00));
            }

            // With weapon level 1
            else if (CharacterLevel == level && weaponEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + (Dexterity / 100.00));
            }
            // Without weapon level 1
            if (CharacterLevel == level && weaponEquipped == false)
            {
                return Damage = 1.00 * (1.00 + (Dexterity / 100.00));
            }




            return Damage;
        }

        // Overrride abstract method to choose weapon
        public override void ChooseWeapon()
        {


        }

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }

    }
}
