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

        public static string Salvar(List<string> lista)
        {

            DateTime dateTime = DateTime.Now;

            Console.WriteLine("--------- Histórico ----------");

            string url = @"C:\Users\VitorDev\Documents\Códigos";
            string tipoArquvio = "Historico.txt";

            string caminhoCompleto = Path.Combine(url, tipoArquvio);

            foreach (var u in lista)
            {
                File.AppendAllText(caminhoCompleto, u + Environment.NewLine);
            }

            if (!Directory.Exists(url))
            {
                File.Create(caminhoCompleto);
                Console.WriteLine("Caminho criado!!!");
            }

            Console.WriteLine("Quer ler o histórico? ");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("|      |                     |");
            Console.WriteLine("|     |                       |");
            Console.WriteLine("|    |                         |");
            Console.WriteLine("|   |     ! ! !       !  ! !    |");
            Console.WriteLine("|   |   !       !    !       !  |");
            Console.WriteLine("|   |   !   +   !    !   +   !  |");
            Console.WriteLine("|   |   !       !    !       !  |");
            Console.WriteLine("|   |     ! ! !        ! ! !    |");
            Console.WriteLine("|   |                           |");
            Console.WriteLine("|   |             ++            |");
            Console.WriteLine("|    |                         |");
            Console.WriteLine("|     |       ++++++++++      |");
            Console.WriteLine("|      |                     |");
            Console.WriteLine("|       |                   |");
            Console.WriteLine("|        |_________________|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|           MENU            |");
            Console.WriteLine("|    COLOQUE - S PARA SIM   |");
            Console.WriteLine("|    COLOQUE - N PARA NÃO   |");
            Console.WriteLine("|           FINAL           |");
            Console.WriteLine("|---------------------------|");
            string acao = Console.ReadLine().ToUpper(); ;

            Console.WriteLine("------------ End -------------");


            try
            {
                if (acao == "S")
                {
                    Console.WriteLine(File.ReadAllText(caminhoCompleto));
                }
                else
                {
                    return caminhoCompleto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return caminhoCompleto;

            }

            return caminhoCompleto;

        }

    }
}
