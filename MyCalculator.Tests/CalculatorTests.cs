using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("SimpleMath")]
        public void AddSimple()
        {
            var calculator = new Calculator();
            int sum = calculator.Add(1, 2);
            Assert.AreEqual(3, sum);
        }
        [TestMethod]
        [TestCategory("SimpleMath")]
        [Priority(0)]
        public void DivideSimple()
        {
            var calculator = new Calculator();
            int quotient = calculator.Divide(10, 5);
            Assert.AreEqual(2, quotient);
        }
        [TestMethod]
        [TestCategory("Exceptions")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(10,0);
        }
        [TestMethod]
        [TestCategory("Hypotenuse")]
        public void CalcHypotenuse()
        {
            Calculator calculator = new Calculator();
            calculator.triangleHypotenuse(20, 40);

        }

        [TestMethod]
        [TestCategory("Area")]
        public void CalcArea()
        {
            Calculator calculator = new Calculator();
            calculator.triangleArea(10, 40);
        }
        [TestMethod]
        [TestCategory("Angle")]
        public void CalcAngle()
        {
            Calculator calculator = new Calculator();
            calculator.triangleArea(10, 40);
        }

    }
}
