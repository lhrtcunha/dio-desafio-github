using System;

namespace DIO 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*string saida = String.Empty;
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0 && N < 106) 
            {
                for (int i = 0; i < N; i++) 
                    saida += (i < N - 1 ? "Ho ":"Ho!");
                System.Console.WriteLine(saida);              
            }*/                       
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0 && N < 106) 
            {
                for (int i = 1; i <= N; i++) 
                    System.Console.Write(i < N ? "Ho ":"Ho!");              
            }
        }
    }
}