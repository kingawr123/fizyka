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
                    "g=F/m",
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
                    "Ek=(m*v^2)/2",
                    "Ep=m*g*h",
                    "Ew=Q+W",
                    "Q=c*m*T"
                }
            };
        }

        public static MainDetailViewModel CreateCisnienieFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<string>()
                {
                    "p=Fp/S",
                    "ph=p*g*h"
                }
            };
        }
    }
}
