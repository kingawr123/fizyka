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
        public Formula(List<Equation> listOfEquations)
        {
            this.ListOfEquations = listOfEquations;
        }

        public string MainEquation
        {
            get => ListOfEquations?.FirstOrDefault()?.EquationString;
        }

        public List<Equation> ListOfEquations { get; set; }

        public ICommand FormulaClicked { get; set; } = new Command(Click);

        private static async void Click(object form)
        {
            var formula = form as Formula;

            var page = new FormulaPage(formula);
            page.Title = formula.MainEquation;

            (App.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(page);
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;

        }
    }
}
