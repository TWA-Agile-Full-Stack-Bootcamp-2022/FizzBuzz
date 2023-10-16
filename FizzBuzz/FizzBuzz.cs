using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int num)
        {
            string result = string.Empty;

            if (num % 3 == 0)
            {
                result += "Fizz";
            }

            if (num % 5 == 0)
            {
                result += "Buzz";
            }

            if (num % 7 == 0)
            {
                result += "Whizz";
            }

            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }

            return num.ToString();
        }
    }
}
