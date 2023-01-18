using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    class Welcome
    {
        public string Response() //gets the number of dice rolls the user wants
        {
            string response = "";
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            response = Console.ReadLine();
            return response;
        }
        public int NumRolls(string response) //converts user's input to int
        {
            try
            {
                int numRolls = Int32.Parse(response);
                return numRolls;
            }
            catch (FormatException) //throws exception if input couldn't convert
            {
                Console.WriteLine($"Unable to parse '{response}', please enter an integer like 57");
                Response();
                return -1;
            }
        }

    }
}
