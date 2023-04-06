using System.Collections.Generic;
using System.ComponentModel;

using FunctionCalculationWpfApp.Model;

namespace FunctionCalculationWpfApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private List<Function> _functions = new List<Function>()
        { new LinearFunction(), new QuadraticFunction(), new СubicFunction(),
            new Degree4Function(), new Degree5Function() };

        private Function? _selectedFunction = null;

        public List<Function> Functions
        {
            get => _functions;
            set
            {
                if(Functions != value)
                {
                    _functions = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Functions)));
                }
            }
        }

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

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}