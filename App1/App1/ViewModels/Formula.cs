using App1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Formula
    {
        public Formula(string name, List<Equation> listOfEquations)
        {
            this.Name = name;
            this.ListOfEquations = listOfEquations;
        }

        public string Name { get; private set; }

        public List<Equation> ListOfEquations { get; set; }

        public ICommand FormulaClicked { get; set; } = new Command(Click);

        private static async void Click(object form)
        {
            var formula = form as Formula;

            var page = new FormulaPage(formula);
            page.Title = formula.Name;

            await ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(page);
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;

        }
    }
}
