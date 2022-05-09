using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Mage : Character
    {


        public Mage()
        {


        }

        // Overloading the constructor
        public Mage(string name, int level, int strenth, int dexterity, int intelligence, double damage) : base()
        {
            CharacterName = name;
            CharacterLevel = level;
            Strength = strenth;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Damage = damage;

        }

        /*
         * Every time a mage levels up, they gain: 
         * Strenght 1
         * Dexterity 1
         * Intelligence 5
        
        */
        public override void IncreaseLevel(int level)
        {

            //throw new NotImplementedException();
            Strength++;
            Dexterity++;
            Intelligence += 5;
            

        }

        /*
    Determines the characters affinity with magic.
    Each point of intelligence increase a mages damage by 1%.

    */

        public void StrengthWarrior()
        {

            Dexterity = (int)(Dexterity * 0.01);

        }
    }
}
