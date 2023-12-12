using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Subtrair
    {
        private double denominador;
        private double numerador;

        public double _denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }

        public double _numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }

        public Subtrair(double denominador, double numerador)
        {
            this.denominador = denominador;
            this.numerador = numerador;
        }
    }
}
