using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int orderNumber)
        {
            var result = string.Empty;
            bool isMultipleOfThree = orderNumber % 3 == 0;
            bool isMultipleOfFive = orderNumber % 5 == 0;
            bool isMultipleOfSeven = orderNumber % 7 == 0;
            if (isMultipleOfThree)
            {
                result += "Fizz";
            }

            if (isMultipleOfFive)
            {
                result += "Buzz";
            }

            if (isMultipleOfSeven)
            {
                result += "Whizz";
            }

            return string.IsNullOrEmpty(result) ? orderNumber.ToString() : result;
        }
    }
}
