using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    [TestClass()]
    public class Degree5FunctionTests
    {
        [TestMethod()]
        [DataRow(0, 0, 10000, 0, 0, 10000)]
        [DataRow(10, 0, 10000, 0, 0, 10000)]
        [DataRow(0, 10, 10000, 0, 0, 10000)]
        [DataRow(0, 0, 10000, 10, 0, 10000)]
        [DataRow(0, 0, 10000, 0, 10, 10000)]
        [DataRow(10, 0, 10000, 0, 10, 10000)]
        [DataRow(0, 10, 10000, 10, 0, 10000)]
        [DataRow(10, 0, 10000, 10, 0, 1010000)]
        [DataRow(0, 10, 10000, 0, 10, 110000)]
        [DataRow(0, 0, 10000, 10, 10, 10000)]
        [DataRow(10, 10, 10000, 0, 0, 10000)]
        [DataRow(10, 10, 10000, 10, 0, 1010000)]
        [DataRow(10, 10, 10000, 0, 10, 110000)]
        [DataRow(0, 10, 10000, 10, 10, 110000)]
        [DataRow(10, 0, 10000, 10, 10, 1010000)]
        [DataRow(10, 10, 10000, 10, 10, 1110000)]

        [DataRow(-10, 10, 10000, 10, 10, -890000)]
        [DataRow(10, -10, 10000, 10, 10, 910000)]
        [DataRow(10, 10, 10000, -10, 10, -890000)]
        [DataRow(10, 10, 10000, 10, -10, 1110000)]
        [DataRow(-10, 10, 10000, 10, -10, -890000)]
        [DataRow(10, -10, 10000, -10, 10, -1090000)]
        [DataRow(-10, 10, 10000, -10, 10, 1110000)]
        [DataRow(10, -10, 10000, 10, -10, 910000)]
        [DataRow(10, 10, 10000, -10, -10, -890000)]
        [DataRow(-10, -10, 10000, 10, 10, -1090000)]
        [DataRow(-10, -10, 10000, -10, 10, 910000)]
        [DataRow(-10, -10, 10000, 10, -10, -1090000)]
        [DataRow(10, -10, 10000, -10, -10, -1090000)]
        [DataRow(-10, 10, 10000, -10, -10, 1110000)]
        [DataRow(-10, -10, 10000, -10, -10, 910000)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            Degree5Function function = new Degree5Function(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}