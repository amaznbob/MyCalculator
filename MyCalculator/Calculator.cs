
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace MyCalculator
{
    public class Calculator
    {
        enum triangleType { scalene, isosceles, equilateral, noTriangle };
        public double triangleHypotenuse(double sideA, double sideB)
        {
            return ((sideA * sideA) + (sideB * sideB));
            
        }
        public double triangleHypException(double sideA, double sideB)
        {
            return ((sideA * sideA) + (sideB * sideB));
        }

        public double triangleArea(double height, double base_)
        {
            return (0.5) * height * base_;    //area of triangle formula
        }
        public double triangleAreaException(double height, double base_)
        {
            return (0.5) * height * base_;    //area of triangle formula
        }
        public double triangleAngle(double angle1, double angle2)
        {
            return 180 - angle1 - angle2;    //area of triangle formula
        }
        public double triangleAngleException(double angle1, double angle2)
        {
            return 180 - angle1 - angle2;    //area of triangle formula
        }

        public int Add(int first, int second)
        {
            return first + second;
        }
        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }
        public int test(int dividend, int divisor )
        {
            var calculator = new Calculator();
            int result = 0;
            try
            {
                result = calculator.Divide(dividend, divisor);
            }
                catch (DivideByZeroException)
            {
                return int.MaxValue;
            }

            catch (Exception)
            {
                result = int.MinValue;
            }
            return dividend/divisor;
        }
    }
}
