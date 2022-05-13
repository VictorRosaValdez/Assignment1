using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Warrior : Character
    {
        

        // Constructor
        public Warrior(string name) : base(name, 1, 5, 2, 1, 1.05)
        {
            CharacterName = name;
           

        }

        /*
         * Every time a warrior levels up, they gain: 
         * Strenght 1
         * Dexterity 1
         * Intelligence 5
        
        */
        public override void IncreaseLevel()
        {

            CharacterLevel++;
            Strength += 3;
            Dexterity += 2;
            Intelligence++;

        }


        /*
        Determines the physical strength of the character
        Each point of strength increase a warriors damage by 1%
          
        */

        // Override abstract method to calculate character damage
        public override double CharacterDamage(int level, bool weaponEquipped, bool armorEquipped)
        {
            // With weapon and armor level 1
            if(CharacterLevel == level && weaponEquipped == true && armorEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + ((Strength + 1.00) / 100.00));
            }

             // With weapon level 1
            else if (CharacterLevel == level && weaponEquipped == true)
            {
                return Damage = (7.00 * 1.10) * (1.00 + (Strength / 100.00));
            }
            // Without weapon level 1
            if (CharacterLevel == level && weaponEquipped == false)
            {
               return Damage = 1.00 * (1.00 + (Strength / 100.00));
            }
           

           

           return Damage;
        }

        // Overrride abstract method to choose weapon
        public override void ChooseWeapon()
        {


        }

        public void StrengthWarrior()
        {

            Strength = (int)(Strength * 0.01);

        }

        
    }
}
