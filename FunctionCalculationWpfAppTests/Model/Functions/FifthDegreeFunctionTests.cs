using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    /// <summary>
    /// Класс тестирования класса <see cref="FifthDegreeFunction"/>.
    /// </summary>
    [TestClass()]
    public class FifthDegreeFunctionTests
    {
        /// <summary>
        /// Тестирует метод <see cref="FifthDegreeFunction.Calculate(double, double)"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <param name="expected">Ожидаемое значение функции.</param>
        [TestMethod()]
        //Тестирует с нулями.
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
        //Тестирует с отрицательными значениями.
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
        //Тестирует с неравномерными значениями.
        [DataRow(100, 10, 10000, 10, 10, 10110000)]
        [DataRow(10, 100, 10000, 10, 10, 2010000)]
        [DataRow(10, 10, 10000, 100, 10, 100000110000)]
        [DataRow(10, 10, 10000, 10, 100, 1001010000)]
        [DataRow(100, 10, 10000, 10, 100, 1010010000)]
        [DataRow(10, 100, 10000, 100, 10, 100001010000)]
        [DataRow(100, 10, 10000, 100, 10, 1000000110000)]
        [DataRow(10, 100, 10000, 10, 100, 10001010000)]
        [DataRow(10, 10, 10000, 100, 100, 101000010000)]
        [DataRow(100, 100, 10000, 10, 10, 11010000)]
        [DataRow(100, 100, 10000, 100, 10, 1000001010000)]
        [DataRow(100, 100, 10000, 10, 100, 10010010000)]
        [DataRow(10, 100, 10000, 100, 100, 110000010000)]
        [DataRow(100, 10, 10000, 100, 100, 1001000010000)]
        //Тестирует коэффициента c.
        [DataRow(0, 0, 20000, 0, 0, 20000)]
        [DataRow(0, 0, 30000, 0, 0, 30000)]
        [DataRow(0, 0, 40000, 0, 0, 40000)]
        [DataRow(0, 0, 50000, 0, 0, 50000)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            // Если не через var, значит, dynamic?
            dynamic function = new FifthDegreeFunction(a, b, c);
            dynamic actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}