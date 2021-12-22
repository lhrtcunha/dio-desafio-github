using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a quantidade de teste: ");
            int qtdTestes = Convert.ToInt32(Console.ReadLine());
            while(qtdTestes > 0)
            {
                int resposta = 0;
                int divisores = 0;
                System.Console.WriteLine("Digite a quantidade de esferas: ");
                int qtdEsperas = Convert.ToInt32(Console.ReadLine());
                if (qtdEsperas >= 2 && qtdEsperas <= 109)             
                {
                    for (int i = 1; i < qtdEsperas; i++)                    
                    {
                        if (i % 2 == 0)
                            divisores+=1;
                    }
                }
                resposta = divisores;
                Console.WriteLine(resposta);
                qtdTestes-=1;
            }
        }
    }
}