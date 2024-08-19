using System;   //Arquivos em C#
using System.IO;    // para arquivos


namespace CSCourse
{
    class Program
    { 
        public static void Main(string[] args)
        { 
                string[] documentos = {"Documento 1.", "Documento 2."};

                string nomeDoArquivo = "documentos.txt"

                File.WriteAllLines(nomeDoArquivo, documentos);

                Console.WriteLine("O arquivo foi criado!");

                Console.ReadKey(true);
        }

    }
}