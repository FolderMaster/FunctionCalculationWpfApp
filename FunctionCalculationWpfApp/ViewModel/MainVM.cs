using System.Collections.Generic;
using System.ComponentModel;

using FunctionCalculationWpfApp.Model.Functions;
using FunctionCalculationWpfApp.View;

namespace FunctionCalculationWpfApp.ViewModel
{
    /// <summary>
    /// Класс логики обработки процессов основного окна приложения <see cref="MainWindow"/> с
    /// функциями и выбранной функцией. Реализует <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Функции.
        /// </summary>
        private List<Function>? _functions = null;

        /// <summary>
        /// Выбранная функция.
        /// </summary>
        private Function? _selectedFunction = null;

        /// <summary>
        /// Возвращает и задаёт функции.
        /// </summary>
        public List<Function>? Functions
        {
            get => _functions;
            set
            {
                if(Functions != value)
                {
                    _functions = value;
                    if(Functions != null)
                    {
                        SelectedFunction = Functions.Count > 0 ? Functions[0] : null;
                    }
                    else
                    {
                        SelectedFunction = null;
                    }
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Functions)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранную функцию.
        /// </summary>
        public Function? SelectedFunction
        {
            get => _selectedFunction;
            set
            {
                if(SelectedFunction != value)
                {
                    _selectedFunction = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(SelectedFunction)));
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/> по умолчанию.
        /// </summary>
        public MainVM()
        {
            Functions = new List<Function>()
            {
                new LinearFunction(), new QuadraticFunction(), new CubicFunction(),
                new FourthDegreeFunction(), new FifthDegreeFunction()
            };
        }
    }
}