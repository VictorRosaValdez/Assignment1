using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Custom_Exceptions
{
    public class EquipmentException : Exception
    {
        public EquipmentException(string message) : base(message)
        {

        }

        public override string Message => "Equipment exception";
    }
}
