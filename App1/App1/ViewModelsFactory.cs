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
                            new Equation("a=F/m", (F, m) => F / m, "a", "m/s^2", "fizyka.png", ("F", "N"), ("m", "kg")),
                            new Equation("F=m*a", (m, a) => m * a, "F", "N", "fizyka.png", ("m", "kg"), ("a", "m/s^2")),
                            new Equation("m=F/a", (F, a) => F / a, "m", "kg", "fizyka.png", ("F", "N"), ("a", "m/s^2"))
                        }
                    ),
 
                    new Formula
                    (
                        "Gęstość",
                        new List<Equation>()
                        { 
                            new Equation("d=v/m", (v, m) => v / m, "d", "kg/m^3", "fizyka.png", ("v", "m^3"), ("m", "kg")),
                            new Equation("v=d*m", (d, m) => d * m, "v", "m^3", "fizyka.png", ("d", "kg/m^3"), ("m", "kg")),
                            new Equation("m=v/d", (v, d) => v * d, "m", "kg", "fizyka.png", ("v", "m^3"), ("d", "kg/m^3"))
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
                            new Equation("v=s/t", (s, t) => s / t, "v", "km/h", "fizyka.png", ("s", "km"), ("t", "h")),
                            new Equation("s=v*t", (v, t) => v * t, "s", "km", "fizyka.png", ("v", "km/h"), ("t", "h")),
                            new Equation("t=s/v", (s, v) => s / v, "t", "h", "fizyka.png", ("s", "km"), ("v", "km/h"))
                        }
                    ),
                    new Formula
                    (
                        "Ruch jednostajnie przyśpieszony",
                        new List<Equation>()
                        {
                            new Equation("a=v/t", (v, t) => v / t, "a", "m/s^2", "fizyka.png", ("v", "m/s"), ("t", "s")),
                            new Equation("v=a*t", (a, t) => a * t, "v", "m/s", "fizyka.png", ("a", "m/s^2"), ("t", "s")),
                            new Equation("s=(a*t^2)/2", (a, t) => (a * t*t)/2 , "s", "m", "fizyka.png", ("a", "m/s^2"), ("t", "s"))
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
                            new Equation("Ek=(m*v^2)/2", (m, v) => (m * v * v) / 2, "Ek", "J", "fizyka.png", ("m", "kg"), ("v", "m/s")),
                            new Equation("m=2*Ek/v^2", (Ek, v) => (2 * Ek) / (v * v), "m", "kg", "fizyka.png", ("Ek", "J"), ("v", "m/s")),
                            new Equation("v=√(2*Ek)/m", (Ek, m) => Math.Sqrt((2*Ek)/m), "v", "m/s", "fizyka.png", ("Ek", "J"), ("m", "kg"))
                        }
                    ),
                    new Formula
                    (
                        "Energia potencjalna",
                        new List<Equation>()
                        {
                            new Equation("Ep=m*a*h", (m, a, h) => m * a * h, "Ep", "J", "fizyka.png", ("m", "kg"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("h=Ep/(m*a)", (Ep, m, a) => Ep / (m * a), "h", "m", "fizyka.png", ("Ep", "J"), ("m", "kg"), ("a", "m/s^2")),
                            new Equation("m=Ep/(a*h)", (Ep, a, h) => Ep / (a * h), "m", "kg", "fizyka.png", ("Ep", "J"), ("a", "m/s^2"), ("h", "m"))
                        }
                    ),
                    new Formula
                    (
                        "Energia wewnętrzna",
                        new List<Equation>()
                        {
                            new Equation("Ew=Q+W", (Q, W) => Q + W, "Ew", "J", "fizyka.png", ("Q", "J"), ("W", "J")),
                        }
                    ),
                    new Formula
                    (
                        "Ciepło",
                        new List<Equation>()
                        {
                            new Equation("Q=Cw*m*t", (Cw, m, t) => Cw * m * t, "Q", "J", "fizyka.png", ("Cw", "J/(kg*°C)"), ("m", "kg"), ("t"," °C")),
                            new Equation("m=Q/(Cw*t)", (Q, Cw, t) =>  Q / ( Cw * t ) , "m", "kg", "fizyka.png", ("Q", "J"), ("Cw", "J/(kg*°C)"), ("t", "°C")),
                            new Equation("t=Q/(m*Cw)", (Q, m, Cw) => Q / ( m * Cw), "t", "°C", "fizyka.png", ("Q", "J"), ("m", "kg"), ("Cw", "J/(kg*°C)"))
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
                            new Equation("p=Fp/S", (Fp, S) => Fp / S, "p", "Pa", "cisnienie.gif", ("Fp", "N"), ("S", "m^3")),
                            new Equation("Fp=p*S", (p, S) => p * S, "Fp", "N", "cisnienie.gif", ("p", "Pa"), ("S", "m^3")),
                            new Equation("S=Fp/p", (Fp, p) => Fp / p, "S", "m^3", "cisnienie.gif", ("Fp", "N"), ("p", "Pa"))
                        }
                    ),

                     new Formula
                    (
                         "Ciśnienie hydrostatyczne",
                        new List<Equation>()
                        {
                            new Equation("ph=d*a*h", (d, a, h) => d * a * h, "ph", "Pa", "fizyka.png", ("d", "kh/m^3"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("d=ph/(a*h)", (ph, a, h) => ph / (a * h), "d", "kg/m^3", "fizyka.png", ("ph", "Pa"), ("a", "m/s^2"), ("h", "m")),
                            new Equation("h=ph/(d*a)", (ph, d, a) => ph / (d * a), "h", "m", "fizyka.png", ("ph", "Pa"), ("d", "kg/m^3"), ("a", "m/s^2"))
                        }
                    ),

                    
                }
            };
        }
    }
}
