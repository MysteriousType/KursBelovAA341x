using System;
using System.ComponentModel;
using WPFApplication01;

namespace MainLayer.ViewModel
{
    public class SellerUC1VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ISellerWindowCodeBehind _sellerWindowCodeBehind;

        public SellerUC1VM(ISellerWindowCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _sellerWindowCodeBehind = codeBehind;
        }
    }
}
