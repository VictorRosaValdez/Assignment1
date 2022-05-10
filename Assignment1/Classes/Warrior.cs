using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Warrior : Character
    {
        // Overloading the constructor
        public Warrior(string name, int level, int strenth, int dexterity, int intelligence, double damage) : base()
        {
            CharacterName = name;
            CharacterLevel = level;
            Strength = strenth;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Damage = damage;

        }

        /*
         * Every time a warrior levels up, they gain: 
         * Strenght 1
         * Dexterity 1
         * Intelligence 5
        
        */
        public override void IncreaseLevel(int level)
        {

            //throw new NotImplementedException();
            Strength = 3;
            Dexterity = 2;
            Intelligence++;


        }


        /*
        Determines the physical strength of the character
        Each point of strength increase a warriors damage by 1%
          
        */

        public void StrengthWarrior()
        {

            Strength = (int)(Strength * 0.01);

        }

        
    }
}
