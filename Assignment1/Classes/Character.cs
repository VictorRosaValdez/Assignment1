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
        public double Strenth { get; set; }

        public string Dexterity { get; set; }

        public double Intelligence { get; set; }

        public double Damage { get; set; }


        // Constructor of the class
       public Character()
        {


        }

        // Overloading the constructor
       public Character(string name, int level, double strenth, string dexterity, double intelligence, double damage )
        {
            this.CharacterName = name;
            this.CharacterLevel = level;
            this.Strenth = strenth;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Damage = damage;
        }



        // Abstract metho to increase level
        public abstract string IncreaseLevel(int level);
        public override string ToString()
        {
            return "Name: " + this.CharacterName + "Level:" + this.CharacterLevel + "Strenth:" + this.Strenth + "Dexterity:" + this.Dexterity + "Intelligence:" + this.Intelligence + "Damage:" + this.Damage;
        }





    }
}
