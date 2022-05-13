using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public abstract class Item
    {


        //Properties
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public int Slot { get; set; }
        public bool WeaponCanBeEquipped { get; set; }
        public bool ArmorCanBeEquipped { get; set; }

        // Empty constructor
        public Item()
        {

        }

        // Overloaded constructor
        public Item(string name, int requiredLevel, int slot) { 
        
            this.Name = name;
            this.RequiredLevel = requiredLevel;
            this.Slot = slot;
        
        }
        // Abstract method to check if the character can use the item.
        public abstract string NotAllowedForCharacter(string nameCharacter, string itemName);

        // Abstract method to add item.
        public abstract string AddItem(string nameCharacter, string weaponName);


        //Override method to get the object values to string
        public override string ToString()
        {
            return ($"Name: {this.Name} Required level: {this.RequiredLevel} Slot: {this.Slot}");
        }

    }
}
