using System.Windows;

using FunctionCalculationWpfApp.ViewModel;

namespace FunctionCalculationWpfApp.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainVM();
        }
    }
}