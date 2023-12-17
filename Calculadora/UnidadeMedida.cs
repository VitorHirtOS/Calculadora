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

            try
            {
                char valor = '0';
                while (valor != '1')
                {

                    Console.WriteLine("Caso queira continuar com o programa digite: 0 - continuar ou 1 - para sair");

                    valor = Console.ReadKey(true).KeyChar;

                    if (valor != '1')
                    {
                        switch (acao.ToUpper())
                        {
                            case "KM":
                                Console.WriteLine($"Para quem quer converter o valor do {lista[0]}");
                                var conversaoKM = Console.ReadLine().ToUpper();

                                if (conversaoKM == "HM")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else if (conversaoKM == "DAM")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                                }
                                else if (conversaoKM == "M")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 1000);
                                }
                                else if (conversaoKM == "DM")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10000);
                                }
                                else if (conversaoKM == "CM")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100000);
                                }
                                else if (conversaoKM == "MM")
                                {
                                    Console.WriteLine($"{lista[0]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 1000000);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "HM":
                                Console.WriteLine($"Para quem quer converter o valor do {lista[1]}");
                                var conversaoHM = Console.ReadLine().ToUpper();

                                if (conversaoHM == "KM")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoHM == "DAM")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else if (conversaoHM == "M")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                                }
                                else if (conversaoHM == "DM")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1* 1000);
                                }
                                else if (conversaoHM == "CM")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10000);
                                }
                                else if (conversaoHM == "MM")
                                {
                                    Console.WriteLine($"{lista[1]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100000);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "DAM":
                                Console.WriteLine($"Para quem quer converter o valor do {lista[2]}");
                                var conversaoDAM = Console.ReadLine().ToUpper();

                                if (conversaoDAM == "KM")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoDAM == "HM")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100);
                                }
                                else if (conversaoDAM == "M")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else if (conversaoDAM == "DM")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                                }
                                else if (conversaoDAM == "CM")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 1000);
                                }
                                else if (conversaoDAM == "MM")
                                {
                                    Console.WriteLine($"{lista[2]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10000);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "M":
                                Console.WriteLine($"Para quem quer converter o valor do {lista[3]}");
                                var conversaoM = Console.ReadLine().ToUpper();

                                if (conversaoM == "KM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoM == "HM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100);
                                }
                                else if (conversaoM == "DAM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 1000);
                                }
                                else if (conversaoM == "DM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else if (conversaoM == "CM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                                }
                                else if (conversaoM == "MM")
                                {
                                    Console.WriteLine($"{lista[3]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 1000);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "DM":
                                Console.WriteLine($"Para quem quer converter o valor do {lista[4]}");
                                var conversaoDM = Console.ReadLine().ToUpper();

                                if (conversaoDM == "KM")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoDM == "HM")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100);
                                }
                                else if (conversaoDM == "DAM")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 1000);
                                }
                                else if (conversaoDM == "M")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10000);
                                }
                                else if (conversaoDM == "CM")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else if (conversaoDM == "MM")
                                {
                                    Console.WriteLine($"{lista[4]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 100);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "CM":

                                Console.WriteLine($"Para quem quer converter o valor do {lista[5]}");
                                var conversaoCM = Console.ReadLine().ToUpper();

                                if (conversaoCM == "KM")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoCM == "HM")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100);
                                }
                                else if (conversaoCM == "DAM")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 1000);
                                }
                                else if (conversaoCM == "M")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10000);
                                }
                                else if (conversaoCM == "DM")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100000);
                                }
                                else if (conversaoCM == "MM")
                                {
                                    Console.WriteLine($"{lista[5]} x {lista[6]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 * 10);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            case "MM":

                                Console.WriteLine($"Para quem quer converter o valor do {lista[6]}");
                                var conversaoMM = Console.ReadLine().ToUpper();

                                if (conversaoMM == "KM")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[0]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10);
                                }
                                else if (conversaoMM == "HM")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[1]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100);
                                }
                                else if (conversaoMM == "DAM")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[2]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 1000);
                                }
                                else if (conversaoMM == "M")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[3]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 10000);
                                }
                                else if (conversaoMM == "DM")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[4]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 100000);
                                }
                                else if (conversaoMM == "CM")
                                {
                                    Console.WriteLine($"{lista[6]} x {lista[5]}");
                                    Console.WriteLine("Valor padrão do cálculo: " + valor1 / 1000000);
                                }
                                else
                                {
                                    Console.WriteLine("Opção desconhecida");
                                }

                                break;
                            default:
                                Console.WriteLine("Opções inválidas!!!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Encerrando o sistema de unidade!!!");
                        continue;
                    }
                }


                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensagem de erro: {ex}");
                return null;
            }

        }

        public UnidadeMedida(string acao, int valor1, int valor2)
        {
            Console.WriteLine(acao, valor2, valor1);
        }

    }
}
