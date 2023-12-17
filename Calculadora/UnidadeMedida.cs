using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class UnidadeMedida
    {

        // Virtual
        public virtual string Escolha(ref string acao, ref int valor1, ref int valor2)
        {

            string[] lista = ["KM", "HM", "DAM", "M", "DM", "CM", "MM"];

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            switch (acao.ToUpper())
            {
                case "KM":
                    Console.WriteLine($"{lista[0]} x {lista[1]}");
                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                    return lista[0];
                case "HM":
                    return lista[1];
                case "DAM":
                    return lista[2];
                case "M":
                    return lista[3];
                case "DM":
                    return lista[5];
                case "CM":
                    return lista[6];
                case "MM":
                    return lista[7];
                default:
                    Console.WriteLine("Opções inválidas!!!");
                    break;
            }

            return null;

        }

    }
}
