using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    [TestClass()]
    public class CubicFunctionTests
    {
        [TestMethod()]
        [DataRow(0, 0, 100, 0, 0, 100)]
        [DataRow(10, 0, 100, 0, 0, 100)]
        [DataRow(0, 10, 100, 0, 0, 100)]
        [DataRow(0, 0, 100, 10, 0, 100)]
        [DataRow(0, 0, 100, 0, 10, 100)]
        [DataRow(10, 0, 100, 0, 10, 100)]
        [DataRow(0, 10, 100, 10, 0, 100)]
        [DataRow(10, 0, 100, 10, 0, 10100)]
        [DataRow(0, 10, 100, 0, 10, 1100)]
        [DataRow(0, 0, 100, 10, 10, 100)]
        [DataRow(10, 10, 100, 0, 0, 100)]
        [DataRow(10, 10, 100, 10, 0, 10100)]
        [DataRow(10, 10, 100, 0, 10, 1100)]
        [DataRow(0, 10, 100, 10, 10, 1100)]
        [DataRow(10, 0, 100, 10, 10, 10100)]
        [DataRow(10, 10, 100, 10, 10, 11100)]

        [DataRow(-10, 10, 100, 10, 10, -8900)]
        [DataRow(10, -10, 100, 10, 10, 9100)]
        [DataRow(10, 10, 100, -10, 10, -8900)]
        [DataRow(10, 10, 100, 10, -10, 11100)]
        [DataRow(-10, 10, 100, 10, -10, -8900)]
        [DataRow(10, -10, 100, -10, 10, -10900)]
        [DataRow(-10, 10, 100, -10, 10, 11100)]
        [DataRow(10, -10, 100, 10, -10, 9100)]
        [DataRow(10, 10, 100, -10, -10, -8900)]
        [DataRow(-10, -10, 100, 10, 10, -10900)]
        [DataRow(-10, -10, 100, -10, 10, 9100)]
        [DataRow(-10, -10, 100, 10, -10, -10900)]
        [DataRow(10, -10, 100, -10, -10, -10900)]
        [DataRow(-10, 10, 100, -10, -10, 11100)]
        [DataRow(-10, -10, 100, -10, -10, 9100)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            CubicFunction function = new CubicFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}