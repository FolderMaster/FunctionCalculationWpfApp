using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    /// <summary>
    /// Класс тестирования класса <see cref="QuadraticFunction"/>.
    /// </summary>
    [TestClass()]
    public class QuadraticFunctionTests
    {
        /// <summary>
        /// Тестирует метод <see cref="QuadraticFunction.Calculate(double, double)"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <param name="expected">Ожидаемое значение функции.</param>
        [TestMethod()]
        //Тестирует с нулями.
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
        //Тестирует с отрицательными значениями.
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
        //Тестирует с неравномерными значениями.
        [DataRow(100, 10, 10, 10, 10, 10110)]
        [DataRow(10, 100, 10, 10, 10, 2010)]
        [DataRow(10, 10, 10, 100, 10, 100110)]
        [DataRow(10, 10, 10, 10, 100, 2010)]
        [DataRow(100, 10, 10, 10, 100, 11010)]
        [DataRow(10, 100, 10, 100, 10, 101010)]
        [DataRow(100, 10, 10, 100, 10, 1000110)]
        [DataRow(10, 100, 10, 10, 100, 11010)]
        [DataRow(10, 10, 10, 100, 100, 101010)]
        [DataRow(100, 100, 10, 10, 10, 11010)]
        [DataRow(100, 100, 10, 100, 10, 1001010)]
        [DataRow(100, 100, 10, 10, 100, 20010)]
        [DataRow(10, 100, 10, 100, 100, 110010)]
        [DataRow(100, 10, 10, 100, 100, 1001010)]
        //Тестирует коэффициента c.
        [DataRow(0, 0, 20, 0, 0, 20)]
        [DataRow(0, 0, 30, 0, 0, 30)]
        [DataRow(0, 0, 40, 0, 0, 40)]
        [DataRow(0, 0, 50, 0, 0, 50)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            // Если не через var, значит, dynamic?
            dynamic function = new QuadraticFunction(a, b, c);
            dynamic actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}