
/*
* Author: Shuohao Huang
* M03. Programació UF1
* 5.Implementa un programa que generi 
* una matriu de 4x4 i mostri la diagonal 
* principal (pots inicialitzar-la amb els 
* valors enters que consideris).
*
*/
using System;

namespace Ej5
{
    class Ej5
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4,4];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * j;
                    if (j == matrix.GetLength(1) - 1) 
                    {
                        Console.WriteLine(i==j? matrix[i, j] : " ");

                    }
                    else
                    {
                        Console.Write(i == j ? matrix[i, j] : " ");
                    }
                }
            }
        }
    }
}