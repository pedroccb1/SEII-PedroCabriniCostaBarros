using System;   //Arquivos em C#
using System.IO;    // para arquivos


namespace CSCourse
{
    class Program
    { 
        public static void Main(string[] args)
        { 
                string nomeDoArquivo = "arquivoo.txt";

                Console.WriteLine(File.Exists(nomeDoArquivo));

                File.WriteAllLines(nomeDoArquivo, "Algum texto");

                Console.WriteLine(File.Exists(nomeDoArquivo));

                Console.ReadKey(true);
        }

    }
}