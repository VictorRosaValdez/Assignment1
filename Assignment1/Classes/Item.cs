using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }

        public int Slot { get; set; }
    }
}
