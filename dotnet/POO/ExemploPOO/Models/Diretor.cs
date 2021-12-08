using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Diretor : Professor
    {
         public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou um professor Diretor de salário {Salario}!");
        }        
    }
}