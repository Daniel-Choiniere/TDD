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
        [TestCase(7, "VII")]

        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, ParseTest(roman));
        }
        
        private static int ParseTest(string roman)
        {
            
            int Inumeral = 0;
            int Vnumeral = 0;
            int Xnumeral = 0;

            foreach (char symbol in roman)
            {
                if (symbol == 'I')
                {
                    Inumeral += 1;
                }

                if (symbol == 'V')
                {
                    Vnumeral += 5;
                }

                if (symbol == 'X')
                {
                    Xnumeral += 10;
                }
                
            }
            
            return Inumeral + Vnumeral + Xnumeral;
        }
        
    }
}