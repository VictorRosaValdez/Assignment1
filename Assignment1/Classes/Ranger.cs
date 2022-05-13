using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Ranger : Character
    {
        // Constructor
        public Ranger(string name) : base(name, 1, 1, 7, 1, 1.07 )
        {
            CharacterName = name;


        }


        /// <summary>
        /// Every time a ranger levels up, they gain: Strenght 1, Dexterity 5, Intelligence 1
        /// </summary>

        // Override abstract method to increase level.
        public override void IncreaseLevel()
        {

            CharacterLevel++;
            Strength++;
            Dexterity += 5;
            Intelligence++;

           
        }

        /// <summary>
        /// Calculate the damage a character can do. They have 3 options:
        ///  1: With weapon and armor.
        ///  2: With weapon.
        ///  3: Without weapon.
        ///  The level is 1.
        ///  Determines the physical strength of the character each point of dexterity increase a rangers damage by 1%.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="weaponEquipped"></param>
        /// <param name="armorEquipped"></param>
        /// <returns>Double:The value of damage the character can do.</returns>

        // Override abstract method to calculate character damage.
        public override double CharacterDamage(int level, bool weaponEquipped, bool armorEquipped)
        {
            // With weapon and armor level 1
            if (CharacterLevel == level && weaponEquipped == true && armorEquipped == true)
            {
                return Damage = (Dexterity * 1.10) * (1.00 + (( + 1.00) / 100.00));
            }

            // With weapon level 1
            else if (CharacterLevel == level && weaponEquipped == true)
            {
                return Damage = (Dexterity * 1.10) * (1.00 + (7 / 100.00));
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

        /*
       Determines the characters ability to attack with speed and nimbleness.
       Each point of dexterity increase a rangers damage by 1%.

       */

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }
    }
}
