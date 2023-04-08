using System;
using System.ComponentModel;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс функции 4 степени типа "f(x, y) = a * x ^ 4 + b * y ^ 3 + c" с коэффициентами a, b,
    /// c, значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>.
    /// Реализует <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class FourthDegreeFunction : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 1000, 2000, 3000, 4000, 5000 };

        /// <summary>
        /// Возвращает значения для коэффициента c.
        /// </summary>
        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FourthDegreeFunction"/> по умолчанию.
        /// </summary>
        public FourthDegreeFunction() : base()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FourthDegreeFunction"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public FourthDegreeFunction(double a, double b, double c) : base(a, b, c) {}

        /// <summary>
        /// Рассчитывает значение функции с параметрами x, y.
        /// </summary>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <returns>Значение функции с параметрами x, y.</returns>
        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 4) + B * Math.Pow(y, 3) + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "4 degree";
    }
}