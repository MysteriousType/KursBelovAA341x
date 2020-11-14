using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using WPFApplication01;

namespace MainLayer.ViewModel
{
    public class SellerWindowVM : INotifyPropertyChanged
    {
        public ISellerWindowCodeBehind CodeBehind { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int deleteme;

        private string _titleText = "СУ Автовокзала. Продавец Флорова А.А.";
        public string TitleText
        {
            get => _titleText;
            set
            {
                _titleText = value;
            }
        }

        private bool _racesButtonsEnabled = true;
        public bool RacesButtonsEnabled
        {
            get => _racesButtonsEnabled;
            set
            {
                if (_racesButtonsEnabled != value)
                {
                    _racesButtonsEnabled = value;
                    OnPropertyChanged("RacesButtonsEnabled");
                }
            }
        }

        /// <summary>
        /// Цель RelayCommand состоит в том, чтобы реализовать интерфейс ICommand 
        /// который необходим кнопочным элементам управления, и просто передать вызовы на какую-то другую функцию, 
        /// которая обычно находится в этом же классе VM
        /// </summary>
        private RelayCommand _loadFirstPage = null;
        public RelayCommand LoadFirstPage
        {
            get
            {
                return _loadFirstPage = _loadFirstPage ?? new RelayCommand(OnLoadFirstPage, true);
            }
        }

        private void OnLoadFirstPage()
        {
            RacesButtonsEnabled = true;

            CodeBehind.LoadView(ViewType.First);
        }

        private RelayCommand _loadSecondPage = null;
        public RelayCommand LoadSecondPage
        {
            get
            {
                return _loadSecondPage = _loadSecondPage ?? new RelayCommand(OnLoadSecondPage, true);
            }
        }

        private void OnLoadSecondPage()
        {
            CodeBehind.LoadView(ViewType.Second);
        }

        private RelayCommand _loadLogoutPage1 = null;
        public RelayCommand LoadLogoutPage1
        {
            get
            {
                return _loadLogoutPage1 = _loadLogoutPage1 ?? new RelayCommand(OnLoadLogoutPage1, true);
            }
        }

        private void OnLoadLogoutPage1()
        {
            RacesButtonsEnabled = false;

            CodeBehind.LoadView(ViewType.Logout1);
        }

        private RelayCommand _loadLogoutPage2 = null;
        public RelayCommand LoadLogoutPage2
        {
            get
            {
                return _loadLogoutPage2 = _loadLogoutPage2 ?? new RelayCommand(OnLoadLogoutPage2, true);
            }
        }

        private void OnLoadLogoutPage2()
        {
            RacesButtonsEnabled = false;

            CodeBehind.LoadView(ViewType.Logout2);
        }
    }
}
