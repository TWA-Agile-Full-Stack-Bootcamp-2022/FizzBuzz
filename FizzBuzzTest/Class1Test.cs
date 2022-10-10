using FizzBuzz;
using Moq;
using Xunit;

// 1. should return 4 when counts off given number not multiples with 3, 5, 7
// 2. should return Fizz when counts off given 3
// 3. should return Buzz when counts off given 5
// 4. should return Whizz when counts off given 7
// 5. should return FizzBuzz when counts off given 15
// 6. should return FizzWhizz when counts off given 21
// 7. should return BuzzWhizz when counts off given 35
// 8. should return FizzBuzzWhizz when counts off given 105

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_4_when_counts_off_given_number_not_multiples_with_3_5_7()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(4);
            //then
            Assert.Equal("4", count);
        }

        [Fact]
        public void Should_return_Fizz_when_counts_off_given_3()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(3);
            //then
            Assert.Equal("Fizz", count);
        }

        [Fact]
        public void Should_return_Buzz_when_counts_off_given_5()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(5);
            //then
            Assert.Equal("Buzz", count);
        }

        [Fact]
        public void Should_return_Whizz_when_counts_off_given_7()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(7);
            //then
            Assert.Equal("Whizz", count);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_counts_off_given_15()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(15);
            //then
            Assert.Equal("FizzBuzz", count);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_counts_off_given_21()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(21);
            //then
            Assert.Equal("FizzWhizz", count);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_counts_off_given_35()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(35);
            //then
            Assert.Equal("BuzzWhizz", count);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_counts_off_given_105()
        {
            Class1 class1 = new Class1();
            string count = class1.CountsOff(105);
            //then
            Assert.Equal("FizzBuzzWhizz", count);
        }
    }
}