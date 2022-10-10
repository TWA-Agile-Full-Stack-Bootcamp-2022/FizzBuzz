using System;

namespace FizzBuzz
{
    public class Class1
    {
        public string CountsOff(int i)
        {
            string result = string.Empty;
            if (0.Equals(i % 3))
            {
                result = "Fizz";
            }

            if (0.Equals(i % 5))
            {
                result += "Buzz";
            }

            if (0.Equals(i % 7))
            {
                result += "Whizz";
            }

            if (result.Equals(string.Empty))
            {
                return i.ToString();
            }

            return result;
        }
    }
}
