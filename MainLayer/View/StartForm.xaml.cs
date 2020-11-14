using MainLayer.ViewModel;
using System.Windows;

namespace WPFApplication01
{
    public enum FiledType
    {
        Login,
        Password
    }

    public partial class StartForm : Window
    {
        public StartForm()
        {
            InitializeComponent();

            Loaded += WindowSetup;
        }

        private void WindowSetup(object sender, RoutedEventArgs e)
        {
            StartFormVM vm = new StartFormVM();
            DataContext = vm;
        }
    }
}
