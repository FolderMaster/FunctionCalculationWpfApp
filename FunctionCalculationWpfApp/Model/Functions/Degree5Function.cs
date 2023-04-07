using System;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс функции 5 степени типа "f(x, y) = a * x ^ 5 + b * y ^ 4 + c" с коэффициентами a, b,
    /// c, значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>.
    /// Реализует <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class Degree5Function : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 10000, 20000, 30000, 40000, 50000 };

        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Degree5Function"/> по умолчанию.
        /// </summary>
        public Degree5Function() : base()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Degree5Function"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public Degree5Function(double a, double b, double c) : base(a, b, c) {}

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 5) + B * Math.Pow(y, 4) + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "5 degree";
    }
}