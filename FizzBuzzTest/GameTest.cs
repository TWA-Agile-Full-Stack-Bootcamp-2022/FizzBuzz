using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class GameTest
    {
        [Fact]
        public void Should_Be_1_OR_2_When_Input_1_()
        {
            Game game = new Game();

            //then
            Assert.Equal("1", game.Count(1));
        }

        [Fact]
        public void Should_Be_Fizz_When_3()
        {
            Game game = new Game();

            Assert.Equal("Fizz", game.Count(3));
        }

        [Fact]
        public void Should_Be_Buzz_When_5()
        {
            Game game = new Game();
            Assert.Equal("Buzz", game.Count(5));
        }

        [Fact]
        public void Should_Be_FizzBuzz_When_15()
        {
            Game game = new Game();
            Assert.Equal("FizzBuzz", game.Count(15));
        }
    }
}