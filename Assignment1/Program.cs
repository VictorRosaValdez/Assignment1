using Assignment1.Classes;
using System;

namespace Assignment1
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

            var instance = new Program();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome: " + name);
            instance.Display();
            
           
        }

        public void Display()
        {
            Console.WriteLine("No enter the name of Character");
            Console.WriteLine("You can chose one of these four characters");
            Console.WriteLine("Mage");
            Console.WriteLine("Ranger");
            Console.WriteLine("Rougue");
            Console.WriteLine("Warrior");

            string nameCharacter = Console.ReadLine().ToLower();
            Character mage = new Mage(nameCharacter, 1, 1, 1, 1, 0.00);
            Character ranger = new Ranger(nameCharacter, 1, 1, 1, 1, 0.00);
            Character rouge = new Rouge(nameCharacter, 1, 1, 1, 1, 0.00);
            Character warrior = new Warrior(nameCharacter, 1, 1, 1, 1, 0.00);
            Item weapon = new Weapon(Enum.WeaponType.Axes, 1, 1);
            Console.WriteLine(weapon.ToString());

            if (nameCharacter == "mage")
            {

                Console.WriteLine(mage.ToString());
            }

            if (nameCharacter == "ranger")
            {

                Console.WriteLine(ranger.ToString());
            }

            if (nameCharacter == "rogue")
            {

                Console.WriteLine(rouge.ToString());
            }

            if (nameCharacter == "warrior")
            {

                Console.WriteLine(warrior.ToString());
            }

            else {

                Console.Write("This name does not exits, please enter a valid name");            
            }
        }
    }
}
