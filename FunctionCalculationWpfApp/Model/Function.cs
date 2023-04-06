using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Specialized;

namespace FunctionCalculationWpfApp.Model
{
    public abstract class Function : INotifyPropertyChanged
    {
        private double _a;

        private double _b;

        private readonly ObservableCollection<Calculation> _calculations = 
            new ObservableCollection<Calculation>();

        protected double _c;

        public double A
        {
            get => _a;
            set
            {
                if(A != value)
                {
                    _a = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(A)));
                }
            }
        }

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

        public double C
        {
            get => _c;
            set
            {
                if(!CValues.Contains(value))
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

        public abstract double[] CValues { get; }

        public abstract double Calculate(double x, double y);

        public ObservableCollection<Calculation> Calculations => _calculations;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Function()
        {
            _calculations.CollectionChanged += _calculations_CollectionChanged;
        }

        private void _calculations_CollectionChanged(object? sender,
            NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                Calculations[e.NewStartingIndex].Function = this;
            }
        }
    }
}