using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Somar
    {
        private double denominador;
        private double numerador;

        public double _Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }

        public double _Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }

        public Somar(double pDenominador, double pNumerador)
        {
            this.denominador = pDenominador;
            this.numerador = pNumerador;
        }

    }
}
