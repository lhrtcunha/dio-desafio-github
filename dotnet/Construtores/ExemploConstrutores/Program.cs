using System;
using System.Collections.Generic;
using System.Linq;
using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pessoa p1 = new Pessoa("Luís Henrique","R. T. da Cunha");
            // p1.Apresentar();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Aluno a1 = new Aluno("Luís Henrique","R. T. da Cunha","Teste");
            // a1.Apresentar();

            // Data d1 = new Data();
            // d1.SetMes(20);
            // d1.ApresentarMes();
            // d1.Mes = 2;
            // d1.ApresentarMes();

             //const double pi = 3.14;
             //System.Console.WriteLine(pi);            

            Matematica m = new Matematica(10,20);
            m.Somar();
        }
    }
}

