using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;

namespace Calculadora
{
    
    class SystemClient : Cadastros{

        public void Cliente(){

            string acao = "";
            while(acao != "S"){
                
                Console.WriteLine("Cadastro de Cliente");
                Console.WriteLine("Caso queira cadastrar precione - C ou S - Para sair");
                acao = Console.ReadLine().ToUpper();

                switch(acao){

                    case "C":

                            Console.Write("Digite o nome do cliente: ");
                            var nome = Console.ReadLine();
                            Console.Write("Digite a idade: ");
                            var idade = int.Parse(Console.ReadLine());
                            Console.Write("Digite o salário: ");
                            var salario = int.Parse(Console.ReadLine());
                            Console.Write("Digite o cpf: ");
                            var cpf = Console.ReadLine();
                            Console.Write("Digite a rua: ");
                            var endereco = Console.ReadLine();
                            Console.Write("Digite o complemento: ");
                            var complemento = Console.ReadLine();

                            SystemClient systemClient = new SystemClient(nome, idade, salario, cpf, endereco, complemento);

                            DataContractSerializer serializer = new DataContractSerializer(typeof(SystemClient));

                            // Serialization

                            XmlWriterSettings xmlConfig = new XmlWriterSettings{ Indent = true };
                            StringBuilder constructorString = new StringBuilder();
                            XmlWriter escritorXml = XmlWriter.Create(constructorString, xmlConfig);
                            serializer.WriteObject(escritorXml, systemClient);
                            escritorXml.Flush();

                            string objetoSerializer = constructorString.ToString();

                            string objetoCaminho = "Cadastro.xml";

                            if(!Directory.Exists(objetoCaminho)){
                                FileStream meuArquivo = File.Create(objetoCaminho);
                                meuArquivo.Close();
                                File.WriteAllText(objetoCaminho, objetoSerializer);
                            }

                        break;
                    case "S":
                            Console.WriteLine("Encerrando");
                            acao = "S";
                            break;
                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }

            }
        }

        public SystemClient(string nome, int idade, double salario, string cpf, string endereco, string complemento) : base(nome, idade, salario, cpf, endereco, complemento){

        }

    }


}