using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgAssincrona
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;

        public Pessoa (string nome, string sobrenome, int idade){
            this.nome = nome;
            this.nome = sobrenome;
            this.idade = idade;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Sobrenome { get { return sobrenome;} set { sobrenome = value;}}
        public int Idade { get { return idade;} set { idade = value; } }

    }

}