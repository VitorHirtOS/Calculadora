using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Descontos
    {


        enum _Desc
        {
            valor1 = 30,
            valor2 = 40,
            valor3 = 50 + 40,
            valor4 = 60,
            valor5 = 70 + 30,
        }

        public struct _Descontos
        {
            private int valor1;

            public int Desconto1
            {
                get { return valor1; }
                set { valor1 = value; }
            }


            public _Descontos(int valor1)
            {
                this.valor1 = valor1;
            }

        }

        public struct Valores
        {
            private float camisa = 50.35f;
            private float bermuda = 32.15f;
            private float jaqueta = 65.75f;
            private float sapato = 100.00f;
            private float luva = 15.38f;

            public Valores()
            {
                Console.WriteLine(camisa);
                Console.WriteLine(bermuda);
                Console.WriteLine(jaqueta);
                Console.WriteLine(sapato);
                Console.WriteLine(luva);
            }

        }


        public string[] _Descontos_(ref string[] args, ref List<_Descontos> desconto)
        {
            string text = "";
            text.ToUpper();

            Console.Clear();
            do
            {
                Console.WriteLine("Sistema de desconto de preço!!!");
                Console.WriteLine("Caso queira continuar coloque 1 - caso contrário coloque qualquer letra ou número");
                text = Console.ReadLine();

                switch (text)
                {
                    case "1":
                    if (args != null)
                    {

                        Valores valores = new Valores();

                        Console.WriteLine(valores);

                        Console.WriteLine("Coloque um valor para efeturar os descontos: ");
                        float valor = float.Parse(Console.ReadLine());

                        for(var i = 0; i < desconto.Count; i++)
                        {
                            Console.WriteLine("Os índices da lista de elementos " + i);
                        }

                        Console.WriteLine("Sua escolha para desconto: ");
                        int escolha = int.Parse(Console.ReadLine());



                        if (escolha < desconto.Count)
                        {
                            float descontoAplicado = (valor * desconto[escolha].Desconto1) / 100; // Aplica o desconto específico do item escolhido

                            Console.WriteLine($"Cálculo: {descontoAplicado}");

                            // Faça algo com o descontoAplicado se necessário
                        }
                        else
                        {
                            Console.WriteLine("Índice de desconto inválido.");
                        }

                    }
                    break;
                    default:
                        Console.WriteLine("Encerrando!!!");
                        text = "S";
                        return args;
                }


            } while (text == "S");


            return args;
        }



    }
}
