using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_say_Fizz_when_count_given_number_is_the_multiples_of_3()
        {
            Assert.Equal("Fizz", FizzBuzz.FizzBuzz.CountAndSay(3));
            Assert.Equal("Fizz", FizzBuzz.FizzBuzz.CountAndSay(6));
        }

        [Fact]
        public void Should_say_Buzz_when_count_given_number_is_the_multiples_of_5()
        {
            Assert.Equal("Buzz", FizzBuzz.FizzBuzz.CountAndSay(5));
            Assert.Equal("Buzz", FizzBuzz.FizzBuzz.CountAndSay(10));
        }

        [Fact]
        public void Should_say_Whizz_when_count_given_number_is_the_multiples_of_7()
        {
            Assert.Equal("Whizz", FizzBuzz.FizzBuzz.CountAndSay(7));
            Assert.Equal("Whizz", FizzBuzz.FizzBuzz.CountAndSay(14));
        }
    }
}