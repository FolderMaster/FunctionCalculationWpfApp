using FunctionCalculationWpfApp.Model.Functions;

namespace FunctionCalculationWpfApp.Model
{
    /// <summary>
    /// Класс расчёта с функцией, параметрами x, y и значением функции.
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// Параметр x.
        /// </summary>
        private double _x;

        /// <summary>
        /// Параметр y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Функция.
        /// </summary>
        private Function? _function;

        /// <summary>
        /// Возвращает и задаёт функцию.
        /// </summary>
        public Function? Function
        {
            get => _function;
            set => _function = value;
        }

        /// <summary>
        /// Возвращает значение функции.
        /// </summary>
        public double? FunctionValue
        {
            get => _function != null ? _function.Calculate(X, Y) : null;
        }

        /// <summary>
        /// Возвращает и задаёт параметр x.
        /// </summary>
        public double X
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Возвращает и задаёт параметр y.
        /// </summary>
        public double Y
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Calculation"/> по умолчанию.
        /// </summary>
        public Calculation() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Calculation"/>.
        /// </summary>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        public Calculation(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}