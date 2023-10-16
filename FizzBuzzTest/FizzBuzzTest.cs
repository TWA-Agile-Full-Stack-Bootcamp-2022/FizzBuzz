using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_init_fizzBuzzGame_class_correctly()
        {
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

            //then
            Assert.NotNull(fizzBuzzGame);
        }

        [Fact]
        public void Should_return_4_when_given_number_is_2()
        {
            int number = 2;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("2", result);
        }

        [Fact]
        public void Should_return_Fizz_when_given_number_is_multiple_of_3()
        {
            int number = 3;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_when_given_number_is_multiple_of_5()
        {
            int number = 5;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_when_given_number_is_multiple_of_7()
        {
            int number = 7;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_given_number_is_multiple_both_3_and_5()
        {
            int number = 15;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_given_number_is_multiple_both_3_and_7()
        {
            int number = 21;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_given_number_is_multiple_both_5_and_7()
        {
            int number = 35;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_given_number_is_multiple_both_3_and_5_and_7()
        {
            int number = 105;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("FizzBuzzWhizz", result);
        }
    }
}