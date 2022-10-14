namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CountAndSay(int number)
        {
            var sayWord = string.Empty;
            if (IsMultiplesOf(number, 3))
            {
                sayWord += "Fizz";
            }

            if (IsMultiplesOf(number, 5))
            {
                sayWord += "Buzz";
            }

            if (IsMultiplesOf(number, 7))
            {
                sayWord += "Whizz";
            }

            return sayWord.Length == 0 ? number.ToString() : sayWord;
        }

        private static bool IsMultiplesOf(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}