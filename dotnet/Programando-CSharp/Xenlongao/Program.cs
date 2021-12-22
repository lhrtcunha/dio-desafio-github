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
            while(qtdTestes --> 0)
            {
                System.Console.WriteLine("Digite a quantidade de esferas: ");
                int qtdEsperas = Convert.ToInt32(Console.ReadLine());
                int resposta = 0;                
                if (qtdEsperas >= 2 && qtdEsperas <= 109)             
                {
                    for (int i = 1; i <= qtdEsperas; i++)                    
                    {
                        int divisores = 0;
                        for (int j = 1; j <= qtdEsperas; j++)
                        {
                           if (i % j == 0)
                            divisores+=1;                         
                        }
                        if (divisores % 2 == 0)
                            resposta+=1;
                    }
                }
                Console.WriteLine(resposta);
            }
        }
    }
}