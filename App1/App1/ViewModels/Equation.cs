using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class Equation
    {
        public Equation(string equation)
        {
            this.EquationString = equation;       
        }

        public string EquationString { get; set; }
    }
}
