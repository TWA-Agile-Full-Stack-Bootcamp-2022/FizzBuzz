namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CountAndSay(int number)
        {
            if (number % 7 == 0)
            {
                return "Whizz";
            }

            return number % 5 == 0 ? "Buzz" : "Fizz";
        }
    }
}