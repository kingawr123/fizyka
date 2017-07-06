using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.ViewModels
{
    public class Argument : INotifyPropertyChanged
    {
        public Argument(string name, string unit)
        {
            this.Name = name;
            this.Unit = unit;
        }

        public string Name { get; private set; }

        public string Unit { get; private set; }

        private double value;

        public double Value
        {
            get => value;
            set
            {
                this.value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}