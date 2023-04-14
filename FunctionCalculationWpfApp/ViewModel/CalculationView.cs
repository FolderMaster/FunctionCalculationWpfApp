using System.ComponentModel;

using FunctionCalculationWpfApp.Model;

namespace FunctionCalculationWpfApp.ViewModel
{
    /// <summary>
    /// Класс представления класса расчёта <see cref="Model.Calculation"/> c строковыми
    /// представление параметров x, y, значением функции и расчётом. Реализует
    /// <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class CalculationView : INotifyPropertyChanged
    {
        /// <summary>
        /// Строковое представление параметра x.
        /// </summary>
        private string _xString;

        /// <summary>
        /// Строковое представление параметра y.
        /// </summary>
        private string _yString;

        /// <summary>
        /// Расчёт.
        /// </summary>
        private Calculation? _calculation;

        /// <summary>
        /// Возвращает и задаёт расчёт.
        /// </summary>
        public Calculation? Calculation
        {
            get => _calculation;
            set => _calculation = value;
        }

        /// <summary>
        /// Возвращает значение функции.
        /// </summary>
        public double? FunctionValue
        {
            get => Calculation != null ? Calculation.FunctionValue : null;
        }

        /// <summary>
        /// Возвращает и задаёт строковое представление параметра x.
        /// </summary>
        public string XString
        {
            get => _xString;
            set
            {
                double parsedValue;
                if (double.TryParse(value, out parsedValue))
                {
                    if (Calculation != null)
                    {
                        Calculation.X = parsedValue;
                        PropertyChanged?.Invoke(this,
                            new PropertyChangedEventArgs(nameof(FunctionValue)));
                    }
                    _xString = value;
                }
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(XString)));
            }
        }

        /// <summary>
        /// Возвращает и задаёт строковое представление параметра y.
        /// </summary>
        public string YString
        {
            get => _yString;
            set
            {
                double parsedValue;
                if (double.TryParse(value, out parsedValue))
                {
                    if(Calculation != null)
                    {
                        Calculation.Y = parsedValue;
                        PropertyChanged?.Invoke(this,
                            new PropertyChangedEventArgs(nameof(FunctionValue)));
                    }
                    _yString = value;
                }
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(YString)));
            }
        }

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CalculationView"/> по умолчанию.
        /// </summary>
        public CalculationView() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CalculationView"/>.
        /// </summary>
        /// <param name="calculation">Расчёт.</param>
        public CalculationView(Calculation calculation)
        {
            _calculation = calculation;
            XString = Calculation.X.ToString();
            YString = Calculation.Y.ToString();
        }
    }
}
