using Assignment1.Classes;
using System;

namespace Assignment1
{
    internal class Program
    {
        string name = Console.ReadLine();
        
        static void Main(string[] args)
        {

            var instance = new Program();
            instance.Display();
            
           
        }

        public void Display()
        {
            UserInterface read = new UserInterface();
            read.Read();
            Character mage = new Mage(name, 1, 0.00, "sss", 0.00, 0.00);
            Console.Write(mage.ToString());
        }
    }
}
