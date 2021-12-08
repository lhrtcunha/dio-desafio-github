using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string diciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor Classe Aluno!");
        }
    }
}