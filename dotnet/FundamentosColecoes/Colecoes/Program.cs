﻿// See https://aka.ms/new-console-template for more information
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

System.Console.WriteLine("Percorrendo o array pelo For");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine(arrayInteiros[i]);
}

System.Console.WriteLine("Percorrendo o array pelo Foreach");
foreach (int item in arrayInteiros)
{
    System.Console.WriteLine(item);
}