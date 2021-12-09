using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição: {x + y}");
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtrair: {x - y}");
        }
    }
}