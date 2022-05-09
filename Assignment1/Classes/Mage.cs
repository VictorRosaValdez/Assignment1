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
        public Mage(string name, int level, double strenth, string dexterity, double intelligence, double damage)
        {
            this.CharacterName = name;
            this.CharacterLevel = level;
            this.Strenth = strenth;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Damage = damage;
        }
        public override string IncreaseLevel(int level)
        {
            throw new NotImplementedException();
        }
    }
}
