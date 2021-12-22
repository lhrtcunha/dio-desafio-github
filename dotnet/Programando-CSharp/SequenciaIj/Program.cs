using System; 

class DIO 
{
    static void Main(string[] args) 
    { 
        for (int i = 1; i <= 9; i++)
        {        
            for (int j = 7; j >= 5; j--)
            {        
                if (i % 2 != 0)
                    Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}