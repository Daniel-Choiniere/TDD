using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Net;
using NUnit.Framework;

//implement abstract method that takes abstract roman numeral as a string argumnet, parses it and returns a regular number
namespace RomanNumeralConverter
{
    [TestFixture]
    public class Tests
    {
        
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(99, "XCIX")]
        

        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, Roman.ParseTest(roman));
        }

        public class Roman
        {
            private static Dictionary<char, int> map =
                new Dictionary<char, int>()
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };
            public static int ParseTest(string roman)
            {
                int result = 0;

                for (int i = 0; i < roman.Length; i++)
                {
                    if (i + 1 < roman.Length && IsSubtractive(roman, i))
                    {
                        result -= map[roman[i]];

                    }
                    else
                    {
                        result += map[roman[i]];
                    }
                }

                return result;
            }

            private static bool IsSubtractive(string roman, int i)
            {
                return map[roman[i]] < map[roman[i + 1]];
            }
        }   
        
        
    }
}