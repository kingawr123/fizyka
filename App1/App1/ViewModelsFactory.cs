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
                            new Equation("g=F/m", (F, m) => F / m, "g", "m/s^2", "fizyka.png", ("F", "N"), ("m", "kg")),
                            new Equation("F=m*g", (m, g) => m * g, "F", "N", "fizyka.png", ("m", "kg"), ("g", "m/s^2")),
                            new Equation("m=F/g", (F, g) => F / g, "m", "kg", "fizyka.png", ("F", "N"), ("g", "m/s^2"))
                        }
                    ),
 
                    new Formula
                    (
                        "Gęstość",
                        new List<Equation>()
                        { 
                            new Equation("d=m/v", (m, v) => m / v, "d", "kg/m^3", "fizyka.png", ("m", "kg"), ("v", "m^3")),
                            new Equation("v=m/d", (m, d) => m / d, "v", "m^3", "fizyka.png", ("m", "kg"), ("d", "kg/m^3")),
                            new Equation("m=v*d", (v, d) => v * d, "m", "kg", "fizyka.png", ("v", "m^3"), ("d", "kg/m^3"))
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
                            new Equation("Ep=m*g*h", (m, g, h) => m * g * h, "Ep", "J", "fizyka.png", ("m", "kg"), ("g", "m/s^2"), ("h", "m")),
                            new Equation("h=Ep/(m*g)", (Ep, m, g) => Ep / (m * g), "h", "m", "fizyka.png", ("Ep", "J"), ("m", "kg"), ("g", "m/s^2")),
                            new Equation("m=Ep/(g*h)", (Ep, g, h) => Ep / (g * h), "m", "kg", "fizyka.png", ("Ep", "J"), ("g", "m/s^2"), ("h", "m"))
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
                        "Ciśnienie",
                        new List<Equation>()
                        {
                            new Equation("p=F/S", (F, S) => F / S, "p", "Pa", "cisnienie.gif", ("F", "N"), ("S", "m^3")),
                            new Equation("F=p*S", (p, S) => p * S, "Fp", "N", "cisnienie.gif", ("p", "Pa"), ("S", "m^3")),
                            new Equation("S=F/p", (F, p) => F / p, "S", "m^3", "cisnienie.gif", ("p", "N"), ("p", "Pa"))
                        }
                    ),

                     new Formula
                    (
                         "Ciśnienie hydrostatyczne",
                        new List<Equation>()
                        {
                            new Equation("ph=d*g*h", (d, g, h) => d * g * h, "ph", "Pa", "fizyka.png", ("d", "kg/m^3"), ("g", "m/s^2"), ("h", "m")),
                            new Equation("d=ph/(g*h)", (ph, g, h) => ph / (g * h), "d", "kg/m^3", "fizyka.png", ("ph", "Pa"), ("g", "m/s^2"), ("h", "m")),
                            new Equation("h=ph/(d*g)", (ph, d, g) => ph / (d * g), "h", "m", "fizyka.png", ("ph", "Pa"), ("d", "kg/m^3"), ("g", "m/s^2"))
                        }
                    ),

                    
                }
            };
        }

        public static MainDetailViewModel CreateDrganiaFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>()
                {
                    new Formula
                    (
                        "Okres",
                        new List<Equation>()
                        {
                            new Equation("T=Δt/n", (t, n) => t / n, "T", "s", "fizyka.png", ("t", "s"), ("n", "-")),
                            new Equation("T=λ/V", (λ, V) => λ / V, "T", "s", "fizyka.png", ("λ", "m"), ("V", "m/s")),
                        }
                    ),

                    new Formula
                    (
                        "Częstotliwość",
                        new List<Equation>()
                        {
                            new Equation("f=V*T", (V, T) => V * T, "λ", "m", "fizyka.png", ("V", "m/s"), ("T", "s")),
                            new Equation("λ=V/f", (V, f) => V / f, "λ", "m", "fizyka.png", ("V", "m/s"), ("f", "Hz"))
                        }
                    ),

                    new Formula
                    (
                        "Długość fali",
                        new List<Equation>()
                        {
                            new Equation("λ=V*T", (V, T) => V * T, "λ", "m", "fizyka.png", ("V", "m/s"), ("T", "s")),
                            new Equation("λ=V/f", (V, f) => V / f, "λ", "m", "fizyka.png", ("V", "m/s"), ("f", "Hz"))
                        }
                    ),

                    new Formula
                    (
                        "Prędkość fali",
                        new List<Equation>()
                        {
                            new Equation("V=λ/T", (λ, T) => λ / T, "V", "m/s", "fizyka.png", ("λ", "m"), ("T", "s")),
                            new Equation("V=λ*f", (λ, f) => λ * f, "V", "m/s", "fizyka.png", ("λ", "m"), ("f", "Hz"))
                        }
                    ),
                }
            };
        }

        public static MainDetailViewModel CreateElektrycznoscFormulas()
        {
            return new MainDetailViewModel()
            {
                Formulas = new List<Formula>
                {
                    new Formula
                    (
                        "Napięcie",
                        new List<Equation>()
                        {
                            new Equation("U=E/q", (E, q) => E / q, "U", "V", "fizyka.png", ("E", "J"),("q", "C"))
                        }
                    ),

                    new Formula
                    (
                        "Natężenie",
                         new List<Equation>()
                         {
                          new Equation("I=q/t", (q, t) => q / t, "I", "A", "fizyka.png", ("q", "C"), ("t", "s"))
                         }
                    ),
                }
            };
        }

    }
}
