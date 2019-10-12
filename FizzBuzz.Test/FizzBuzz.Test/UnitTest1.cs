using NUnit.Framework;

namespace FizzBuzz.Test
{
   
    /*
     * If divisible by 3       -> return "Fizz"
     * If divisible by 5       -> return "Buzz"
     * If divisible by 3 and 5 -> return "FizzBuzz"
     * Otherwise               -> return ""
     */
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
        
        private string FizzBuzzTests(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }

            return "";
        }
    }
}
