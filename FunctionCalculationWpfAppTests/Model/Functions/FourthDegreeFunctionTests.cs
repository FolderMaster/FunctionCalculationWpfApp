using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    /// <summary>
    /// Класс тестирования класса <see cref="FourthDegreeFunction"/>.
    /// </summary>
    [TestClass()]
    public class FourthDegreeFunctionTests
    {
        /// <summary>
        /// Тестирует метод <see cref="FourthDegreeFunction.Calculate(double, double)"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <param name="expected">Ожидаемое значение функции.</param>
        [TestMethod()]
        //Тестирует с нулями.
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
        //Тестирует с отрицательными значениями.
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
        //Тестирует с неравномерными значениями.
        [DataRow(100, 10, 1000, 10, 10, 1011000)]
        [DataRow(10, 100, 1000, 10, 10, 201000)]
        [DataRow(10, 10, 1000, 100, 10, 1000011000)]
        [DataRow(10, 10, 1000, 10, 100, 10101000)]
        [DataRow(100, 10, 1000, 10, 100, 11001000)]
        [DataRow(10, 100, 1000, 100, 10, 1000101000)]
        [DataRow(100, 10, 1000, 100, 10, 10000011000)]
        [DataRow(10, 100, 1000, 10, 100, 100101000)]
        [DataRow(10, 10, 1000, 100, 100, 1010001000)]
        [DataRow(100, 100, 1000, 10, 10, 1101000)]
        [DataRow(100, 100, 1000, 100, 10, 10000101000)]
        [DataRow(100, 100, 1000, 10, 100, 101001000)]
        [DataRow(10, 100, 1000, 100, 100, 1100001000)]
        [DataRow(100, 10, 1000, 100, 100, 10010001000)]
        //Тестирует коэффициента c.
        [DataRow(0, 0, 2000, 0, 0, 2000)]
        [DataRow(0, 0, 3000, 0, 0, 3000)]
        [DataRow(0, 0, 4000, 0, 0, 4000)]
        [DataRow(0, 0, 5000, 0, 0, 5000)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            FourthDegreeFunction function = new FourthDegreeFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}