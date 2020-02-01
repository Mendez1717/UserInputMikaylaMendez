using System;

namespace UserInputMikaylaMendez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Mikayla Mendez, what is your name?");

            string username;
            Console.Write("You Typed: ");
            username = Console.ReadLine();

            //Ask user to enter value 
            string greeting = "Are you ready to begin?";
            string nextgreeting = "";

            if (greeting == "Are you ready to begin?")
            {
                nextgreeting = "Hit enter to begin";
            }
            else if (greeting == "Do you need assistance?")
            {
                nextgreeting = "Do not continue";
            }
            Console.WriteLine(nextgreeting);
        }
    }
}
