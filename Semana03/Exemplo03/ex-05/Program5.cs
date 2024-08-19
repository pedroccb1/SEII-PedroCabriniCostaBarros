using System;   //Arquivos em C#
using System.IO;    // para arquivos


namespace CSCourse
{
    class Program
    { 
        public static void Main(string[] args)
        { 
                string nomeDoArquivo = "documentos.txt";

                string conteudo = FileReadAllText(nomeDoArquivo);

                Console.WriteLine("conteudo do arquivo: ");
                Console.WriteLine(conteudo);
                Console.WriteLine("\n");

                File.AppendAllText(nomeDoArquivo, "Um outro arquivo")

                conteudo = FileReadAllText(nomeDoArquivo);
                Console.WriteLine(conteudo);
                Console.WriteLine("\n");

                Console.ReadKey(true);
        }

    }
}