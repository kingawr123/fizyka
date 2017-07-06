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
                        "Siła grawitacji",
                        new List<Equation>()
                        {
                            new Equation("a=F/m", (F, m) => F / m, "a", "m/s^2", ("F", "N"), ("m", "kg")),
                            new Equation("F=m*a"),
                            new Equation("m=F/a")
                        }
                    ),
 
                    new Formula
                    (
                        "Zamiana stopni celcjusza na kelwina",
                        new List<Equation>()
                        { 
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
                        "Ruch jednostajny prostoliniowy",
                        new List<Equation>()
                        {
                            new Equation("v=s/t"),
                            new Equation("s=v*t"),
                            new Equation("t=s/v")
                        }
                    ),
                    new Formula
                    (
                        "Ruch jednostajnie przyśpieszony",
                        new List<Equation>()
                        {
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
                        "Energia kinetyczna",
                        new List<Equation>()
                        {
                            new Equation("Ek=(m*v^2)/2"),
                            new Equation("m=2*Ek/v^2"),
                            new Equation("v=√(2*Ek)/m")
                        }
                    ),
                    new Formula
                    (
                        "Energia potencjalna",
                        new List<Equation>()
                        {
                            new Equation("Ep=m*g*h"),
                            new Equation("h=Ep/(m*g)"),
                            new Equation("m=Ep/(g*h)")
                        }
                    ),
                    new Formula
                    (
                        "Energia wewnętrzna",
                        new List<Equation>()
                        {
                            new Equation("Ew=Q+W"),
                            new Equation("Ew=Q"),
                            new Equation("Ew=W")
                        }
                    ),
                    new Formula
                    (
                        "Ciepło",
                        new List<Equation>()
                        {
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
                        "Ciśnienie atmosferyczne",
                        new List<Equation>()
                        {
                            new Equation("p=Fp/S"),
                            new Equation("Fp=p*S"),
                            new Equation("S=Fp/p")
                        }
                    ),

                     new Formula
                    (
                         "Ciśnienie hydrostatyczne",
                        new List<Equation>()
                        {
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
