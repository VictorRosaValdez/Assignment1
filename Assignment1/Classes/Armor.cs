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

        // Dictionary
        private Dictionary<string, string> WeaponsIventory = new Dictionary<string, string>();

        // Properties
        public ArmorType WeaponType { get { return armorType; } set { armorType = value; } }
        public int Damage { get; set; }

        public Armor()
        {

        }
        public Armor(string name, int requiredLevel, int slot) : base()
        {

            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }


        // Override method NotAllowedForCharacter check of the armor is allowed for the character.
        public override string NotAllowedForCharacter(string nameCharacter, string armorName)
        {

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
    }
}
