using Assignment1.Classes;
using Assignment1.Custom_Execptions;
using Assignment1.Enum;
using System;
using System.Collections.Generic;

namespace Assignment1
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(WeaponType.Axes);
            Dictionary<string, string> WeaponsIventory = new Dictionary<string, string>();

            WeaponsIventory.Add("A", "Arrow");
            WeaponsIventory.Add("B", "Bow");

            var instance = new Program();
            Console.WriteLine();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome: " + name);
            // Dictionary
        

            string weapon = WeaponsIventory["A"];
            Console.WriteLine(weapon);


            // Try catch to use MysCustomException
            try
            {
                TestException(true);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine( "Custom exception: " + ex.Message);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Generic exception: " + ex.Message);   
            }
           
            // Dictionary - int, item
            // Initialize
            // Add
            // Remove(i)
            // ItemsException
        }

        // Call method to throw exception
        public static void TestException(bool throwException)
        {

            if (throwException)
                throw new MyCustomException();

            throw new IndexOutOfRangeException();
        }
    }
}
