using System.Windows.Media;

namespace MainLayer.ViewModel
{
    public abstract class StartFormStyles
    {
        private protected SolidColorBrush UsualColor()
        {
            return Brushes.Black;
        }

        private protected string UsualText()
        {
            return string.Empty;
        }

        private protected SolidColorBrush WarningColor()
        {
            return Brushes.Red;
        }

        private protected string WarningText()
        {
            return "Поле не должно быть пустым!";
        }
    }
}
