//Author: Daniel Decker
//Section 2
//Mission 2
//Takes input from user to simulate a number of dice rolls for two dice
//Displays a histogram of percentages of times a certain number was rolled

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            string response = welcome.Response();
            int numRolls = -1;
            while (numRolls < 0) //ensures the user input was an integer
            {
                numRolls = welcome.NumRolls(response);
                if (numRolls < 0)
                {
                    response = welcome.Response();
                }
            }
            Roll r1 = new Roll();
            int roll1 = 0;
            int roll2 = 0;
            int[] totals = new int[11];
            for (int i = 0; i < 11; i++) //sets each element in the array to 0. totals[0] will represent 2 on the dice, and totals[10] will represent 12
            {
                totals[i] = 0;
            }
            for (int i = 0; i < numRolls; i++) //rolls two dice and adds the roll number to the array
            {
                roll1 = r1.DiceRoll;
                roll2 = r1.DiceRoll;
                totals[roll1 + roll2 - 2]++;
            }
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}\n");
            int diceName = 2; //the number for the dice, will be printed and incremented in the loop
            double numAst; //number of asterisks to be printed
            for (int i = 0; i < 11; i++) //prints the histogram with the percentage of each roll amount
            {
                if (diceName < 10) // adds a space for formatting for numbers with only one digit
                {
                    Console.Write($" {diceName}: ");
                }
                else
                {
                    Console.Write($"{diceName}: ");
                }

                float total = totals[i];
                float numberRolls = numRolls;
                numAst = (total/numberRolls) * 100; //calculates number of asterisks
                numAst = Math.Round(numAst);
                for (int j = 0; j < numAst; j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
                diceName++;
            }

        }
    }
}
