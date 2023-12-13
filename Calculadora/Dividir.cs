using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Dividir
    {
        private double divisor;
        private double dividendo;

        public double _Divisor
        {
            get { return divisor; }
            set { divisor = value; }
        }

        public double _Dividendo
        {
            get { return dividendo; }
            set { dividendo = value; }
        }


        public Dividir(double divisor, double dividendo)
        {
            this.dividendo = dividendo;
            this.divisor = divisor;
        }


    }
}
