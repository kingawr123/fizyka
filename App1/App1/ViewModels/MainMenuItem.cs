using App1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{

    public class MainMenuItem
    {
        public MainMenuItem(object ViewModel = null, Type targetType = null)
        {
            TargetType = targetType ?? typeof(MainDetail);
            this.ViewModel = ViewModel;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public object ViewModel { get; set; }
    }
}