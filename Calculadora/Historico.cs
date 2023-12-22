using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculadora
{
    internal interface Historico
    {

        public static void Salvar()
        {

            DateTime dateTime = DateTime.Now;

            Console.WriteLine("--------- Histórico ----------");

            string url = @"C:\Users\VitorDev\Documents\Códigos";
            string nomeArquivo = "Historico.txt";

            Path.Combine(url, nomeArquivo);

            FileStream fileStream = File.Create(url);

            File.WriteAllText(url, nomeArquivo);

            if (Directory.Exists(url))
            {
                fileStream.Close();
            }


            Console.WriteLine("------------ End -------------");

        }

    }
}
