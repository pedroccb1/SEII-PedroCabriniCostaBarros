using System;   //Arquivos em C#
using System.IO;    // para arquivos


namespace CSCourse
{
    class Program
    { 
        public static void Main(string[] args)
        { 
                string arquivo = "arquivo.txt";

                string texto = File.ReadAllText(arquivo);

                Console.WriteLine("Conteudo do arquivo: " + texto);

                Console.ReadKey(true);
        }

    }
}