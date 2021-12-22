using System; 

class DIO 
{
    static void Main(string[] args) 
    {
        double S=0;
        for (int i = 1; i <= 100; i++)
            S += (double)1/i;        
        var resposta = Math.Round(S,2);
        Console.WriteLine(resposta);
    }
}