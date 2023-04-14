using System;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс кубической функции типа "f(x, y) = a * x ^ 3 + b * y ^ 2 + c" с коэффициентами a, b,
    /// c, значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>.
    /// </summary>
    public class CubicFunction : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 100, 200, 300, 400, 500 };

        /// <summary>
        /// Возвращает значения для коэффициента c.
        /// </summary>
        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CubicFunction"/> по умолчанию.
        /// </summary>
        public CubicFunction()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CubicFunction"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public CubicFunction(double a, double b, double c) : base(a, b, c) {}

        /// <summary>
        /// Рассчитывает значение функции с параметрами x, y.
        /// </summary>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <returns>Значение функции с параметрами x, y.</returns>
        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 3) + B * Math.Pow(y, 2) + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "Cubic";
    }
}