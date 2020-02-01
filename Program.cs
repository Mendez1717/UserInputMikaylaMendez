using System;

namespace UserInputMikaylaMendez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Mikayla Mendez");

            string username;
            Console.Write("Please enter your name");
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
