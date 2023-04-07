using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    [TestClass()]
    public class LinearFunctionTests
    {
        [TestMethod()]
        [DataRow(0, 0, 1, 0, 0, 1)]
        [DataRow(10, 0, 1, 0, 0, 1)]
        [DataRow(0, 10, 1, 0, 0, 11)]
        [DataRow(0, 0, 1, 10, 0, 1)]
        [DataRow(0, 0, 1, 0, 10, 1)]
        [DataRow(10, 0, 1, 0, 10, 1)]
        [DataRow(0, 10, 1, 10, 0, 11)]
        [DataRow(10, 0, 1, 10, 0, 101)]
        [DataRow(0, 10, 1, 0, 10, 11)]
        [DataRow(0, 0, 1, 10, 10, 1)]
        [DataRow(10, 10, 1, 0, 0, 11)]
        [DataRow(10, 10, 1, 10, 0, 111)]
        [DataRow(10, 10, 1, 0, 10, 11)]
        [DataRow(0, 10, 1, 10, 10, 11)]
        [DataRow(10, 0, 1, 10, 10, 101)]
        [DataRow(10, 10, 1, 10, 10, 111)]

        [DataRow(-10, 10, 1, 10, 10, -89)]
        [DataRow(10, -10, 1, 10, 10, 91)]
        [DataRow(10, 10, 1, -10, 10, -89)]
        [DataRow(10, 10, 1, 10, -10, 111)]
        [DataRow(-10, 10, 1, 10, -10, -89)]
        [DataRow(10, -10, 1, -10, 10, -109)]
        [DataRow(-10, 10, 1, -10, 10, 111)]
        [DataRow(10, -10, 1, 10, -10, 91)]
        [DataRow(10, 10, 1, -10, -10, -89)]
        [DataRow(-10, -10, 1, 10, 10, -109)]
        [DataRow(-10, -10, 1, -10, 10, 91)]
        [DataRow(-10, -10, 1, 10, -10, -109)]
        [DataRow(10, -10, 1, -10, -10, -109)]
        [DataRow(-10, 10, 1, -10, -10, 111)]
        [DataRow(-10, -10, 1, -10, -10, 91)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            LinearFunction function = new LinearFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}