using NUnit.Framework;

namespace FizzBuzz.Test
{
    
    [TestFixture]
    public class FizzBuzz
    {
        [TestCase("FizzBuzz", 15)]
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 10)]
        [TestCase("", 2)]
        [TestCase("FizzBuzz", 0)]

        public void TestFizzBuzz(string expected, int number)
        {
            Assert.AreEqual(expected, FizzBuzzTests(number));
        }
        
        private static string FizzBuzzTests(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return "";
        }
    }
}
