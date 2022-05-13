using Assignment1.Custom_Exceptions;
using Assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Armor : Item
    {
        // Attributes
        private ArmorType armorType;

        // Properties
        public ArmorType WeaponType { get { return armorType; } set { armorType = value; } }
        public int Damage { get; set; }

        // Empty constructor
        public Armor()
        {

        }

        // Overloaded constructor
        public Armor(string name, int requiredLevel, int slot) : base()
        {

            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }

        /// <summary>
        /// Method to check of the armor is allowed for the character.
        /// The arguments are two strings with the character and armor name.
        /// The armor name must be identical to the enum value.
        /// </summary>
        /// <param name="nameCharacter"></param>
        /// <param name="armorName"></param>
        /// <returns>String: Can or can not use this armor.</returns>

        // Override method NotAllowedForCharacter check of the armor is allowed for the character.
        public override string NotAllowedForCharacter(string nameCharacter, string armorName)
        {
            // Custom Exception invalid armor
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
                if (ArmorType.Cloth.ToString() == armorName)
                {
                    ArmorCanBeEquipped = true;
                    return "Mage can use this Armor";
                }

          
                else
                {
                    return "Mage can not use this Armor";
                }

            }
            // Check for ranger
            if (nameCharacter.ToLower() == "ranger")
            {
                if (ArmorType.Leather.ToString() == armorName || ArmorType.Mail.ToString() == armorName)
                {
                    ArmorCanBeEquipped = true;
                    return "Ranger can use this weapon";
                }

                else
                {
                    return "Ranger can not use this Armor";
                }
            }

            // Check for rouges
            if (nameCharacter.ToLower() == "rouges")
            {
                if (ArmorType.Leather.ToString() == armorName || ArmorType.Mail.ToString() == armorName)
                {
                    ArmorCanBeEquipped = true;
                    return "Rouges can use this weapon";

                }
              
                else
                {
                    return "Rouges can not use this Armor";
                }
            }


            // Check for Warrior
            if (nameCharacter.ToLower() == "warrior")
            {
                if (ArmorType.Mail.ToString() == armorName || ArmorType.Plate.ToString() == armorName)
                {
                    ArmorCanBeEquipped = true;
                    return "Warrior can use this Armor";
                }


                else
                {
                    return "Warrior can not use this Armor";
                }

            }


            return "Invalid name, use one of these names: Mage, Ranger, Rouges or Warrior";
        }

        /// <summary>
        /// Method to add armor. The arguments are two strings with character and armor name.
        /// This method also has the check method of armor is allowed.
        /// The armor name must be identical to the enum value.
        /// </summary>
        /// <param name="nameCharacter"></param>
        /// <param name="armorName"></param>
        /// <returns>String: New armor equipped or you can not add this armor.</returns>
        // Override method to add armor.
        public override string AddItem(string nameCharacter, string armorName)
        {
            // Use method to check of the weapon can be added.
            NotAllowedForCharacter(nameCharacter, armorName);
            if (!ArmorCanBeEquipped)
                return "You can not add this Armor.";
                
            Item newArmor = new Weapon(armorName, 1, 1);

            return "New armor equipped!";
        }
        /// <summary>
        /// Customs exceptions invalid weapon.
        /// </summary>
        /// <param name="throwException"></param>
        /// <exception cref="InvalidArmorException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static void TestException(bool throwException)
        {

            if (throwException)
                throw new InvalidArmorException();

            throw new IndexOutOfRangeException();
        }
    }
}
