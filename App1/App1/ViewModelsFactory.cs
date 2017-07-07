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
                            new Equation("F=m*a", (m, a) => m * a, "F", "N", ("m", "kg"), ("a", "m/s^2")),
                            new Equation("m=F/a", (F, a) => F / a, "m", "kg", ("F", "N"), ("a", "m/s^2"))
                        }
                    ),
 
                    new Formula
                    (
                        "Gęstość",
                        new List<Equation>()
                        { 
                            new Equation("d=v/m", (v, m) => v / m, "d", "kg/m^3", ("v", "m^3"), ("m", "kg")),
                            new Equation("v=d*m", (d, m) => d * m, "v", "m^3", ("d", "kg/m^3"), ("m", "kg")),
                            new Equation("m=v/d", (v, d) => v * d, "m", "kg", ("v", "m^3"), ("d", "kg/m^3"))
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
                            new Equation("v=s/t", (s, t) => s / t, "v", "km/h", ("s", "km"), ("t", "h")),
                            new Equation("s=v*t", (v, t) => v * t, "s", "km", ("v", "km/h"), ("t", "h")),
                            new Equation("t=s/v", (s, v) => s / v, "t", "h", ("s", "km"), ("v", "km/h"))
                        }
                    ),
                    new Formula
                    (
                        "Ruch jednostajnie przyśpieszony",
                        new List<Equation>()
                        {
                            new Equation("a=v/t", (v, t) => v / t, "a", "m/s^2", ("v", "m/s"), ("t", "s")),
                            new Equation("v=a*t", (a, t) => a * t, "v", "m/s", ("a", "m/s^2"), ("t", "s")),
                            new Equation("s=(a*t^2)/2", (a, t) => (a * t*t)/2 , "s", "m", ("a", "m/s^2"), ("t", "s"))
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
                            new Equation("Ek=(m*v^2)/2", (m, v) => (m * v * v) / 2, "Ek", "J", ("m", "kg"), ("v", "m/s")),
                            new Equation("m=2*Ek/v^2", (Ek, v) => (2 * Ek) / (v * v), "m", "kg", ("Ek", "J"), ("v", "m/s")),
                            new Equation("v=√(2*Ek)/m", (Ek, m) => Math.Sqrt((2*Ek)/m), "v", "m/s", ("Ek", "J"), ("m", "kg"))
                        }
                    ),
                    new Formula
                    (
                        "Energia potencjalna",
                        new List<Equation>()
                        {
                            new Equation("Ep=m*a*h", (m, a, h) => m * a * h, "Ep", "J", ("m", "kg"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("h=Ep/(m*a)", (Ep, m, a) => Ep / (m * a), "h", "m", ("Ep", "J"), ("m", "kg"), ("a", "m/s^2")),
                            new Equation("m=Ep/(a*h)", (Ep, a, h) => Ep / (a * h), "m", "kg", ("Ep", "J"), ("a", "m/s^2"), ("h", "m"))
                        }
                    ),
                    new Formula
                    (
                        "Energia wewnętrzna",
                        new List<Equation>()
                        {
                            new Equation("Ew=Q+W", (Q, W) => Q + W, "Ew", "J", ("Q", "J"), ("W", "J")),
                        }
                    ),
                    new Formula
                    (
                        "Ciepło",
                        new List<Equation>()
                        {
                            new Equation("Q=Cw*m*t", (Cw, m, t) => Cw * m * t, "Q", "J", ("Cw", "J/(kg*°C)"), ("m", "kg"), ("t"," °C")),
                            new Equation("m=Q/(Cw*t)", (Q, Cw, t) =>  Q / ( Cw * t ) , "m", "kg", ("Q", "J"), ("Cw", "J/(kg*°C)"), ("t", "°C")),
                            new Equation("t=Q/(m*Cw)", (Q, m, Cw) => Q / ( m * Cw), "t", "°C", ("Q", "J"), ("m", "kg"), ("Cw", "J/(kg*°C)"))
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
                            new Equation("p=Fp/S", (Fp, S) => Fp / S, "p", "Pa", ("Fp", "N"), ("S", "m^3")),
                            new Equation("Fp=p*S", (p, S) => p * S, "Fp", "N", ("p", "Pa"), ("S", "m^3")),
                            new Equation("S=Fp/p", (Fp, p) => Fp / p, "S", "m^3", ("Fp", "N"), ("p", "Pa"))
                        }
                    ),

                     new Formula
                    (
                         "Ciśnienie hydrostatyczne",
                        new List<Equation>()
                        {
                            new Equation("ph=d*a*h", (d, a, h) => d * a * h, "ph", "Pa", ("d", "kh/m^3"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("d=ph/(a*h)", (ph, a, h) => ph / (a * h), "d", "kg/m^3", ("ph", "Pa"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("h=ph/(d*a)", (ph, d, a) => ph / (d * a), "h", "m", ("ph", "Pa"), ("d", "kg/m^3"), ("a", "m/s^2"))
                        }
                    ),

                    
                }
            };
        }
    }
}
