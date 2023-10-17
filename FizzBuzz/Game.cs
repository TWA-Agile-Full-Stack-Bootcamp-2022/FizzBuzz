using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Game
    {
        public string Count(int v)
        {
            if (v % 3 == 0)
            {
                return "Fizz";
            }
            else if (v % 5 == 0)
            {
                return "Buzz";
            }

            return v.ToString();
        }
    }
}
