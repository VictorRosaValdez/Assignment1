using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    abstract class Item
    {

        //Properties
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public int Slot { get; set; }

        public Item()
        {

        }

        // Constructor
        public Item(string name, int requiredLevel, int slot) { 
        
            this.Name = name;
            this.RequiredLevel = requiredLevel;
            this.Slot = slot;
        
        }

        public abstract string NotAllowedForCharacter();


        //Override method convert the object to string
        public override string ToString()
        {
            return ($"Name: {this.Name} Required level: {this.RequiredLevel} Slot: {this.Slot}");
        }

    }
}
