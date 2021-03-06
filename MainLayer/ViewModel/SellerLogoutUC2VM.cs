﻿using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.Windows;
using WPFApplication01;

namespace MainLayer.ViewModel
{
    public class SellerLogoutUC2VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ISellerWindowCodeBehind _sellerWindowCodeBehind;

        public SellerLogoutUC2VM(ISellerWindowCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _sellerWindowCodeBehind = codeBehind;
        }

        private RelayCommand _closeApp = null;
        public RelayCommand CloseApp
        {
            get
            {
                return _closeApp = _closeApp ?? new RelayCommand(CloseAppFunc, true);
            }
        }

        private void CloseAppFunc()
        {
            Application.Current.MainWindow.Close();
        }
    }
}
