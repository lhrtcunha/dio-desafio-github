﻿using System;

namespace DIO 
{
    class Program 
    {
        static void Main() 
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                System.Console.WriteLine(Y != 0 ? (X/Y).ToString("N1") : "divisao impossivel");
            }
        }
    }
}
