using System.Windows;

using FunctionCalculationWpfApp.ViewModel;

namespace FunctionCalculationWpfApp.View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainWindow"/> по умолчанию.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainVM();
        }
    }
}