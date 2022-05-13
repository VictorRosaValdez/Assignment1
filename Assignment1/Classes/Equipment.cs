using Assignment1.Custom_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Equipment
    {
        public int Size { get;}

        private Dictionary<int, Weapon> _equipment { get; set; }
        public Equipment(int size)
        {
            if (size <1)
            {
                throw new EquipmentException("Can not initialize an inventort with a size less than 1. ");
            }
            InitializeEquipment(size);
        }

        private void InitializeEquipment(int size)
        {
            _equipment = new Dictionary<int, Weapon>();
            for (int i = 1; i <= size; i++)
            {
                _equipment.Add(i, new Weapon());

            }
        }

        public int GetEquipmentSize()
        {
            // Counting the elements in our dictionary and returning that value
            return _equipment.Count;
        }
    }
}
