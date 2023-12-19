using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Temperatura : ConversãoTemperatura
    {
 
        private int numero1, numero2;

        private enum Response
        {
            Fahrenheit = 230,
            Celsius = 220,
            Celsius_Fahrenheit = 1000,
        }


        private int _Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        private int _Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }


        private Response eventosRespostas(string acao  ,string message)
        {


            try
            {
                if (acao == "C")
                {
                    return Response.Celsius;
                }
                else if(acao == "F")
                {
                    return Response.Fahrenheit;
                }
                else if (acao == "CF")
                {
                    return Response.Celsius_Fahrenheit;
                }
                else
                {
                    return 0;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }


        }


        public int Calculo()
        {
            string texto = "";
            while (texto != "S")
            {

                Console.WriteLine("Conversão de temperatura: 1 - cálcular C, 2 - cálcular F ou 3 - cálcular CF");
                string operacao = Console.ReadLine().ToUpper();

                switch (operacao)
                {

                    case "F":
                        if (eventosRespostas(operacao, "É celcius") == Response.Fahrenheit)
                        {

                            
                            Console.WriteLine("Resposta fahrenheit: " + (int)Response.Fahrenheit);
                            Console.WriteLine("Valor fonecido para graus => fahrenheit para celcius: " + " " + _Numero1);

                            int result = (_Numero1 - 32) * 5/9;


                            Console.WriteLine("Graus em fahrenheit para celcius: " + result);

                            return result;
                        }
                        return 0;
                    case "C":
                        if (eventosRespostas(operacao, "É fahrenheit") == Response.Celsius)
                        {

                            Console.WriteLine("Resposta celsius: " + (int)Response.Celsius);
                            Console.WriteLine("Valor fonecido para graus => fahrenheit para celcius: " + " " + _Numero2);

                            int result = ((_Numero2 * 9) / 5) + 32;

                            Console.WriteLine("Graus em celcius para fahrenheit: " + result);

                            return result;
                        }
                        return 0;
                    case "CF":
                        if (eventosRespostas(operacao, "Celsius e Fahrenheit") == Response.Celsius_Fahrenheit)
                        {

                            Console.WriteLine("Resposta celsius: " + (int)Response.Celsius);
                            Console.WriteLine("Resposta fahrenheit: " + (int)Response.Fahrenheit);
                            Console.WriteLine($"Celsius {_Numero1} e fahrenheit {_Numero2}");

                            int result1 = (_Numero1 - 32) * 5 / 9;
                            Console.WriteLine($"Graus em fahrenheit para celcius: {result1}");
                            Thread.Sleep(1000);
                            int result2 = ((_Numero2 * 9) / 5) + 32;
                            Console.WriteLine($"Graus em celcius para fahrenheit: {result2}");

                            return 0;
                        }
                        return 0;
                    case "S":
                        Console.WriteLine("Encerrando o programa!!!");
                        texto = "S";
                        return 0;
                    default:
                        Console.WriteLine("Operação inválida!!!");
                        break;
                }
            }
            return 0;
        }


        public Temperatura(CalculosTemperaturas valoresTemperatura, int celsius, int fahrenheit) : base(valoresTemperatura, celsius, fahrenheit)
        {
            _Numero1 = celsius;
            _Numero2 = fahrenheit;
            valoresTemperatura(celsius, fahrenheit);
        }
    }
}
