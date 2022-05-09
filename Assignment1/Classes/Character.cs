using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    // Making tha base class of Character abstract
    abstract class Character
    {

        // Properties of Character
        public string CharacterName { get; set; }
        public int CharacterLevel { get; set; } = 1;
        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Intelligence { get; set; }

        public double Damage { get; set; }

        public string BasePrimaryAttributes { get; set; }

        public string TotalPrimaryAttributes { get; set; }


        // Constructor of the class
        public Character()
        {


        }

        // Overloading the constructor
        public Character(string name, int level, int strenth, int dexterity, int intelligence, double damage)
        {
            this.CharacterName = name;
            this.CharacterLevel = level;
            this.Strength = strenth;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Damage = damage;
        }



        // Abstract metho to increase level
        public abstract void IncreaseLevel(int level);
        public override string ToString()
        {
            return ($"Name: {this.CharacterName} Level: {this.CharacterLevel} Strength: {this.Strength} Dexterity: {this.Dexterity} Intelligence: {this.Intelligence} Damage: {this.Damage}");
        }


    }
}
