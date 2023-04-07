using System.ComponentModel;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Класс линейной функции типа "f(x, y) = a * x + b + c" с коэффициентами a, b, c, значениями
    /// для коэффициента c и расчётами. Унаследован от <see cref="Function"/>. Реализует
    /// <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class LinearFunction : Function
    {
        /// <summary>
        /// Значения для коэффициента c.
        /// </summary>
        private static double[] _cValues = new double[] { 1, 2, 3, 4, 5 };

        public override double[] CValues => _cValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LinearFunction"/> по умолчанию.
        /// </summary>
        public LinearFunction() : base()
        {
            C = CValues[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LinearFunction"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public LinearFunction(double a, double b, double c) : base(a, b, c) {}

        public override double Calculate(double x, double y) => A * x + B + C;

        /// <summary>
        /// Возвращает строковое представление класса.
        /// </summary>
        /// <returns>Строковое представление класса.</returns>
        public override string ToString() => "Linear";
    }
}