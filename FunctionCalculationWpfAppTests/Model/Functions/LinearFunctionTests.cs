using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculationWpfApp.Model.Functions.Tests
{
    /// <summary>
    /// Класс тестирования класса <see cref="LinearFunction"/>.
    /// </summary>
    [TestClass()]
    public class LinearFunctionTests
    {
        /// <summary>
        /// Тестирует метод <see cref="LinearFunction.Calculate(double, double)"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <param name="expected">Ожидаемое значение функции.</param>
        [TestMethod()]
        //Тестирует с нулями.
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
        //Тестирует с отрицательными значениями.
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
        //Тестирует с неравномерными значениями.
        [DataRow(100, 10, 1, 10, 10, 1011)]
        [DataRow(10, 100, 1, 10, 10, 201)]
        [DataRow(10, 10, 1, 100, 10, 1011)]
        [DataRow(10, 10, 1, 10, 100, 111)]
        [DataRow(100, 10, 1, 10, 100, 1011)]
        [DataRow(10, 100, 1, 100, 10, 1101)]
        [DataRow(100, 10, 1, 100, 10, 10011)]
        [DataRow(10, 100, 1, 10, 100, 201)]
        [DataRow(10, 10, 1, 100, 100, 1011)]
        [DataRow(100, 100, 1, 10, 10, 1101)]
        [DataRow(100, 100, 1, 100, 10, 10101)]
        [DataRow(100, 100, 1, 10, 100, 1101)]
        [DataRow(10, 100, 1, 100, 100, 1101)]
        [DataRow(100, 10, 1, 100, 100, 10011)]
        //Тестирует коэффициента c.
        [DataRow(0, 0, 2, 0, 0, 2)]
        [DataRow(0, 0, 3, 0, 0, 3)]
        [DataRow(0, 0, 4, 0, 0, 4)]
        [DataRow(0, 0, 5, 0, 0, 5)]
        public void CalculateTest(double a, double b, double c, double x, double y,
            double expected)
        {
            LinearFunction function = new LinearFunction(a, b, c);
            double actual = function.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}