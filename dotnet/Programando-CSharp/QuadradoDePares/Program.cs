using System; 

class DIO {

    static void Main(string[] args) 
    {
        //System.Console.WriteLine("Digite o número N: ");        
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 5 && n < 2000)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {i*i}");
                }
            }
        }
    }
}