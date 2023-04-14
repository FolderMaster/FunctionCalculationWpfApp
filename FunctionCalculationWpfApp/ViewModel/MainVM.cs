using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

using FunctionCalculationWpfApp.Model;
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
        /// Строковое представление коэффициента a.
        /// </summary>
        private string _aString;

        /// <summary>
        /// Строковое представление коэффициента b.
        /// </summary>
        private string _bString;

        /// <summary>
        /// Расчёты.
        /// </summary>
        private ObservableCollection<Calculation> _calculations;

        /// <summary>
        /// Представления расчётов.
        /// </summary>
        private ObservableCollection<CalculationView> _calculationViews;

        /// <summary>
        /// Возвращает и задаёт расчёты.
        /// </summary>
        private ObservableCollection<Calculation> Calculations
        {
            get => _calculations;
            set
            {
                _calculations = value;
                UpdateCalculationViews();
            }
        }

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
                    Calculations = SelectedFunction.Calculations;
                    AString = SelectedFunction.A.ToString();
                    BString = SelectedFunction.B.ToString();
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(CValues)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(C)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(SelectedFunction)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт строковое представление коэффициента a.
        /// </summary>
        public string AString
        {
            get => _aString;
            set
            {
                double parsedValue;
                if (double.TryParse(value, out parsedValue))
                {
                    SelectedFunction.A = parsedValue;
                    UpdateCalculationViews();
                    _aString = value;
                }
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(AString)));
            }
        }

        /// <summary>
        /// Возвращает и задаёт строковое представление коэффициента b.
        /// </summary>
        public string BString
        {
            get => _bString;
            set
            {
                double parsedValue;
                if (double.TryParse(value, out parsedValue))
                {
                    SelectedFunction.B = parsedValue;
                    UpdateCalculationViews();
                    _bString = value;
                }
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(BString)));
            }
        }

        /// <summary>
        /// Возвращает и задаёт коэффициент c.
        /// </summary>
        public double C
        {
            get => SelectedFunction.C;
            set
            {
                SelectedFunction.C = value;
                UpdateCalculationViews();
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(C)));
            }
        }

        /// <summary>
        /// Возвращает значения для коэффициента c.
        /// </summary>
        public double[] CValues
        {
            get => SelectedFunction.CValues;
        }

        /// <summary>
        /// Возвращает и задаёт представления расчётов.
        /// </summary>
        public ObservableCollection<CalculationView> CalculationViews
        {
            get => _calculationViews;
            set
            {
                if(CalculationViews != null)
                {
                    CalculationViews.CollectionChanged -= CalculationViews_CollectionChanged;
                }
                _calculationViews = value;
                if (CalculationViews != null)
                {
                    CalculationViews.CollectionChanged += CalculationViews_CollectionChanged;
                }
                PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(CalculationViews)));
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

        /// <summary>
        /// Обновляет представления расчётов.
        /// </summary>
        private void UpdateCalculationViews()
        {
            var calculationViews = new ObservableCollection<CalculationView>();
            foreach (var calculation in Calculations)
            {
                calculationViews.Add(new CalculationView(calculation));
            }
            CalculationViews = calculationViews;
        }

        private void CalculationViews_CollectionChanged(object? sender,
            NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var newCalculation = new Calculation();
                    Calculations.Add(newCalculation);
                    var newCalculationView = CalculationViews[e.NewStartingIndex];
                    newCalculationView.Calculation = newCalculation;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Calculations.RemoveAt(e.OldStartingIndex);
                    break;
            }
        }
    }
}