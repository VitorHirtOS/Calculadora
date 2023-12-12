using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu : IMath_abs, IMath_floor, IMath_log, IMath_pow
    {
        // ------------ Resposta de requisição --------------

        public enum Response
        {
            Sucesso = 200,
            Sair = 300,
            Excecao = 400
        }

        // ------------ Operações Matemáticas ---------------- 

        // ---- Operações por interface

        public double Abs(double abs)
        {
            return Math.Abs(abs);
        }

        public double Floor(double floor)
        {
            return Math.Floor(floor);
        }

        public double Log(double log)
        {
            return Math.Log(log);
        }

        public double Pow(double pow, double x)
        {
            return Math.Pow(pow, x);
        }

        // Operações por instância


        public double Multiplicar()
        {


            try
            {

                Console.WriteLine("Escolha 1 número: ");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escolha 2 número: ");
                var b = Convert.ToDouble(Console.ReadLine());

                Multiplicar multiplicar = new Multiplicar(a, b);

                return multiplicar._Denominador * multiplicar._Numerador;

            }
            catch (Exception e)
            {
                Console.WriteLine($" Erro e retorno zero {e.Message}");
                return 0;
            }


        }

        public Response Continue(ref string acao, string massage)
        {
            Console.WriteLine("Continuar para operação");
            string temp = Console.ReadLine().ToUpper();
            Console.WriteLine(massage);
            Response retorno;

            if (temp == "S")
            {
                retorno = Response.Sucesso;
            }
            else
            {
                acao = temp;
                retorno = Response.Sair;
            }

            return retorno;
        }

        public double Somar()
        {
            try
            {
                string acao = "";

                if(Continue(ref acao, "Restultado da ação: ") == Response.Sair)
                {
                    Console.Clear();
                    return (double)Response.Sair;
                }

                Console.WriteLine("Escolha 1 número: ");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escolha 2 número: ");
                var b = Convert.ToDouble(Console.ReadLine());
                Somar somar = new Somar(a, b);
                Console.Clear();
                return somar._Denominador + somar._Numerador;
            }
            catch (Exception e)
            {
                Console.WriteLine($" Erro e retorno zero {e.Message}");
                return 0;
            }

        }


        // ------------ Mensagem de encerramento --------------

        public void Mensagens(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Pressione qualquer tecla para sair!!!");
            Console.ReadKey();
            Console.Clear();
        }

        public void Sair()
        {
            Mensagens("Encerrando o programa");
            Console.Clear();
        }

        // ---------------------- end -------------------------

        // -------------- Comutador de entrada ----------------

        public void EscolhasOpcao()
        {
            string temp = "";
            while (temp != "E")
            {

                Console.WriteLine("Digite D para dividir: ");
                Console.WriteLine("Digite M para multiplicar: ");
                Console.WriteLine("Digite A para adição: ");
                Console.WriteLine("Digite S para subtrair: ");
                Console.WriteLine("Digite E para sair: ");
                temp = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                switch (temp)
                {
                    case "D":
                        Console.WriteLine("Divisão escolhida");
                        break;
                    case "M":
                        Console.WriteLine("Multiplicação escolhida");
                        Console.WriteLine("O resultado é: " + Multiplicar());
                        break;
                    case "A": 
                        Console.WriteLine("Adição escolhida");
                        Console.WriteLine("O resultado é: " + Somar());
                        Console.WriteLine("-----------------------");
                        break;
                    case "S":
                        Console.WriteLine("Subtração escolhida");
                        break;
                    case "E":
                        Sair();
                        break;
                    default: 
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }

            }

        }

        // ---------------------- end ------------------------

    }
}
