using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormulaPage : ContentPage
    {
        public FormulaPage(Formula formula)
        {
            InitializeComponent();
            BindingContext = formula;
        }

        private void FormulasView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(sender is ListView list)
            {
                list.SelectedItem = null;
            }
        }
    }
}