using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculadora.ConversãoTemperatura;
using static Calculadora.Descontos;

namespace Calculadora
{
    internal class Menu : IMath_abs, IMath_floor, IMath_log, IMath_pow
    {

        // Data/Hora

        private DateTime data = DateTime.Now;

        // ------------ Resposta de requisição --------------

        public enum Response
        {
            Sucesso = 200,
            Sair = 300,
            Excecao = 400
        }

        // ------------ Resposta de requisição especiais --------------

        public enum ResponseEspecial
        {
            Exponencial = 950,
            Abs = 570,
            Logaritmo = 102,
            Arrendodamento = 750
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
            return Math.Log10(log);
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

                if (Continue(ref acao, "Restultado da ação: ") == Response.Sucesso)
                {

                    Console.Clear();
                    Console.WriteLine((double)Response.Sucesso);
                    Console.WriteLine("Escolha 1 número: ");

                    var a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha 2 número: ");
                    var b = Convert.ToDouble(Console.ReadLine());

                    Dividir dividir = new Dividir(a, b);

                    double resultadoDivisao = 0;

                    string i = "";
                    while (i != "S")
                    {

                        Console.WriteLine("Quer realizar uma operação com matemática especial? ");
                        Console.WriteLine("Exponencial - 1, Logaritmo - 2, arredondamento - 3, abs - 4 ou Sair - S");

                        var x = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                        try
                        {
                            switch (x)
                            {
                                case "1":
                                    Console.WriteLine((double)ResponseEspecial.Exponencial);
                                    Console.WriteLine("Número para expoente: ");
                                    int exponencial = int.Parse(Console.ReadLine());
                                    var resultadoExpoente = Pow(a, exponencial);
                                    a = resultadoExpoente;
                                    Console.WriteLine(a);
                                    break;
                                case "2":
                                    Console.WriteLine((double)ResponseEspecial.Logaritmo);
                                    Console.WriteLine("Opção de logartimo: Único - 1  EscolhaLog - 2 AmbosLog - 3");
                                    char opcao = Convert.ToChar(Console.ReadLine());

                                    if (opcao == '1')
                                    {
                                        var resultadoLogaritmo = Log(a / b);
                                        Console.WriteLine(resultadoLogaritmo);
                                        return a / b;
                                    }
                                    else if (opcao == '2')
                                    {
                                        Console.WriteLine("Escolha uma das duas para aplicar o logaritmo");
                                        string QualOpcao = Console.ReadLine().ToUpper();
                                        if (QualOpcao == "A")
                                        {
                                            var resultadoLogaritmo2 = Log(a) / b;
                                            return resultadoLogaritmo2;
                                        }
                                        else
                                        {
                                            var resultadoLogaritmo2 = a / Log(b);
                                            return resultadoLogaritmo2;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nenhuma opção escolhida é 'AmbosLog' ");
                                        return Log(a) / Log(b);
                                    }

                                case "3":
                                    Console.WriteLine((double)ResponseEspecial.Arrendodamento);
                                    var resultadoFloor = Floor(a);
                                    a = resultadoFloor;
                                    Console.WriteLine(a);
                                    break;
                                case "4":
                                    Console.WriteLine((double)ResponseEspecial.Abs);

                                    Console.WriteLine("Realizar o ABS no numerador - N ou denominador");
                                    var Context = Console.ReadLine().ToUpper();

                                    if (Context == "N")
                                    {
                                        var resultadoAbs = Abs(a);
                                        a = resultadoAbs;
                                        Console.WriteLine(a);
                                    }
                                    else if (Context == "D")
                                    {
                                        var resultadoAbs = Abs(b);
                                        b = resultadoAbs;
                                        Console.WriteLine(b);
                                    }
                                    else
                                    {
                                        var resultadoAbs = Abs(resultadoDivisao);
                                        resultadoDivisao = resultadoAbs;
                                        Console.WriteLine(resultadoDivisao);
                                    }
                                    break;
                                case "S":
                                    Console.WriteLine("Encerrando o programa especial");
                                    i = x;
                                    break;
                                default:
                                    Console.WriteLine("Opção desconhecida!!!");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Mensagem de erro {e}");
                        }
                    }

                    resultadoDivisao = a / b;
                    return resultadoDivisao;


                }
                else if (Continue(ref acao, "Restultado da ação: ") == Response.Sair)
                {
                    Console.Clear();
                    Console.WriteLine((double)Response.Sair);
                    return 0;
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

                    double resultadoMultiplicacao = 0;

                    string i = "";
                    while (i != "S")
                    {

                        Console.WriteLine("Quer realizar uma operação com matemática especial? ");
                        Console.WriteLine("Exponencial - 1, Logaritmo - 2, arredondamento - 3 e abs - 4");

                        var x = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                        try
                        {
                            switch (x)
                            {
                                case "1":
                                    Console.WriteLine((double)ResponseEspecial.Exponencial);
                                    Console.WriteLine("Número para expoente: ");
                                    int exponencial = int.Parse(Console.ReadLine());
                                    var resultadoExpoente = Pow(multiplicar._Numerador, exponencial);
                                    multiplicar._Numerador = resultadoExpoente;
                                    Console.WriteLine(multiplicar._Numerador);
                                    break;
                                case "2":
                                    Console.WriteLine("Opção de logartimo: Único - 1  EscolhaLog - 2 AmbosLog - 3");
                                    char opcao = Convert.ToChar(Console.ReadLine());

                                    if (opcao == '1')
                                    {
                                        var resultadoLogaritmo = Log(multiplicar._Numerador / multiplicar._Denominador);
                                        Console.WriteLine(resultadoLogaritmo);
                                    }
                                    else if (opcao == '2')
                                    {
                                        Console.WriteLine("Escolha uma das duas para aplicar o logaritmo");
                                        string QualOpcao = Console.ReadLine().ToUpper();
                                        if (QualOpcao == "A")
                                        {
                                            var resultadoLogaritmo2 = Log(multiplicar._Numerador);
                                            multiplicar._Numerador = resultadoLogaritmo2;
                                            Console.WriteLine($"O resultado da operação de multiplicação: {multiplicar._Numerador * multiplicar._Denominador}");
                                        }
                                        else
                                        {
                                            var resultadoLogaritmo2 = Log(multiplicar._Denominador);
                                            multiplicar._Denominador = resultadoLogaritmo2;
                                            Console.WriteLine($"O resultado da operação de multiplicação: {multiplicar._Numerador * multiplicar._Denominador}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Nenhuma opção escolhida é 'AmbosLog' {Log(multiplicar._Numerador) * Log(multiplicar._Denominador)}");
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine((double)ResponseEspecial.Arrendodamento);
                                    var resultadoFloor = Floor(multiplicar._Numerador);
                                    multiplicar._Numerador = resultadoFloor;
                                    Console.WriteLine(multiplicar._Numerador);
                                    break;
                                case "4":
                                    Console.WriteLine((double)ResponseEspecial.Abs);

                                    Console.WriteLine("Realizar o ABS no numerador - N ou denominador");
                                    var Context = Console.ReadLine().ToUpper();

                                    if (Context == "N")
                                    {
                                        var resultadoAbs = Abs(multiplicar._Numerador);
                                        multiplicar._Numerador = resultadoAbs;
                                        Console.WriteLine(multiplicar._Numerador);
                                    }
                                    else if (Context == "D")
                                    {
                                        var resultadoAbs = Abs(multiplicar._Numerador);
                                        multiplicar._Numerador = resultadoAbs;
                                        Console.WriteLine(multiplicar._Numerador);
                                    }
                                    else
                                    {
                                        var resultadoAbs = Abs(resultadoMultiplicacao);
                                        resultadoMultiplicacao = resultadoAbs;
                                        Console.WriteLine(resultadoMultiplicacao);
                                    }

                                    break;
                                case "S":
                                    Console.WriteLine("Encerrando o programa especial");
                                    i = x;
                                    break;
                                default:
                                    Console.WriteLine("Opção desconhecida!!!");
                                    break;
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine($"Mensagem de erro multiplicação {e}");
                        }
                        
                    }
                    resultadoMultiplicacao = multiplicar._Numerador * multiplicar._Denominador;
                    Console.WriteLine($"O resultado da multiplicação: {resultadoMultiplicacao}");
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

                    double subtracao = 0;
                    string i = "";
                    while (i != "S")
                    {

                        Console.WriteLine("Quer realizar uma operação com matemática especial? ");
                        Console.WriteLine("Exponencial - 1, Logaritmo - 2, arredondamento - 3 e abs - 4");

                        var x = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                        switch (x)
                        {
                            case "1":
                                Console.WriteLine((double)ResponseEspecial.Exponencial);
                                Console.WriteLine("Número para expoente: ");
                                int exponencial = int.Parse(Console.ReadLine());
                                var resultadoExpoente = Pow(subtrair._Numerador, exponencial);
                                subtrair._Numerador = resultadoExpoente;
                                Console.WriteLine(subtrair._Numerador);
                                break;
                            case "2":
                                Console.WriteLine((double)ResponseEspecial.Logaritmo);
                                Console.WriteLine("Opção de logartimo: Único - 1  EscolhaLog - 2 AmbosLog - 3");
                                char opcao = Convert.ToChar(Console.ReadLine());

                                if (opcao == '1')
                                {
                                    var resultadoLogaritmo = Log(subtrair._Numerador - subtrair._Denominador);
                                    return resultadoLogaritmo;
                                }
                                else if (opcao == '2')
                                {
                                    Console.WriteLine("Escolha uma das duas para aplicar o logaritmo");
                                    string QualOpcao = Console.ReadLine().ToUpper();
                                    if (QualOpcao == "A")
                                    {
                                        return Log(subtrair._Numerador) - subtrair._Denominador;
                                    }
                                    else
                                    {
                                        return subtrair._Numerador - Log(subtrair._Denominador);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Nenhuma opção escolhida é 'AmbosLog'");
                                    return Log(subtrair._Numerador) / Log(subtrair._Denominador);
                                }
                            case "3":
                                Console.WriteLine((double)ResponseEspecial.Arrendodamento);
                                var resultadoFloor = Floor(subtrair._Numerador);
                                subtrair._Numerador = resultadoFloor;
                                Console.WriteLine(subtrair._Numerador);
                                break;
                            case "4":
                                Console.WriteLine((double)ResponseEspecial.Abs);

                                Console.WriteLine("Realizar o ABS no numerador - N ou denominador - D");
                                var context = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                                if (context == "N")
                                {
                                    var resultadoAbs = Abs(subtrair._Numerador);
                                    subtrair._Numerador = resultadoAbs;
                                }
                                else if(context == "D")
                                {

                                    var resultadoAbs = Abs(subtrair._Denominador);
                                    subtrair._Denominador = resultadoAbs;
                                    Console.WriteLine(subtracao);
                                }
                                else
                                {

                                    var resultadoAbs = Abs(subtracao);
                                    subtracao = resultadoAbs; 
                                    Console.WriteLine(subtracao);
                                }
                                
                                break;
                            case "S":
                                Console.WriteLine("Encerrando o programa especial");
                                i = x;
                                break;
                            default:
                                Console.WriteLine("Opção desconhecida!!!");
                                break;
                        }
                    }

                    subtracao = subtrair._Numerador - subtrair._Denominador;
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
            Console.WriteLine("Continuar para operação aperte 'S'");
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

                    double somando = 0;
                    string i = "";
                    while (i != "S")
                    {   

                        Console.WriteLine("Quer realizar uma operação com matemática especial? ");
                        Console.WriteLine("Exponencial - 1, Logaritmo - 2, arredondamento - 3 e abs - 4");

                        var x = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                        try
                        {
                            switch (x)
                            {
                                case "1":
                                    Console.WriteLine((double)ResponseEspecial.Exponencial);
                                    Console.WriteLine("Número para expoente: ");
                                    int exponencial = int.Parse(Console.ReadLine());
                                    var resultadoExpoente = Pow(a, exponencial);
                                    a = resultadoExpoente;
                                    Console.WriteLine(a);
                                    break;
                                case "2":
                                    Console.WriteLine("Opção de logartimo: Único - 1  EscolhaLog - 2 AmbosLog - 3");
                                    char opcao = Convert.ToChar(Console.ReadLine());

                                    if (opcao == '1')
                                    {
                                        var resultadoLogaritmo = Log(a + b);
                                        return resultadoLogaritmo;
                                    }
                                    else if (opcao == '2')
                                    {
                                        Console.WriteLine("Escolha uma das duas para aplicar o logaritmo");
                                        string QualOpcao = Console.ReadLine().ToUpper();
                                        if (QualOpcao == "A")
                                        {
                                            return Log(a) + b;
                                        }
                                        else
                                        {
                                            return a + Log(b);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Nenhuma opção escolhida é 'AmbosLog'");
                                        return Log(a) + Log(b);
                                    }
                                case "3":
                                    Console.WriteLine((double)ResponseEspecial.Arrendodamento);
                                    var resultadoFloor = Floor(a);
                                    a = resultadoFloor;
                                    Console.WriteLine(a);
                                    break;
                                case "4":
                                    Console.WriteLine((double)ResponseEspecial.Abs);

                                    Console.WriteLine("Realizar o ABS no numerador - N ou denominador - D");
                                    var context = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                                    if (context == "N")
                                    {
                                        var resultadoAbs = Abs(a);
                                        a = resultadoAbs;
                                        Console.WriteLine(a);
                                    }
                                    else if (context == "D")
                                    {

                                        var resultadoAbs = Abs(b);
                                        b = resultadoAbs;
                                        Console.WriteLine(b);
                                    }
                                    else
                                    {
                                        var resultadoAbs = Abs(somando);
                                        somando = resultadoAbs;
                                        Console.WriteLine(somando);
                                    }
                                    break;
                                case "S":
                                    Console.WriteLine("Encerrando o programa especial");
                                    i = x;
                                    break;
                                default:
                                    Console.WriteLine("Opção desconhecida!!!");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Mensagem de erro soma {e}");
                        }     
                    }
                    somando = a + b;
                    return somando;
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
            Console.WriteLine("Hora atual: " + data);
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
                Console.WriteLine("Digite U para Sistema de uniddade: ");
                Console.WriteLine("Digite T Sistema de conversão de temperatura: ");
                Console.WriteLine("Digite O para desconto: ");
                Console.WriteLine("Digite I prar IMC: ");
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
                    case "U":
                        try
                        {
                            Console.WriteLine("Sistema de unidade escolhido");
                            SistemaUnidadeMedida _acao_ = new SistemaUnidadeMedida("", 0, 0);
                            UnidadeMedida _acao2_ = new UnidadeMedida("", 0, 0);
                            Console.WriteLine("--------------");
                            Console.WriteLine("Unidade: ");
                            string x = Console.ReadLine();
                            Console.WriteLine("Valor 1: ");
                            int v1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor 2: ");
                            int v2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("--------------");
                            Console.WriteLine("Quer padronizado - P ? caso contrário não aperte P");
                            string acao = Console.ReadLine().ToUpper();
                            if (acao == "P")
                            {
                                _acao_.Escolha(ref x, ref v1, ref v2);
                                Mensagens("Continuar");
                                Console.WriteLine("-----------------------");
                            }
                            else
                            {
                                _acao2_.Escolha(ref x, ref v1, ref v2);
                                Mensagens("Continuar");
                                Console.WriteLine("-----------------------");
                            }
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                       
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");
                        break;
                    case "T":
                        Console.WriteLine("Forneça o primeiro valor: ");
                        int numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Forneça o segundo valor: ");
                        int numero2 = int.Parse(Console.ReadLine());

                        // Não armazena dados e precisa de um métoodo, Lambada ou return para funcionar desta maneira
                        CalculosTemperaturas calculosTemperaturas = (numero1, numero2) => numero1 + numero2;

                        Temperatura temperatura = new Temperatura(
                        calculosTemperaturas,
                        numero1,
                        numero2);

                        temperatura.Calculo();
                        Mensagens("Continuar");
                        Console.WriteLine("-----------------------");

                        break;
                    case "O":


                        string list = "";
                        List<string> add = new List<string>();
                        while (list != "S")
                        {

                            Console.WriteLine("Opções: ");
                            Console.WriteLine("1 - Camisa ");
                            Console.WriteLine("2 - Bermuda ");
                            Console.WriteLine("3 - Jaqueta: ");
                            Console.WriteLine("4 - Sapato: ");
                            Console.WriteLine("5 - Luva: ");
                            Console.WriteLine("Caso queira sair - S ");

                            Console.WriteLine(list);
                            Console.WriteLine("Escreva o número e o nome do material: ");
                            var x = Console.ReadLine();


                            add.Add(x);



                            if (x == "S".ToUpper())
                            {
                                Console.WriteLine("Opções escolhidas");
                                Console.WriteLine(add);
                                list = "S";
                            }

                           add.ForEach(x => Console.WriteLine(x));  

                        }

                        string[] listagem = [];

                        add.ForEach(item =>
                        {
                            if(add != null)
                            {
                                listagem = add.ToArray();
                            }
                            else
                            {
                                Console.WriteLine("Lista vázia");
                            }
                        });

                        Descontos descontos = new Descontos();

                        List<Descontos._Descontos> listaDesconto = new List<Descontos._Descontos>();

                        listaDesconto.Add(new _Descontos(50));

                        var x2 = descontos._Descontos_(ref listagem, ref listaDesconto);

                        Console.WriteLine(x2[0]);

                        break;
                    case "I":
                        Console.WriteLine("Opção escolhida IMC");

                        IMC imc = new IMC();

                        imc.CalcularIMC();

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
