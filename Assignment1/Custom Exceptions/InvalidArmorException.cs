using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Custom_Exceptions
{
    internal class InvalidArmorException : Exception
    {
        // For invalid armors

        // Empty constructor
        public InvalidArmorException()
        {


        }
        public InvalidArmorException(string message) : base(message)
        {


        }

        public override string Message => "Invalid armor";
    }
}
