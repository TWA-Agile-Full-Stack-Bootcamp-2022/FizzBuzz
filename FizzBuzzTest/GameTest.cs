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
    }
}