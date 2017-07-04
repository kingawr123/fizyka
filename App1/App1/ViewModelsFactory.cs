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
                            new Equation("Siła grawitacji"),
                            new Equation("a=F/m"),
                            new Equation("F=m*a"),
                            new Equation("m=F/a")
                        }
                    ),
 
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Zamiana stopni celcjusza na kelwina"),
                            new Equation("T=273+t"),
                            new Equation("t=T-273")
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
                            new Equation("Ruch jednostajny prostoliniowy"),
                            new Equation("v=s/t"),
                            new Equation("s=v*t"),
                            new Equation("t=s/v")
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ruch jednostajnie przyśpieszony"),
                            new Equation("a=v/t"),
                            new Equation("v=a*t"),
                            new Equation("s=(a*t^2)/2")
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
                            new Equation("Energia kinetyczna"),
                            new Equation("Ek=(m*v^2)/2"),
                            new Equation("m=2*Ek/v^2"),
                            new Equation("v=√(2*Ek)/m")
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Energia potencjalna"),
                            new Equation("Ep=m*g*h"),
                            new Equation("h=Ep/(m*g)"),
                            new Equation("m=Ep/(g*h)")
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Energia wewnętrzna"),
                            new Equation("Ew=Q+W"),
                            new Equation("Ew=Q"),
                            new Equation("Ew=W")
                        }
                    ),
                    new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ciepło"),
                            new Equation("Q=Cw*m*T"),
                            new Equation("m=Q/(Cw*T)"),
                            new Equation("T=Q/(m*Cw)")
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
                            new Equation("Ciśnienie atmosferyczne"),
                            new Equation("p=Fp/S"),
                            new Equation("Fp=p*S"),
                            new Equation("S=Fp/p")
                        }
                    ),

                     new Formula
                    (
                        new List<Equation>()
                        {
                            new Equation("Ciśnienie hydrostatyczne"),
                            new Equation("ph=d*g*h"),
                            new Equation("d=ph/(g*h)"),
                            new Equation("h=ph/(d*g)")
                        }
                    ),

                    
                }
            };
        }
    }
}
