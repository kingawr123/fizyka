using App1.Views;
using System.Collections.ObjectModel;
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
                new MainMenuItem(targetType:  typeof(StartPage)){ Id = 0, Title = "Strona główna"},
                new MainMenuItem(ViewModelsFactory.CreateBasicFormulas()) { Id = 1, Title = "Podstawowe wzory" },
                new MainMenuItem(ViewModelsFactory.CreateRuchFormulas()) { Id = 2, Title = "Ruch" },
                new MainMenuItem(ViewModelsFactory.CreateEnergiaFormulas()) { Id = 3, Title = "Energia" },
                new MainMenuItem(ViewModelsFactory.CreateCisnienieFormulas()) { Id = 4, Title = "Ciśnienie"},
                new MainMenuItem(ViewModelsFactory.CreateDrganiaFormulas()) { Id = 5, Title = "Drgania"} ,
                new MainMenuItem(ViewModelsFactory.CreateElektrycznoscFormulas()) { Id = 6, Title = "Elektryczność"} 

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