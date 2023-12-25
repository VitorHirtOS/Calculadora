using System;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace Calculadora
{
    [DataContract]
    public class Cadastros
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public int Idade { get; set; }

        [DataMember]
        public double Salario { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public string Endereco { get; set; }

        [DataMember]
        public int Numero { get; set; }

        [DataMember]
        public string Complemento { get; set; }

        // Construtor sem referências para inicializar um objeto Cadastros
        public Cadastros(string nome, int idade, double salario, string cpf, string endereco, string complemento)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            CPF = cpf;
            Endereco = endereco;
            Complemento = complemento;
        }
    }
}
