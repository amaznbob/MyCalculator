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
            calculator.Divide(10, 0);
        }
        [TestMethod]
        [TestCategory("Hypotenuse")]
        public void CalcHypotenuse()
        {
            Calculator calculator = new Calculator();
            double hyp = calculator.triangleHypotenuse(20, 40);
            Assert.AreEqual(2000, hyp);

        }
        [TestMethod]
        [TestCategory("HypotenuseException")]
        public void CalcHypException()
        {
            Calculator calculator = new Calculator();
            double hyp = calculator.triangleHypException(20, 30);
            Assert.AreNotEqual(2000, hyp);
        }

        [TestMethod]
        [TestCategory("Area")]
        public void CalcArea()
        {
            Calculator calculator = new Calculator();
            double area = calculator.triangleArea(10, 40);
            Assert.AreEqual(200, area);

        }
        [TestMethod]
        [TestCategory("AreaException")]
        public void CalcAreaException()
        {
            Calculator calculator = new Calculator();
            double area = calculator.triangleAreaException(10, 30);
            Assert.AreNotEqual(200, area);


        }
        [TestMethod]
        [TestCategory("Angle")]
        public void CalcAngle()
        {
            Calculator calculator = new Calculator();
            double angle = calculator.triangleAngle(10, 40);
            Assert.AreEqual(130, angle);

        }
        [TestMethod]
        [TestCategory("AngleException")]
        public void CalcAngleException()
        {
            Calculator calculator = new Calculator();
            double angle = calculator.triangleAngleException(20, 40);
            Assert.AreNotEqual(130, angle);
        }
    }
}
