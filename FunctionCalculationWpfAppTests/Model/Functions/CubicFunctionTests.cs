using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    /// <summary>
    /// Класс тестирования класса <see cref="CubicFunction"/>.
    /// </summary>
    [TestClass()]
    public class CubicFunctionTests
    {
        /// <summary>
        /// Тестирует метод <see cref="CubicFunction.Calculate(double, double)"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <param name="expected">Ожидаемое значение функции.</param>
        [TestMethod()]
        //Тестирует с нулями.
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
        //Тестирует с отрицательными значениями.
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
        //Тестирует с неравномерными значениями.
        [DataRow(100, 10, 100, 10, 10, 101100)]
        [DataRow(10, 100, 100, 10, 10, 20100)]
        [DataRow(10, 10, 100, 100, 10, 10001100)]
        [DataRow(10, 10, 100, 10, 100, 110100)]
        [DataRow(100, 10, 100, 10, 100, 200100)]
        [DataRow(10, 100, 100, 100, 10, 10010100)]
        [DataRow(100, 10, 100, 100, 10, 100001100)]
        [DataRow(10, 100, 100, 10, 100, 1010100)]
        [DataRow(10, 10, 100, 100, 100, 10100100)]
        [DataRow(100, 100, 100, 10, 10, 110100)]
        [DataRow(100, 100, 100, 100, 10, 100010100)]
        [DataRow(100, 100, 100, 10, 100, 1100100)]
        [DataRow(10, 100, 100, 100, 100, 11000100)]
        [DataRow(100, 10, 100, 100, 100, 100100100)]
        //Тестирует коэффициента c.
        [DataRow(0, 0, 200, 0, 0, 200)]
        [DataRow(0, 0, 300, 0, 0, 300)]
        [DataRow(0, 0, 400, 0, 0, 400)]
        [DataRow(0, 0, 500, 0, 0, 500)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            CubicFunction function = new CubicFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}