using System.ComponentModel;

namespace FunctionCalculationWpfApp.Model
{
    public class Calculation : INotifyPropertyChanged
    {
        private double _x;

        private double _y;

        private Function? _function;

        public Function? Function
        {
            get => _function;
            set
            {
                if (Function != value)
                {
                    if(Function != null)
                    {
                        _function.PropertyChanged -= _function_PropertyChanged;
                    }
                    _function = value;
                    if (Function != null)
                    {
                        _function.PropertyChanged += _function_PropertyChanged;
                    }
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Function)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(FunctionValue)));
                }
            }
        }

        public double? FunctionValue
        {
            get => _function != null ? _function.Calculate(X, Y) : null;
        }

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

        public event PropertyChangedEventHandler? PropertyChanged;

        private void _function_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nameof(FunctionValue)));
        }
    }
}