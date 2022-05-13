using Assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Weapon : Item
    {
        // Attributes
        private WeaponType weaponType;

        // Dictionary
        private Dictionary<string, string> WeaponsIventory = new Dictionary<string, string>();
      
        
        public WeaponType WeaponType { get { return weaponType; } set { weaponType = value; } }
        public int Damage { get; set; }

        public Weapon()
        {

        }

        public Weapon(string name, int requiredLevel, int slot) : base ()
        {

            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }


        // Override method NotAllowedForCharacter check of the weapon is allowed for the character.
        public override string NotAllowedForCharacter(string nameCharacter, string weaponName)
        {
           
            

            // Check for mage
            if (nameCharacter.ToLower() == "mage")
            {
                if(WeaponType.Staffs.ToString() == weaponName) 
                {
                    WeaponCanBeEquipped = true;
                    return "Mage can use this weapon";
                }

                else if(WeaponType.Wands.ToString() == weaponName) 
                {
                    WeaponCanBeEquipped = true;
                    return "Mage can use this weapon";

                }
                else
                {
                    return "Mage can not use this weapon";
                }

            }
            // Check for ranger
            if (nameCharacter.ToLower() == "ranger")
            {
                if (WeaponType.Bows.ToString() == weaponName)
                {
                    WeaponCanBeEquipped = true;
                    return "Ranger can use this weapon";
                }

                else
                {
                    return "Ranger can not use this weapon";
                }
            }

            // Check for rouges
            if (nameCharacter.ToLower() == "rouges")
            {
                if (WeaponType.Daggers.ToString() == weaponName)
                {
                    WeaponCanBeEquipped = true;
                    return "Rouges can use this weapon";

                }
                else if (WeaponType.Swords.ToString() == weaponName)
                {
                    WeaponCanBeEquipped = true;
                    return "Rouges can use this weapon";
                }
                else
                {
                    return "Rouges can not use this weapon";
                }
            }


            // Check for Warrior
            if (nameCharacter.ToLower() == "warrior" )
            {
                if (WeaponType.Axes.ToString() == weaponName)
                {
                    WeaponCanBeEquipped = true;
                    return "Warrior can use this weapon";
                }

                else if (WeaponType.Hammers.ToString() == weaponName || WeaponType.Swords.ToString() == weaponName)
                {
                    WeaponCanBeEquipped = true;
                    return "Warrior can use this weapon";
                }

                else
                {
                    return "Warrior can not use this weapon";
                }
                
            }


            return "Invalid name, use one of these names: Mage, Ranger, Rouges or Warrior";
        }

        // Override method to add weapon.
        public override string AddItem(string nameCharacter, string weaponName)
        {
            // Use method to check of the weapon can be added.
            NotAllowedForCharacter(nameCharacter, weaponName);
            if (!WeaponCanBeEquipped)
                return "You can not add this weapon.";
            
               
            Item newWeapond = new Weapon(weaponName, 1, 1);
            return "New weapon equipped!";
        }

        /*
         * Calculate the weapon damage
        */
        public double DPS(double attckSpeed)
        {
            string weapon = WeaponType.Axes.ToString();


            return Damage * attckSpeed;
        }

    }
}
