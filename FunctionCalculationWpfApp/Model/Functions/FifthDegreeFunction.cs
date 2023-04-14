using System;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс функции 5 степени типа "f(x, y) = a * x ^ 5 + b * y ^ 4 + c" с коэффициентами a, b,
    /// c, значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>.
    /// </summary>
    public class FifthDegreeFunction : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 10000, 20000, 30000, 40000, 50000 };

        /// <summary>
        /// Возвращает значения для коэффициента c.
        /// </summary>
        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FifthDegreeFunction"/> по умолчанию.
        /// </summary>
        public FifthDegreeFunction() : base()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FifthDegreeFunction"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public FifthDegreeFunction(double a, double b, double c) : base(a, b, c) {}

        /// <summary>
        /// Рассчитывает значение функции с параметрами x, y.
        /// </summary>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <returns>Значение функции с параметрами x, y.</returns>
        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 5) + B * Math.Pow(y, 4) + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "5 degree";
    }
}