using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Windows.Media;

namespace MainLayer.ViewModel
{
    public class StartFormVM : StartFormStyles, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public StartFormVM()
        {
            _textBoxLoginBorderColor = UsualColor();
            _textBoxPasswordBorderColor = UsualColor();

            _textBlockLoginText = UsualText();
            _textBlockPasswordText = UsualText();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Binding вызывает setter и обновляет значение цвета на FF000000 (черный).
        /// Начальное значение (UsualColor) может быть другим, поэтому вводим bool 
        /// переменную для первого вхождения в setter. Первое вхождение - вызов из binding
        /// </summary>
        private bool _textBoxLoginBorderColorBC = true;
        private SolidColorBrush _textBoxLoginBorderColor;
        public SolidColorBrush TextBoxLoginBorderColor
        {
            get => _textBoxLoginBorderColor;
            set
            {
                if (_textBoxLoginBorderColorBC)
                {
                    _textBoxLoginBorderColorBC = false;
                }
                else
                {
                    _textBoxLoginBorderColor = value;
                    OnPropertyChanged(nameof(TextBoxLoginBorderColor));
                }
            }
        }

        private bool _textBoxPasswordBorderColorBC = true;
        private SolidColorBrush _textBoxPasswordBorderColor;
        public SolidColorBrush TextBoxPasswordBorderColor
        {
            get => _textBoxPasswordBorderColor;
            set
            {
                if (_textBoxPasswordBorderColorBC)
                {
                    _textBoxPasswordBorderColorBC = false;
                }
                else
                {
                    _textBoxPasswordBorderColor = value;
                    OnPropertyChanged(nameof(TextBoxPasswordBorderColor));
                }
            }
        }

        private bool _textBlockLoginTextBC = true;
        private string _textBlockLoginText;
        public string TextBlockLoginText
        {
            get => _textBlockLoginText;
            set
            {
                if (_textBlockLoginTextBC)
                {
                    _textBlockLoginTextBC = false;
                }
                else
                {
                    _textBlockLoginText = value;
                    OnPropertyChanged(nameof(TextBlockLoginText));
                }
            }
        }

        private bool _textBlockPasswordTextBC = true;
        private string _textBlockPasswordText;
        public string TextBlockPasswordText
        {
            get => _textBlockPasswordText;
            set
            {
                if (_textBlockPasswordTextBC)
                {
                    _textBlockPasswordTextBC = false;
                }
                else
                {
                    _textBlockPasswordText = value;
                    OnPropertyChanged(nameof(TextBlockPasswordText));
                }
            }
        }

        private string _loginText = string.Empty;
        public string LoginText
        {
            get => _loginText;
            set 
            {
                _loginText = value;
                TextBoxLoginBorderColor = UsualColor();
                TextBlockLoginText = UsualText();
            }
        }

        private string _passwordText = string.Empty;
        public string PasswordText
        {
            get => _passwordText;
            set
            {
                _passwordText = value;
                TextBoxPasswordBorderColor = UsualColor();
                TextBlockPasswordText = UsualText();
            }
        }

        private RelayCommand _useButton = null;
        public RelayCommand UseButton
        {
            get
            {
                return _useButton = _useButton ?? new RelayCommand(DoLogIn, true);
            }
        }

        private bool CheckFileds()
        {
            bool res = true;
            if (_loginText == string.Empty)
            {
                TextBoxLoginBorderColor = WarningColor();
                TextBlockLoginText = WarningText();
                res = false;
            }
            if (_passwordText == string.Empty)
            {
                TextBoxPasswordBorderColor = WarningColor();
                TextBlockPasswordText = WarningText();
                res = false;
            }
            return res;
        }

        private void DoLogIn()
        {
            if (CheckFileds())
            {
            }
        }
    }
}
