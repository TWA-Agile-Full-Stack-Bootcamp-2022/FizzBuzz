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
    }
}