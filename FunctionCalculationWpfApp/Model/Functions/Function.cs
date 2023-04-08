using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Specialized;

namespace FunctionCalculationWpfApp.Model.Functions
{
    /// <summary>
    /// Абстрактный класс функции с коэффициентами a, b, c, значениями для коэффициента c и
    /// расчётами. Реализует <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public abstract class Function : INotifyPropertyChanged
    {
        /// <summary>
        /// Расчёты.
        /// </summary>
        private readonly ObservableCollection<Calculation> _calculations =
            new ObservableCollection<Calculation>();

        /// <summary>
        /// Коэффициент a.
        /// </summary>
        private double _a;

        /// <summary>
        /// Коэффициент b.
        /// </summary>
        private double _b;

        /// <summary>
        /// Коэффициент c.
        /// </summary>
        private double _c;

        /// <summary>
        /// Возвращает и задаёт коэффициент a.
        /// </summary>
        public double A
        {
            get => _a;
            set
            {
                if (A != value)
                {
                    _a = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(A)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт коэффициент b.
        /// </summary>
        public double B
        {
            get => _b;
            set
            {
                if (B != value)
                {
                    _b = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(B)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт коэффициент c. Должно быть из <see cref="CValues"/>.
        /// </summary>
        public double C
        {
            get => _c;
            set
            {
                if (!CValues.Contains(value))
                {
                    throw new ArgumentException();
                }
                if (C != value)
                {
                    _c = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(C)));
                }
            }
        }

        /// <summary>
        /// Возвращает значения для коэффициента c.
        /// </summary>
        public abstract double[] CValues { get; }

        /// <summary>
        /// Возвращает расчёты.
        /// </summary>
        public ObservableCollection<Calculation> Calculations => _calculations;

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Function"/> по умолчанию.
        /// </summary>
        public Function()
        {
            _calculations.CollectionChanged += Calculations_CollectionChanged;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Function"/>.
        /// </summary>
        /// <param name="a">Коэффициент a.</param>
        /// <param name="b">Коэффициент b.</param>
        /// <param name="c">Коэффициент c.</param>
        public Function(double a, double b, double c) : this()
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Рассчитывает значение функции с параметрами x, y.
        /// </summary>
        /// <param name="x">Параметр x.</param>
        /// <param name="y">Параметр y.</param>
        /// <returns>Значение функции с параметрами x, y.</returns>
        public abstract double Calculate(double x, double y);

        private void Calculations_CollectionChanged(object? sender,
            NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Calculations[e.NewStartingIndex].Function = this;
            }
        }
    }
}