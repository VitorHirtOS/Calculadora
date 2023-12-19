using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class ConversãoTemperatura
    {

        public delegate int CalculosTemperaturas(int numero1, int numero2);

        private int celsius;
        private int fahrenheit;

        public int Celsius
        {
            get; set;
        }

        public int Fahrenheit
        {
            get; set;
        }

        public ConversãoTemperatura(CalculosTemperaturas valoresTemperatura, int celsius, int fahrenheit)
        {
            this.celsius = celsius;
            this.fahrenheit = fahrenheit;
            Celsius = celsius;
            Fahrenheit = fahrenheit;
            valoresTemperatura(celsius, fahrenheit);
        }

    }
}
