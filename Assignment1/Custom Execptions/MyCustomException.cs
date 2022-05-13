using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Custom_Execptions
{
    internal class MyCustomException : Exception
    {
        // For invalid weapons and armor
        public MyCustomException()
        {


        }
        public MyCustomException(string message) : base(message)
        {


        }

        public override string Message => "Custom error";
    }
}
