using System;
using System.Collections.Generic;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joias = new List<string>();
            int tamanho=0;
            do
            {
                var joia = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(joia))
                    break;
                tamanho += joia.Length;
                if (joia.Length <= 106 && System.Text.RegularExpressions.Regex.IsMatch(joia, "^[()]+$"))
                {
                    if (!joias.Contains(joia))
                        joias.Add(joia);
                }
                else
                    break;                                  
            } while (tamanho<=106);

            System.Console.WriteLine("----------------");
            foreach (var item in joias)
            {            
               Console.WriteLine(item); 
            }
            System.Console.WriteLine(joias.Count.ToString("D"));
            System.Console.WriteLine(tamanho.ToString("D"));                
        }
    }
}
