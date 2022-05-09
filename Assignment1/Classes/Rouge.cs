using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Rouge : Character
    {
        // Overloading the constructor
        public Rouge(string name, int level, int strenth, int dexterity, int intelligence, double damage) : base()
        {
            CharacterName = name;
            CharacterLevel = level;
            Strength = strenth;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Damage = damage;

        }

        /*
         * Every time a rouge levels up, they gain: 
         * Strenght 1
         * Dexterity 4
         * Intelligence 1
        
        */
        public override void IncreaseLevel(int level)
        {

            //throw new NotImplementedException();
            Strength++;
            Dexterity = 4;
            Intelligence++;


        }

        /*
      Determines the characters ability to attack with speed and nimbleness.
      Each point of dexterity increase a rogues damage by 1%.

      */

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }

    }
}
