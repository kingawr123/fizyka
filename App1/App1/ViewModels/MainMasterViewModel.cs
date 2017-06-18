﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainMenuItem> MenuItems { get; set; }

        public MainMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainMenuItem>(new[]
            {
                new MainMenuItem(ViewModelsFactory.CreateBasicFormulas()) { Id = 0, Title = "Podstawowe wzory" },
                new MainMenuItem(new MainDetailViewModel()) { Id = 1, Title = "Ruch" },
                new MainMenuItem(new MainDetailViewModel()) { Id = 2, Title = "Energia" },
               
            });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}