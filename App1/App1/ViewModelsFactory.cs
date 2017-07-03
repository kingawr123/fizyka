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
                Formulas = new List<Formula>()
                {
                    new Formula("a=F/m"),
                    new Formula("Fg=m*g"),
                    new Formula("T=(273+t)")
                }
            };
        }

        public static MainDetailViewModel CreateRuchFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                  new Formula("v=s/t"),
                  new Formula("a=v/t")
                }
            };
        }

        public static MainDetailViewModel CreateEnergiaFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula("Ek=(m*v^2)/2"),
                    new Formula("Ep=m*g*h"),
                    new Formula("Ew=Q+W"),
                    new Formula("Q=c*m*T")
                }
            };
        }

        public static MainDetailViewModel CreateCisnienieFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula("p=Fp/S"),
                    new Formula("ph=p*g*h")
                }
            };
        }
    }
}
