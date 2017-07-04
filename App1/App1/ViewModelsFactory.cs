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
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("a=F/m"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Fg=m*g"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("T=(273+t)"),
                        }
                    ),
                }
            };
        }

        public static MainDetailViewModel CreateRuchFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("v=s/t"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("a=v/t"),
                        }
                    ),
                }
            };
        }

        public static MainDetailViewModel CreateEnergiaFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ek=(m*v^2)/2"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ep=m*g*h"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ew=Q+W"),
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Q=c*m*T"),
                        }
                    ),
                }
            };
        }

        public static MainDetailViewModel CreateCisnienieFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("p=Fp/S"),
                            new Equation("Fp=p*S"),
                            new Equation("S=Fp/p")
                        }
                    ),

                     new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("ph=p*g*h"),       
                        }
                    ),

                    
                }
            };
        }
    }
}
