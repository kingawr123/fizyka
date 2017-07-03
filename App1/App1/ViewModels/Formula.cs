using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class Formula
    {
        public Formula(string mainEquation)
        {
            this.MainEquation = mainEquation;
        }

        public string MainEquation { get; set; }
    }
}
