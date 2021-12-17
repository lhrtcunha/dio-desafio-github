using Colecoes.Helper;
// See https://aka.ms/new-console-template for more information
OperacoesArray op = new OperacoesArray();
int[] array = new int[5] {6, 3, 8, 1, 9};

System.Console.WriteLine("Array origonal:");
op.imprimirArray(array);

op.ordenarBubbleSort(ref array);

System.Console.WriteLine("Array ordenado:");
op.imprimirArray(array);

// int[] arrayInteiros = new int[3];

// int [,] matriz = new int[4,2]
// {
//     {8, 8},
//     {10, 20},
//     {50, 100},
//     {90, 200}
// };
// // matriz[0, 0] = 5;

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine(matriz[i, j]);
//     }
// }

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 30;

// System.Console.WriteLine("Percorrendo o array pelo For");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo Foreach");
// foreach (int item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }