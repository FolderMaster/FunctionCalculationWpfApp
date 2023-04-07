using System.ComponentModel;

using FunctionCalculationWpfApp.Model.Functions;

namespace FunctionCalculationWpfApp.Model
{
    /// <summary>
    /// Класс расчёта с функцией, параметрами x, y и значением функции. Реализует
    /// <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class Calculation : INotifyPropertyChanged
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
            set
            {
                if (Function != value)
                {
                    if(Function != null)
                    {
                        Function.PropertyChanged -= Function_PropertyChanged;
                    }
                    _function = value;
                    if (Function != null)
                    {
                        Function.PropertyChanged += Function_PropertyChanged;
                    }
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Function)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(FunctionValue)));
                }
            }
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
            set
            {
                if (X != value)
                {
                    _x = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(X)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(FunctionValue)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт параметр y.
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                if (Y != value)
                {
                    _y = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Y)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(FunctionValue)));
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

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

        private void Function_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nameof(FunctionValue)));
        }
    }
}