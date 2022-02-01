using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args) 
        {
            double pi, raio, volume;
            pi = 3.14159;
            raio = Convert.ToInt32(Console.ReadLine());
            volume = (4.0/3) * pi * Math.Pow(raio, 3);
            System.Console.WriteLine("VOLUME = {0:F3}",volume);
        }
    }
}