using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public abstract class Character
    {

        // Properties of Character
        public string CharacterName { get; set; }
        public int CharacterLevel { get; set; }
        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Intelligence { get; set; }

        public double Damage { get; set; }

        // Slot

        public string BasePrimaryAttributes { get; set; }

        public string TotalPrimaryAttributes { get; set; }


        // Empty constructor
        public Character()
        {


        }

        // Overloaded constructor
        public Character(string name, int level, int strenth, int dexterity, int intelligence, double damage)
        {
            this.CharacterName = name;
            this.CharacterLevel = level;
            this.Strength = strenth;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Damage = damage;
        }



        // Abstract method to increase level.
        public abstract void IncreaseLevel();


        // Abstract method to chose weapon.
        public abstract void ChooseWeapon();

        // Abstract method to calculate character damage.
        public abstract double CharacterDamage(int level,bool weaponEquipped, bool armorEquipped);

        //Override method to get the object values to string
        public override string ToString()
        {
            return ($"Name: {this.CharacterName} \nLevel: {this.CharacterLevel} \nStrength: {this.Strength} \nDexterity: {this.Dexterity} \nIntelligence: {this.Intelligence} \nDamage: {this.Damage}");
        }


    }
}
