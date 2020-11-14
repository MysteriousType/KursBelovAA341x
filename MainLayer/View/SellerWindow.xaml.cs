using MainLayer.View;
using MainLayer.ViewModel;
using System.Diagnostics;
using System.Windows;

namespace WPFApplication01
{
    public interface ISellerWindowCodeBehind
    {
        void LoadView(ViewType typeView);
    }

    public enum ViewType
    {
        First,
        Second,
        Logout1,
        Logout2
    }

    public partial class SellerWindow : Window, ISellerWindowCodeBehind
    {
        public SellerWindow()
        {
            InitializeComponent();

            Loaded += WindowSetup;
        }

        // Строгая реализация
        private void WindowSetup(object sender, RoutedEventArgs e)
        {
            SellerWindowVM vm = new SellerWindowVM();
            vm.CodeBehind = this;
            DataContext = vm;

            LoadView(ViewType.First);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.First:
                    SellerUC1 viewF = new SellerUC1();
                    SellerUC1VM vmF = new SellerUC1VM(this);
                    viewF.DataContext = vmF;
                    OutputView.Content = viewF;
                    break;
                case ViewType.Second:
                    SellerUC2 viewS = new SellerUC2();
                    SellerUC2VM vmS = new SellerUC2VM(this);
                    viewS.DataContext = vmS;
                    OutputView.Content = viewS;
                    break;
                case ViewType.Logout1:
                    SellerLogoutUC1 viewL1 = new SellerLogoutUC1();
                    SellerLogoutUC1VM vmL1 = new SellerLogoutUC1VM(this);
                    viewL1.DataContext = vmL1;
                    OutputView.Content = viewL1;
                    break;
                case ViewType.Logout2:
                    SellerLogoutUC2 viewL2 = new SellerLogoutUC2();
                    SellerLogoutUC2VM vmL2 = new SellerLogoutUC2VM(this);
                    viewL2.DataContext = vmL2;
                    OutputView.Content = viewL2;
                    break;
                default:
                    Debug.Fail("Can't load any page because typeView is unknown. SellerWindow.xaml.cs");
                    break;
            }
        }
    }
}
