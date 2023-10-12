using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        public void Should_return_the_given_number_when_countoff_given_a_number_not_multiple_of_3_5_7(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal(givenNumber.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Should_return_the_Fizz_when_countoff_given_a_number_multiple_of_3(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Should_return_the_Buzz_when_countoff_given_a_number_multiple_of_5(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(28)]
        public void Should_return_the_Whizz_when_countoff_given_a_number_multiple_of_7(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Whizz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Should_return_the_FizzBuzz_when_countoff_given_a_number_multiple_of_3_and_5(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(21)]
        [InlineData(42)]
        [InlineData(63)]
        public void Should_return_the_FizzWhizz_when_countoff_given_a_number_multiple_of_3_and_7(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("FizzWhizz", result);
        }

        [Theory]
        [InlineData(35)]
        [InlineData(70)]
        [InlineData(140)]
        public void Should_return_the_BuzzWhizz_when_countoff_given_a_number_multiple_of_5_and_7(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("BuzzWhizz", result);
        }

        [Theory]
        [InlineData(105)]
        [InlineData(210)]
        [InlineData(315)]
        public void Should_return_the_BuzzWhizz_when_countoff_given_a_number_not_multiple_of_3_and_5_and_7(int givenNumber)
        {
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("FizzBuzzWhizz", result);
        }
    }
}