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

        public double Divisao()
        {
            try
            {
                string acao = "";

                if (Continue(ref acao, "Restultado da ação: ") == Response.Sair)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sair);
                    return 0;
                }
                else if (Continue(ref acao, "Restultado da ação: ") == Response.Sucesso)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sucesso);
                    Console.WriteLine("Escolha 1 número: ");

                    var a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha 2 número: ");
                    var b = Convert.ToDouble(Console.ReadLine());

                    Dividir dividir = new Dividir(a, b);

                    return dividir._Dividendo / dividir._Divisor;

                }
                else
                {
                    throw new Exception("O erro acorreu no 'Multiplicar'!!!" + (double)Response.Excecao);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($" Erro e retorno zero {e.Message}");
                return 0;
            }

        }

        public void Multiplicar(ref Multiplicar multiplicar)
        {
            try
            {
                string acao = "";

                if (Continue(ref acao, "Restultado da ação: ") == Response.Sair)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sair);
                }
                else if (Continue(ref acao, "Restultado da ação: ") == Response.Sucesso)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sucesso);
                    Console.WriteLine("Escolha 1 número: ");

                    multiplicar._Numerador = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha 2 número: ");
                    multiplicar._Denominador = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine($"O resultado da operação de multiplicação {multiplicar._Numerador * multiplicar._Denominador}");

                }
                else
                {
                    throw new Exception("O erro acorreu no 'Multiplicar'!!!" + (double)Response.Excecao);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($" Erro e retorno zero {e.Message}");
            }

        }

        public double Subtrair(ref Subtrair subtrair, string menssage)
        {
            try
            {
                string acao = "";

                if (Continue(ref acao, "Restultado da ação: ") == Response.Sair)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sair);
                    return 0;
                }
                else if (Continue(ref acao, "Restultado da ação: ") == Response.Sucesso)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sucesso);
                    Console.WriteLine("Escolha 1 número: ");

                    subtrair._Numerador = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha 2 número: ");
                    subtrair._Denominador = Convert.ToDouble(Console.ReadLine());

                    var subtracao = subtrair._Numerador - subtrair._Denominador;
                    Console.WriteLine(menssage + " " + subtracao);
                    return subtracao;

                }
                else
                {
                    throw new Exception("O erro acorreu no 'Multiplicar'!!!" + (double)Response.Excecao);
                }

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
            acao = Console.ReadLine().ToUpper();
            Console.WriteLine(massage);
            Response retorno;

            if (acao == "S")
            {
                retorno = Response.Sucesso;
            }
            else
            {
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
                }else if (Continue(ref acao, "Restultado da ação: ") == Response.Sucesso)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sucesso);
                    Console.WriteLine("Escolha 1 número: ");
                    var a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha 2 número: ");
                    var b = Convert.ToDouble(Console.ReadLine());
                    Somar somar = new Somar(a, b);
                    return somar._Denominador + somar._Numerador;
                }
                else
                {
                    throw new Exception("O erro acorreu no 'Somar'!!!" + (double)Response.Excecao);
                }

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
                        Console.WriteLine("O resultado é: " + Divisao());
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");
                        break;
                    case "M":
                        Console.WriteLine("Multiplicação escolhida");
                        Multiplicar multiplica = new Multiplicar(0, 0);
                        Multiplicar(ref multiplica);
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");
                        break;
                    case "A": 
                        Console.WriteLine("Adição escolhida");
                        Console.WriteLine("O resultado é: " + Somar());
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");
                        break;
                    case "S":
                        Console.WriteLine("Subtração escolhida");
                        Subtrair subtrair = new Subtrair(0, 0);
                        Subtrair(ref subtrair, "O resultado da subtração: ");
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");
                        break;
                    case "E":
                        Sair();
                        Mensagens("Continuar");
                        break;
                    default: 
                        Console.WriteLine("Opção Inválida!!!");
                        Mensagens("Continuar");
                        break;
                }

            }

        }

        // ---------------------- end ------------------------

    }
}
