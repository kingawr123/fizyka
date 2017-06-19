using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ViewModelsFactory
    {
        public static MainDetailViewModel CreateBasicFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<string>()
                {
                    "a=F/m",
                    "Fg=m*g",
                    "T=(273+t)"
                }
            };
        }

        public static MainDetailViewModel CreateRuchFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<string>()
                {
                  "v=s/t",
                  "a=v/t"
                }
            };
        }

        public static MainDetailViewModel CreateEnergiaFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<string>()
                {
                    "Ew=Q+W",
                    "Q=c*m*T"
                }
            };
        }
    }
}
