using System; 

class DIO 
{
    static void Main(string[] args) 
    {
        int x = int.Parse(Console.ReadLine()!);
        if((x+1) % 2 == 0)
            Console.Write(x+1);
        else
            Console.Write(x+2);
    }
}