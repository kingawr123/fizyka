using App1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Equation : INotifyPropertyChanged
    {
        public Equation(string equation)
        {
            this.EquationString = equation;
        }

        public Equation(string equation, Func<double, double, double> func, string resultName, string resultUnit, params (string name, string unit)[] arguments)
        {
            this.EquationString = equation;
            this.Func = func;
            this.ResultName = resultName;
            this.ResultUnit = resultUnit;
            Arguments = arguments.Select(arg => new Argument(arg.name, arg.unit)).ToList();
            Calculate = new Command(CalculateMethod);
        }

        public Equation(string equation, Func<double, double, double, double> func, string resultName, string resultUnit, params (string name, string unit)[] arguments)
        {
            this.EquationString = equation;
            this.Func = func;
            this.ResultName = resultName;
            this.ResultUnit = resultUnit;
            Arguments = arguments.Select(arg => new Argument(arg.name, arg.unit)).ToList();
            Calculate = new Command(CalculateMethod);
        }

        public string EquationString { get; set; }

        public Delegate Func { get; private set; }

        public List<Argument> Arguments { get; set; }

        public string ResultName { get; set; }

        public string ResultUnit { get; set; }

        private double resultValue;

        public double ResultValue
        {
            get => resultValue;
            set
            {
                this.resultValue = value;
                OnPropertyChanged(nameof(ResultValue));
            }
        }

        public ICommand EquationClicked { get; set; } = new Command(Click);

        private static async void Click(object eq)
        {
            var equation = eq as Equation;

            var page = new EquationPage(equation);
            page.Title = equation.EquationString;

            (App.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(page);
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand Calculate { get; set; }

        private void CalculateMethod()
        {
            this.ResultValue = (double)Func.DynamicInvoke(Arguments.Select(arg => (object)(arg.Value)).ToArray());
        }
    }
}
