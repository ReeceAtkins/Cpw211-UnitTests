using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method

            double expectedValue = num1 + num2;
            
            double returnedValaue = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedValue, returnedValaue);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method

            double num1 = 5;
            double num2 = 10;
            double expectedValue = num1 * num2;

            double returnedValue = SimpleMath.Multiply(num1, num2);


            Assert.AreEqual(expectedValue, expectedValue);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            double num1 = 5;
            double num2 = 0;

            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(-1, -10)]
        public void Divide_ValidNumbers_ReturnsDevidedValue(double num1, double num2)
        {
            double expectedValue = num1 / num2;

            double returnedValue = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(expectedValue, returnedValue);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_ValidNumbers_ReturnsSubractedValue(double num1, double num2)
        {
            double expectedValue = num1 - num2;

            double returnedValue = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(expectedValue, returnedValue);
        }
    }
}