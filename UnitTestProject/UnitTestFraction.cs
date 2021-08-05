using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestFraction
    {
        [TestMethod]
        public void Test01_ConstructorWithoutArgument()
        {
            // Arrange
            int expectedNumerator = 0;
            int expectedDenominator = 1;
            // Action
            Fraction frac = new Fraction();
            // Assert
            Assert.AreEqual(expectedNumerator, frac.Numerator);
            Assert.AreEqual(expectedDenominator, frac.Denominator);
        }

        [TestMethod]
        [DataRow(0, "0", DisplayName = "Fraction(0)")]
        [DataRow(1, "1", DisplayName = "Fraction(1)")]
        [DataRow(2, "2", DisplayName = "Fraction(2)")]
        [DataRow(13, "13", DisplayName = "Fraction(13)")]
        [DataRow(100, "100", DisplayName = "Fraction(100)")]
        [DataRow(123456, "123456", DisplayName = "Fraction(123456)")]
        [DataRow(-1, "-1", DisplayName = "Fraction(-1)")]
        [DataRow(-2, "-2", DisplayName = "Fraction(-2)")]
        [DataRow(-13, "-13", DisplayName = "Fraction(-13)")]
        [DataRow(-100, "-100", DisplayName = "Fraction(-100)")]
        [DataRow(-123456, "-123456", DisplayName = "Fraction(-123456)")]
        public void Test02_ConstructorWithOneInt(int pNumber, string pExpectedValue)
        {
            // Arrange
            int Number = pNumber;
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = new Fraction(Number);
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(0, 5, "0", DisplayName = "Fraction(0,5)")]
        [DataRow(1, 1, "1", DisplayName = "Fraction(1,1)")]
        [DataRow(1, 2, "1/2", DisplayName = "Fraction(1,2)")]
        [DataRow(1, 3, "1/3", DisplayName = "Fraction(1,3)")]
        [DataRow(1, 4, "1/4", DisplayName = "Fraction(1,4)")]
        [DataRow(-1, 5, "-1/5", DisplayName = "Fraction(-1,5)")]
        [DataRow(1, 100, "1/100", DisplayName = "Fraction(1,100)")]
        [DataRow(2, 1, "2", DisplayName = "Fraction(2,1)")]
        [DataRow(-3, 1, "-3", DisplayName = "Fraction(-3,1)")]
        [DataRow(-3, 4, "-3/4", DisplayName = "Fraction(-3,4)")]
        [DataRow(2, 3, "2/3", DisplayName = "Fraction(2,1)")]
        [DataRow(-2, 3, "-2/3", DisplayName = "Fraction(-2,3)")]
        [DataRow(7, 2, "3 1/2", DisplayName = "Fraction(7,2)")]
        [DataRow(-7, 2, "-3 1/2", DisplayName = "Fraction(-7,2)")]
        [DataRow(17, 97, "17/97", DisplayName = "Fraction(17,97)")]
        [DataRow(-17, 97, "-17/97", DisplayName = "Fraction(-17,97)")]
        [DataRow(5, 5, "1", DisplayName = "Fraction(5,5)")]
        [DataRow(-5, 5, "-1", DisplayName = "Fraction(-5,5)")]
        [DataRow(5, -5, "-1", DisplayName = "Fraction(5,-5)")]
        [DataRow(-5, -5, "1", DisplayName = "Fraction(-5,-5)")]
        [DataRow(5, 15, "1/3", DisplayName = "Fraction(5,15)")]
        [DataRow(-5, 15, "-1/3", DisplayName = "Fraction(-5,15)")]
        [DataRow(15, 5, "3", DisplayName = "Fraction(15,5)")]
        [DataRow(-15, 5, "-3", DisplayName = "Fraction(-15,5)")]
        [DataRow(17, 5, "3 2/5", DisplayName = "Fraction(17,5)")]
        [DataRow(-17, 5, "-3 2/5", DisplayName = "Fraction(-17,5)")]
        public void Test03_ConstructorWithTwoInt(int pNumerator, int pDenominator, string pExpectedValue)
        {
            // Arrange
            int Numerator = pNumerator;
            int Denominator = pDenominator;
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = new Fraction(Numerator, Denominator);
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(1, 0, 5, "1", DisplayName = "Fraction(1,0,5)")]
        [DataRow(2, 1, 1, "3", DisplayName = "Fraction(2,1,1)")]
        [DataRow(3, 1, 2, "3 1/2", DisplayName = "Fraction(3,1,2)")]
        [DataRow(2, 1, 100, "2 1/100", DisplayName = "Fraction(200,1,100)")]
        [DataRow(3, 2, 1, "5", DisplayName = "Fraction(3,2,1)")]
        [DataRow(4, 2, 3, "4 2/3", DisplayName = "Fraction(2,1)")]
        [DataRow(-1, 0, 5, "-1", DisplayName = "Fraction(-1,0,5)")]
        [DataRow(-2, 1, 1, "-3", DisplayName = "Fraction(-2,1,1)")]
        [DataRow(-3, 1, 2, "-3 1/2", DisplayName = "Fraction(-3,1,2)")]
        [DataRow(-2, 1, 100, "-2 1/100", DisplayName = "Fraction(-2,1,100)")]
        [DataRow(-3, 2, 1, "-5", DisplayName = "Fraction(-3,2,1)")]
        [DataRow(-4, 2, 3, "-4 2/3", DisplayName = "Fraction(-4,2,1)")]
        public void Test04_ConstructorWithThreeInt(int pNumber, int pNumerator, int pDenominator, string pExpectedValue)
        {
            // Arrange
            int Number = pNumber;
            int Numerator = pNumerator;
            int Denominator = pDenominator;
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = new Fraction(Number, Numerator, Denominator);
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(1, 4, 2, 4, "3/4", DisplayName = "1/4 + 2/4")]
        [DataRow(1, 4, 5, 4, "1 1/2", DisplayName = "1/4 + 5/4")]
        [DataRow(1, 3, 1, 4, "7/12", DisplayName = "1/3 + 1/4")]
        [DataRow(-1, 3, 1, 4, "-1/12", DisplayName = "-1/3 + 1/4")]
        [DataRow(5, 3, 7, 4, "3 5/12", DisplayName = "5/3 + 7/4")]
        [DataRow(1, 5, 2, 1, "2 1/5", DisplayName = "1/5 + 2/1")]
        [DataRow(1, 5, 0, 1, "1/5", DisplayName = "1/5 + 0/1")]
        public void Test05_OperatorAdd(int pLeftNumerator, int pLeftDenominator, int pRightNumerator, int pRightDenominator, string pExpectedValue)
        {
            // Arrange
            Fraction leftFrac = new Fraction(pLeftNumerator, pLeftDenominator);
            Fraction RightFrac = new Fraction(pRightNumerator, pRightDenominator);
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = leftFrac + RightFrac;
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(1, 4, 2, 4, "-1/4", DisplayName = "1/4 - 2/4")]
        [DataRow(1, 4, 5, 4, "-1", DisplayName = "1/4 - 5/4")]
        [DataRow(1, 3, 1, 4, "1/12", DisplayName = "1/3 - 1/4")]
        [DataRow(-1, 3, 1, 4, "-7/12", DisplayName = "-1/3 - 1/4")]
        [DataRow(5, 3, 7, 4, "-1/12", DisplayName = "5/3 - 7/4")]
        [DataRow(2, 1, 1, 5, "1 4/5", DisplayName = "2/1 - 1/5")]
        [DataRow(1, 5, 0, 1, "1/5", DisplayName = "1/5 - 0/1")]
        public void Test06_OperatorSubtract(int pLeftNumerator, int pLeftDenominator, int pRightNumerator, int pRightDenominator, string pExpectedValue)
        {
            // Arrange
            Fraction leftFrac = new Fraction(pLeftNumerator, pLeftDenominator);
            Fraction RightFrac = new Fraction(pRightNumerator, pRightDenominator);
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = leftFrac - RightFrac;
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(1, 4, 2, 4, "1/8", DisplayName = "1/4 * 2/4")]
        [DataRow(1, 4, 5, 4, "5/16", DisplayName = "1/4 * 5/4")]
        [DataRow(1, 3, 1, 4, "1/12", DisplayName = "1/3 * 1/4")]
        [DataRow(-1, 3, 1, 4, "-1/12", DisplayName = "-1/3 * 1/4")]
        [DataRow(5, 3, 7, 4, "2 11/12", DisplayName = "5/3 * 7/4")]
        [DataRow(1, 5, 3, 1, "3/5", DisplayName = "1/5 * 3")]
        [DataRow(0, 1, 1, 5, "0", DisplayName = "0 * 1/5")]
        public void Test07_OperatorMultiply(int pLeftNumerator, int pLeftDenominator, int pRightNumerator, int pRightDenominator, string pExpectedValue)
        {
            // Arrange
            Fraction leftFrac = new Fraction(pLeftNumerator, pLeftDenominator);
            Fraction RightFrac = new Fraction(pRightNumerator, pRightDenominator);
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = leftFrac * RightFrac;
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(1, 4, 2, 4, "1/2", DisplayName = "1/4 / 2/4")]
        [DataRow(1, 4, 5, 4, "1/5", DisplayName = "1/4 / 5/4")]
        [DataRow(1, 3, 1, 4, "1 1/3", DisplayName = "1/3 / 1/4")]
        [DataRow(-1, 3, 1, 4, "-1 1/3", DisplayName = "-1/3 / 1/4")]
        [DataRow(5, 3, 7, 4, "20/21", DisplayName = "5/3 / 7/4")]
        [DataRow(1, 5, 3, 1, "1/15", DisplayName = "1/5 / 3")]
        [DataRow(0, 1, 1, 5, "0", DisplayName = "0 / 1/5")]
        public void Test08_OperatorDivide(int pLeftNumerator, int pLeftDenominator, int pRightNumerator, int pRightDenominator, string pExpectedValue)
        {
            // Arrange
            Fraction leftFrac = new Fraction(pLeftNumerator, pLeftDenominator);
            Fraction RightFrac = new Fraction(pRightNumerator, pRightDenominator);
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = leftFrac / RightFrac;
            string value = frac.ToString();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test09_OperatorDivideByZero()
        {
            // Arrange
            Fraction leftFrac = new Fraction(2, 5);
            Fraction RightFrac = new Fraction();
            // Action
            Fraction frac = leftFrac / RightFrac;
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test10_ConstructorWithDenominatorAtZero()
        {
            // Arrange
            // Action
            Fraction frac = new Fraction(2, 0);
            // Assert
        }

        [TestMethod]
        [DataRow(0, 1, "0/1", DisplayName = "0/1")]
        [DataRow(1, 4, "1/4", DisplayName = "1/4")]
        [DataRow(3, 1, "3/1", DisplayName = "3/1")]
        [DataRow(5, 3, "5/3", DisplayName = "5/3")]
        [DataRow(0, -1, "0/1", DisplayName = "0/-1")]
        [DataRow(-1, 4, "-1/4", DisplayName = "-1/4")]
        [DataRow(3, -1, "-3/1", DisplayName = "3/-1")]
        [DataRow(-5, 3, "-5/3", DisplayName = "-5/3")]
        public void Test11_ToStringWithOnlyFraction(int pNumerator, int pDenominator, string pExpectedValue)
        {
            // Arrange
            int Numerator = pNumerator;
            int Denominator = pDenominator;
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = new Fraction(Numerator, Denominator);
            string value = frac.ToStringWithOnlyFraction();
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(0, 1, "0", DisplayName = "(string)Fraction(0,1)")]
        [DataRow(1, 4, "1/4", DisplayName = "(string)Fraction(1,4)")]
        [DataRow(3, 1, "3", DisplayName = "(string)Fraction(3,1)")]
        [DataRow(5, 3, "1 2/3", DisplayName = "(string)Fraction(5,3)")]
        [DataRow(-1, 2, "-1/2", DisplayName = "(string)Fraction(-1,2)")]
        [DataRow(-5, 3, "-1 2/3", DisplayName = "(string)Fraction(-5,3)")]
        public void Test12_CastingToString(int pNumerator, int pDenominator, string pExpectedValue)
        {
            // Arrange
            int Numerator = pNumerator;
            int Denominator = pDenominator;
            string ExpectedValue = pExpectedValue;
            // Action
            Fraction frac = new Fraction(Numerator, Denominator);
            string value = frac;
            // Assert
            Assert.AreEqual(ExpectedValue, value);
        }

        [TestMethod]
        [DataRow(0, 1, DisplayName = "Fraction(0,1) -> decimal -> Fraction")]
        [DataRow(3, 1, DisplayName = "Fraction(3,1) -> decimal -> Fraction")]
        [DataRow(1, 4, DisplayName = "Fraction(1,4) -> decimal -> Fraction")]
        [DataRow(1, 2, DisplayName = "Fraction(1,2) -> decimal -> Fraction")]
        [DataRow(-1, 2, DisplayName = "Fraction(-1,2) -> decimal -> Fraction")]
        [DataRow(3, 4, DisplayName = "Fraction(3,4) -> decimal -> Fraction")]
        [DataRow(5, 2, DisplayName = "Fraction(5,2) -> decimal -> Fraction")]
        [DataRow(-5, 2, DisplayName = "Fraction(-5,2) -> decimal -> Fraction")]
        [DataRow(2, 3, DisplayName = "Fraction(2,3) -> decimal -> Fraction")]
        [DataRow(5, 3, DisplayName = "Fraction(5,3) -> decimal -> Fraction")]
        [DataRow(-5, 3, DisplayName = "Fraction(-5,3) -> decimal -> Fraction")]
        [DataRow(31, 97, DisplayName = "Fraction(31,97) -> decimal -> Fraction")]
        [DataRow(3989, 1999, DisplayName = "Fraction(3989,1999) -> decimal -> Fraction")]
        public void Test13_CastingDecimal(int pNumerator, int pDenominator)
        {
            // Arrange
            int Numerator = pNumerator;
            int Denominator = pDenominator;
            // Action
            Fraction fracSrc = new Fraction(Numerator, Denominator);
            decimal value = (decimal)fracSrc;
            Fraction fracDst = (Fraction)value;
            // Assert
            Assert.AreEqual(Numerator, fracDst.Numerator);
            Assert.AreEqual(Denominator, fracDst.Denominator);
        }

        [TestMethod]
        [DataRow(0, 1, 1, 1, true, false, false, DisplayName = "0 <=> 1")]
        [DataRow(0, 1, -1, 1, false, false, true, DisplayName = "0 <=> -1")]
        [DataRow(1, 4, 1, 4, false, true, false, DisplayName = "1/4 <=> 1/4")]
        [DataRow(-1, 4, 1, 4, true, false, false, DisplayName = "-1/4 <=> 1/4")]
        [DataRow(1, 4, 2, 4, true, false, false, DisplayName = "1/4 <=> 2/4")]
        [DataRow(1, 4, 5, 4, true, false, false, DisplayName = "1/4 <=> 5/4")]
        [DataRow(1, 3, 1, 4, false, false, true, DisplayName = "1/3 <=> 1/4")]
        [DataRow(5, 3, 7, 4, true, false, false, DisplayName = "5/3 <=> 7/4")]
        [DataRow(1, 5, 3, 1, true, false, false, DisplayName = "1/5 <=> 3")]
        [DataRow(5, 3, 10, 6, false, true, false, DisplayName = "5/3 <=> 10/6")]
        public void Test14_ComparisonOperators(int pLeftNumerator, int pLeftDenominator,
                                               int pRightNumerator, int pRightDenominator,
                                               bool pExpectedValueInf, bool pExpectedValueEqu, bool pExpectedValueSup)
        {
            // Arrange
            Fraction leftFrac = new Fraction(pLeftNumerator, pLeftDenominator);
            Fraction RightFrac = new Fraction(pRightNumerator, pRightDenominator);
            // Action
            bool valueInf = leftFrac < RightFrac;
            bool valueEqu = leftFrac == RightFrac;
            bool valueDif = leftFrac != RightFrac;
            bool valueSup = leftFrac > RightFrac;
            // Assert
            Assert.AreEqual(pExpectedValueInf, valueInf);
            Assert.AreEqual(pExpectedValueEqu, valueEqu);
            Assert.AreEqual(!pExpectedValueEqu, valueDif);
            Assert.AreEqual(pExpectedValueSup, valueSup);
        }

        [TestMethod]
        public void Test15_IComparable()
        {
            // Arrange
            Fraction[] fractions = { new Fraction(1), new Fraction(1,2), new Fraction(), new Fraction(1,3), new Fraction(-1,4) };
            Fraction[] expectedFractions = { new Fraction(-1,4), new Fraction(), new Fraction(1,3), new Fraction(1,2), new Fraction(1) };
            // Action
            Array.Sort(fractions);
            // Assert
            for (int i = 0; i < expectedFractions.Length; i++)
            {
                Assert.AreEqual(expectedFractions[i].Numerator, fractions[i].Numerator);
                Assert.AreEqual(expectedFractions[i].Denominator, fractions[i].Denominator);
            }
        }
    }
}
