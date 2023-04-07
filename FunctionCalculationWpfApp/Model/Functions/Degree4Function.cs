using System;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс функции 4 степени типа "f(x, y) = a * x ^ 4 + b * y ^ 3 + c" с коэффициентами a, b,
    /// c, значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>.
    /// Реализует <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class Degree4Function : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 1000, 2000, 3000, 4000, 5000 };

        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Degree4Function"/> по умолчанию.
        /// </summary>
        public Degree4Function() : base()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Degree4Function"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public Degree4Function(double a, double b, double c) : base(a, b, c) {}

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 4) + B * Math.Pow(y, 3) + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "4 degree";
    }
}