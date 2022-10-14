using System.Runtime.InteropServices;
using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Should_say_Fizz_when_count_given_number_is_the_multiples_of_3(int number)
        {
            Assert.Equal("Fizz", FizzBuzz.FizzBuzz.CountAndSay(number));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Should_say_Buzz_when_count_given_number_is_the_multiples_of_5(int number)
        {
            Assert.Equal("Buzz", FizzBuzz.FizzBuzz.CountAndSay(number));
        }

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        public void Should_say_Whizz_when_count_given_number_is_the_multiples_of_7(int number)
        {
            Assert.Equal("Whizz", FizzBuzz.FizzBuzz.CountAndSay(number));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Should_say_the_number_when_count_given_number_is_not_the_multiples_of_3_5_7(int number)
        {
            Assert.Equal(number.ToString(), FizzBuzz.FizzBuzz.CountAndSay(number));
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(35, "BuzzWhizz")]
        [InlineData(21, "FizzWhizz")]
        [InlineData(105, "FizzBuzzWhizz")]
        public void Should_say_Fizz_Buzz_Whizz_combination_when_count_given_number_is_the_multiples_of_3_and_5_and_7(
            int number, string expect)
        {
            Assert.Equal(expect, FizzBuzz.FizzBuzz.CountAndSay(number));
        }
    }
}