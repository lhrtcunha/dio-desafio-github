using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoa()
        {
            this.nome = string.Empty;
            this.sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa!");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}