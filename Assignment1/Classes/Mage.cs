using Assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Mage : Character
    {
    
        // Constructor
        public Mage(string name) : base(name, 1, 1, 1, 8, 1.08)
        {
            CharacterName = name;


        }



        /// <summary>
        /// Every time a mage levels up, they gain: Strenght 1, Dexterity 1, Intelligence 5.
        /// </summary>

        // Override abstract method to increase level.
        public override void IncreaseLevel()
        {
            CharacterLevel++;
            Strength++;
            Dexterity++;
            Intelligence += 5;

            

        }


        // Overrride abstract method to choose weapon
        public override void ChooseWeapon()
        {
           /* foreach (var item in Enum.GetValues(typeof(WeaponType))) ;
            {
                Console.WriteLine(weaponMage);
            }
           */

        }

        /// <summary>
        /// Calculate the damage a character can do. They have 3 options:
        ///  1: With weapon and armor.
        ///  2: With weapon.
        ///  3: Without weapon.
        ///  The level is 1.
        ///  Determines the physical strength of the character each point of intelligence increase a mages damage by 1%.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="weaponEquipped"></param>
        /// <param name="armorEquipped"></param>
        /// <returns>Double:The value of damage the character can do.</returns>

        // Override abstract method to calculate character damage
        public override double CharacterDamage(int level, bool weaponEquipped, bool armorEquipped)
        {
            // With weapon and armor level 1
            if (CharacterLevel == level && weaponEquipped == true && armorEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + ((Intelligence + 1.00) / 100.00));
            }

            // With weapon level 1
            else if (CharacterLevel == level && weaponEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + (Intelligence / 100.00));
            }
            // Without weapon level 1
            if (CharacterLevel == level && weaponEquipped == false)
            {
                return Damage = 1.00 * (1.00 + (Intelligence / 100.00));
            }




            return Damage;
        }

        /*
    Determines the characters affinity with magic.
    Each point of intelligence increase a mages damage by 1%.

    */

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }
    }
}
