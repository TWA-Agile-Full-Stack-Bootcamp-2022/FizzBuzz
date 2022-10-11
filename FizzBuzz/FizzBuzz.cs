namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CountAndSay(int number)
        {
            return number % 5 == 0 ? "Buzz" : "Fizz";
        }
    }
}