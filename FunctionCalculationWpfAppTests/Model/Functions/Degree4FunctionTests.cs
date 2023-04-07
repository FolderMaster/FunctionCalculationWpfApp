using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    [TestClass()]
    public class Degree4FunctionTests
    {
        [TestMethod()]
        [DataRow(0, 0, 1000, 0, 0, 1000)]
        [DataRow(10, 0, 1000, 0, 0, 1000)]
        [DataRow(0, 10, 1000, 0, 0, 1000)]
        [DataRow(0, 0, 1000, 10, 0, 1000)]
        [DataRow(0, 0, 1000, 0, 10, 1000)]
        [DataRow(10, 0, 1000, 0, 10, 1000)]
        [DataRow(0, 10, 1000, 10, 0, 1000)]
        [DataRow(10, 0, 1000, 10, 0, 101000)]
        [DataRow(0, 10, 1000, 0, 10, 11000)]
        [DataRow(0, 0, 1000, 10, 10, 1000)]
        [DataRow(10, 10, 1000, 0, 0, 1000)]
        [DataRow(10, 10, 1000, 10, 0, 101000)]
        [DataRow(10, 10, 1000, 0, 10, 11000)]
        [DataRow(0, 10, 1000, 10, 10, 11000)]
        [DataRow(10, 0, 1000, 10, 10, 101000)]
        [DataRow(10, 10, 1000, 10, 10, 111000)]

        [DataRow(-10, 10, 1000, 10, 10, -89000)]
        [DataRow(10, -10, 1000, 10, 10, 91000)]
        [DataRow(10, 10, 1000, -10, 10, 111000)]
        [DataRow(10, 10, 1000, 10, -10, 91000)]
        [DataRow(-10, 10, 1000, 10, -10, -109000)]
        [DataRow(10, -10, 1000, -10, 10, 91000)]
        [DataRow(-10, 10, 1000, -10, 10, -89000)]
        [DataRow(10, -10, 1000, 10, -10, 111000)]
        [DataRow(10, 10, 1000, -10, -10, 91000)]
        [DataRow(-10, -10, 1000, 10, 10, -109000)]
        [DataRow(-10, -10, 1000, -10, 10, -109000)]
        [DataRow(-10, -10, 1000, 10, -10, -89000)]
        [DataRow(10, -10, 1000, -10, -10, 111000)]
        [DataRow(-10, 10, 1000, -10, -10, -109000)]
        [DataRow(-10, -10, 1000, -10, -10, -89000)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            Degree4Function function = new Degree4Function(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}