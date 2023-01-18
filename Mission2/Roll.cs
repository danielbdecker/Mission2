using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    public class Roll
    {
        public int DiceRoll // returns random number between 1 and 6
        {
            get
            {
                Random rnd = new Random();
                int roll = rnd.Next(1, 7);
                return roll;
            }
        }
    }
}
