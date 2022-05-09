using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Ranger : Character
    {
        // Overloading the constructor
        public Ranger(string name, int level, int strenth, int dexterity, int intelligence, double damage) : base()
        {
            CharacterName = name;
            CharacterLevel = level;
            Strength = strenth;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Damage = damage;

        }

        /*
         * Every time a ranger levels up, they gain: 
         * Strenght 1
         * Dexterity 5
         * Intelligence 1
        
        */
        public override void IncreaseLevel(int level)
        {

            //throw new NotImplementedException();
            Strength++;
            Dexterity = 5;
            Intelligence++;


        }

        /*
       Determines the characters ability to attack with speed and nimbleness.
       Each point of dexterity increase a rangers damage by 1%.

       */

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }
    }
}
