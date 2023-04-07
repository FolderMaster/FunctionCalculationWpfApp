using System;
using System.ComponentModel;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс квадратичной функции типа "f(x, y) = a * x ^ 2 + b * y + c" с коэффициентами a, b, c,
    /// значениями для коэффициента c и расчётами. Унаследован от <see cref="Function"/>. Реализует
    /// <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class QuadraticFunction : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 10, 20, 30, 40, 50 };

        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="QuadraticFunction"/> по умолчанию.
        /// </summary>
        public QuadraticFunction()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="QuadraticFunction"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public QuadraticFunction(double a, double b, double c) : base(a, b, c) {}

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 2) + B * y + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "Quadratic";
    }
}