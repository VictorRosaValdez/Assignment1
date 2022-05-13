using Assignment1.Custom_Exceptions;
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
      
        // Properties
        public WeaponType WeaponType { get { return weaponType; } set { weaponType = value; } }
        public int Damage { get; set; }

        // Empty constructor
        public Weapon()
        {

        }
        // Overloaded constructor
        public Weapon(string name, int requiredLevel, int slot) : base ()
        {

            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }

        /// <summary>
        /// Method to check of the weapon is allowed for the character.
        /// The arguments are two strings with the character and weapon name.
        /// The weapon name must be identical to the enum value.
        /// </summary>
        /// <param name="nameCharacter"></param>
        /// <param name="weaponName"></param>
        /// <returns>String: Can or can not use this weapon.</returns>

        // Override method NotAllowedForCharacter check of the weapon is allowed for the character.
        public override string NotAllowedForCharacter(string nameCharacter, string weaponName)
        {
            // Custom Exception invalid weapon
            try
            {
                TestException(false);
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine("Custom exception: " + ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception: " + ex.Message);
            }

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

        /// <summary>
        /// Method to add weapon. The arguments are two strings with character and weapon name.
        /// This method also has the check method of weapon is allowed.
        /// The weapon name must be identical to the enum value.
        /// </summary>
        /// <param name="nameCharacter"></param>
        /// <param name="weaponName"></param>
        /// <returns>String: New weapon equipped or you can not add this weapon.</returns>

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



        /// <summary>
        /// Customs exceptions invalid weapon.
        /// </summary>
        /// <param name="throwException"></param>
        /// <exception cref="InvalidWeaponException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static void TestException(bool throwException)
        {

            if (throwException)
                throw new InvalidWeaponException();

            throw new IndexOutOfRangeException();
        }
        /*
         * Calculate the weapon damage
        */
        public double DPS(double attackSpeed)
        {
            string weapon = WeaponType.Axes.ToString();


            return Damage * attackSpeed;
        }

    }
}
