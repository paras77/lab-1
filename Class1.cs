using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace calculator_test
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point0and5point0_Returns8point0()
            {
                //Arrange
                double number1 = 3.0;
                double number2 = 5.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input4point0and5point0_Returns9point0()
            {
                //Arrange
                double number1 = 4.0;
                double number2 = 5.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input8point0and9point0_Returns17point0()
            {
                //Arrange
                double number1 = 8.0;
                double number2 = 9.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input9point0and5point0_Returns4point0()
            {
                //Arrange
                double number1 = 9.0;
                double number2 = 5.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input5point0and5point0_Returns0point0()
            {
                //Arrange
                double number1 = 5.0;
                double number2 = 5.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input7point0and5point0_Returns2point0()
            {
                //Arrange
                double number1 = 7.0;
                double number2 = 5.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input1point0and5point0_Returns5point0()
            {
                //Arrange
                double number1 = 1.0;
                double number2 = 5.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input1point0and5point0_Return5point0()
            {
                //Arrange
                double number1 = 1.0;
                double number2 = 5.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input4point0and5point0_Returns20point0()
            {
                //Arrange
                double number1 = 4.0;
                double number2 = 5.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input4point0and1point0_Returns4point0()
            {
                //Arrange
                double number1 = 4.0;
                double number2 = 1.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input3point0and1point0_Returns3point0()
            {
                //Arrange
                double number1 = 3.0;
                double number2 = 1.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input5point0and1point0_Returns5point0()
            {
                //Arrange
                double number1 = 5.0;
                double number2 = 1.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        }
    }
}
