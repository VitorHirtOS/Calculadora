using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    queue
    slack
    eventos
    criação arquivos

 */

namespace Calculadora
{
    internal class IMC : Descontos
    {
        private int idade;
        private float altura;
        private int peso;
        private string nome;


        public int Idade
        {
            get; set;
        }

        public int Altura
        {
            get; set;
        }

        public int Peso
        {
            get; set;
        }

        public string Nome
        {
            get; set;
        }


        private void Messagem()
        {
            Console.Clear();
            Console.WriteLine("|      IMC       | Classificação");
            Console.WriteLine("| Menor que 18,5 | Magreza");
            Console.WriteLine("| 18,5 a 24,9    | Normal");
            Console.WriteLine("| 25 a 29,9      | Sobrepeso");
            Console.WriteLine("| 30 a 34,9      | Obesidade grau I");
            Console.WriteLine("| 35 a 39,9      | Obesidade grau II");
            Console.WriteLine("| Maior que 40   | Obesidade grau III");
            Console.WriteLine("Precione qualquer tecla para continuar");
            Console.ReadKey();
        }

        public void ArmUsuario()
        {

            List<string> usuario = new List<string>();

            var idade_listagem = Idade.ToString();
            var altura_listagem = Altura.ToString();
            var peso_listagem = Peso.ToString();

            usuario.Add(Nome);
            usuario.Add(idade_listagem);
            usuario.Add(altura_listagem);
            usuario.Add(peso_listagem);

        }

        public _Desc Response(string acao)
        {
            
            if(acao == "1")
            {
                Console.WriteLine("Continuando com a operação!!!");
                return _Desc.valor1;
            }
            else
            {
                return _Desc.valor2;
            }

        }

        public double CalcularIMC()
        {

            string stop = "";
            stop.ToUpper();
            while (stop != "S")
            {

                Stack<string> usuarios = new Stack<string>();

                Console.WriteLine("Qual o seu nome: ");
                usuarios.Push(Console.ReadLine());
                Console.WriteLine("Qual é sua idade: ");
                usuarios.Push(Console.ReadLine());
                Console.WriteLine("Qual é sua altura: ");
                usuarios.Push(Console.ReadLine());
                Console.WriteLine("Qual é seu peso: ");
                usuarios.Push(Console.ReadLine());

                Console.WriteLine("Qual sua ação: 1 - continuar ou 0");
                var opcao = Console.ReadLine();

                double acao;
                string[] indice = usuarios.ToArray();


                var peso = Convert.ToDouble(indice[0]);
                var altura = Convert.ToDouble(indice[1]);
                altura = Math.Pow(altura / 100, 2);
                acao = peso / altura;

                if (acao < 18.50 && Response(opcao) == _Desc.valor1)
                {
                    Messagem();
                    Console.WriteLine($"\nResultado da ação: " + Math.Round(acao, 2) + "\n");
                }
                else if (acao > 25 || acao < 29.9 && Response(opcao) == _Desc.valor1)
                {
                    Messagem();
                    Console.WriteLine($"\nResultado da ação: " + Math.Round(acao, 2) + "\n");
                }
                else if (acao > 30 || acao < 34.9 && Response(opcao) == _Desc.valor1)
                {
                    Messagem();
                    Console.WriteLine($"\nResultado da ação: " + Math.Round(acao, 2) + "\n");
                }
                else if (acao > 35 || acao < 39.9 && Response(opcao) == _Desc.valor1) 
                {
                    Messagem();
                    Console.WriteLine($"\nResultado da ação: " + Math.Round(acao, 2) + "\n");
                }
                else if (acao > 40)
                {
                    Messagem();
                    Console.WriteLine($"\nResultado da ação: " + Math.Round(acao, 2) + "\n");
                }
                else if (Response(opcao) != _Desc.valor1)
                {
                    stop = "S";
                    Console.WriteLine("Encerrando!!!");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Informações inválidas!!!");
                }

            }


            return 0;
        }

    }
}
