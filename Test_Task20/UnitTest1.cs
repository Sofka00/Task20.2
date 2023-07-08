using NUnit.Framework;
using Task20;

namespace Test_Task20
{
    public class Class1Test
    {
        [TestCase(0,3,2,"0,0")]
        [TestCase(1,1,1, "0,5,-1,5")]
        public void LinearEquatiTest(int a, int b, int c, string expected)
        {
            string actual = Class1.LinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase (2,1,3)]
        [TestCase (1,1,1)]
        [TestCase (1,2,-1)]
        [TestCase(0,0,0)]
        public void ComparisonOfTwoNumberTest(int a, int b, int expected)
        {
            int actual = Class1.ComparisonOfTwoNumber(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(25,"ƒвадцатьѕ€ть")]
        public void UppercaseNumberTest(int number, string expected)
        {
            string actual = Class1.UppercaseNumber(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(19,false)]
        [TestCase(10,true)]
        [TestCase(0,true)]
        public void NumberFromRange(int number, bool expexted)
        {
            bool actual = Class1.NumberFromRange(number);
            Assert.AreEqual(expexted, actual);
        }
        [TestCase(-7,15,0)]
        [TestCase(6,14,21)]
        public void SumOfRangeNumberTest(int number1, int number2, int expected)
        {
            int actual = Class1.SumOfRangeNumber(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5,3)]
        [TestCase(0,0)]
        [TestCase(1,0)]
        public void FibonacciNumberTest(int number, int expected)
        {
            int actual = Class1.FibonacciNumber(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(23365,3)]
        [TestCase(0,0)]
        [TestCase(-253,2)]
        public void NumberOfOddDigitsTest(int number, int expected)
        {
            int actual = Class1.NumberOfOddDigits(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123,321)]
        [TestCase(222,222)]
        [TestCase(00,00)]
        [TestCase(10,01)]
        public void MirrorNumberTest(int number, int expected)
        {
            int actual = Class1.MirrorNumber(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("123","335",true)]
        [TestCase("112","333",false)]
        public void SameDigitsFromTwoNumbersTest(string number, string number2, bool expexted)
        {
            bool actual = Class1.SameDigitsFromTwoNumbers(number, number2);
            Assert.AreEqual(expexted, actual);
        }
    }
}