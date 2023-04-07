using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    [TestClass()]
    public class QuadraticFunctionTests
    {
        [TestMethod()]
        [DataRow(0, 0, 10, 0, 0, 10)]
        [DataRow(10, 0, 10, 0, 0, 10)]
        [DataRow(0, 10, 10, 0, 0, 10)]
        [DataRow(0, 0, 10, 10, 0, 10)]
        [DataRow(0, 0, 10, 0, 10, 10)]
        [DataRow(10, 0, 10, 0, 10, 10)]
        [DataRow(0, 10, 10, 10, 0, 10)]
        [DataRow(10, 0, 10, 10, 0, 1010)]
        [DataRow(0, 10, 10, 0, 10, 110)]
        [DataRow(0, 0, 10, 10, 10, 10)]
        [DataRow(10, 10, 10, 0, 0, 10)]
        [DataRow(10, 10, 10, 10, 0, 1010)]
        [DataRow(10, 10, 10, 0, 10, 110)]
        [DataRow(0, 10, 10, 10, 10, 110)]
        [DataRow(10, 0, 10, 10, 10, 1010)]
        [DataRow(10, 10, 10, 10, 10, 1110)]

        [DataRow(-10, 10, 10, 10, 10, -890)]
        [DataRow(10, -10, 10, 10, 10, 910)]
        [DataRow(10, 10, 10, -10, 10, 1110)]
        [DataRow(10, 10, 10, 10, -10, 910)]
        [DataRow(-10, 10, 10, 10, -10, -1090)]
        [DataRow(10, -10, 10, -10, 10, 910)]
        [DataRow(-10, 10, 10, -10, 10, -890)]
        [DataRow(10, -10, 10, 10, -10, 1110)]
        [DataRow(10, 10, 10, -10, -10, 910)]
        [DataRow(-10, -10, 10, 10, 10, -1090)]
        [DataRow(-10, -10, 10, -10, 10, -1090)]
        [DataRow(-10, -10, 10, 10, -10, -890)]
        [DataRow(10, -10, 10, -10, -10, 1110)]
        [DataRow(-10, 10, 10, -10, -10, -1090)]
        [DataRow(-10, -10, 10, -10, -10, -890)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            QuadraticFunction function = new QuadraticFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}