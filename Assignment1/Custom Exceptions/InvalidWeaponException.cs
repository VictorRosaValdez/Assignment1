using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Custom_Exceptions
{
    internal class InvalidWeaponException : Exception
    {
        // For invalid weapons

        // Empty constructor
        public InvalidWeaponException()
        {


        }
        public InvalidWeaponException(string message) : base(message)
        {


        }

        public override string Message => "Invalid weapon";
    }
}
