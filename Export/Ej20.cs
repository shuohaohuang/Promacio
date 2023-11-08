/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  20. Especifica un algorisme que demani a l’usuari que 
 *  introdueixi els números d’una matriu de 7 files per 3 
 *  columnes (compresos entre 1 i 9 inclosos) per teclat. 
 *  Una vegada la matriu estigui omplerta, cal que el vostre 
 *  programa mostri la matriu trasposta (només els valors, 
 *  sense els claudàtors).
 * 
*/

using System;
class TransposedMatrix
{
    static void Main()
    {
        const String Msg = "Introdueix valor de 1 al 9";
        const int ArrayColunm = 7;
        const int ArrayRow = 3;

        int[,] userArray = new int[ArrayColunm, ArrayRow]; 
        int[,] transposedArray= new int[ArrayRow, ArrayColunm];

        for (int i = 0; i < userArray.GetLength(0); i++) { 
            for (int j = 0; j < userArray.GetLength(1); j++) {
                Console.WriteLine(Msg);
                userArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for(int i = 0;i < transposedArray.GetLength(0);i++)
        {
            for (int j = 0;j < transposedArray.GetLength(1);j++)
            {
                transposedArray[i, j] = userArray[j, i];
            }
        }
        
        for (int i = 0;i<userArray.GetLength(0);i++)
        {
            for(int j = 0;j<userArray.GetLength (1);j++)
            {
                Console.Write(j + 1 == userArray.GetLength(1) ? userArray[i,j] +"\n": userArray[i,j]+" ");
            }
        }

        for (int i = 0; i < userArray.GetLength(1); i++)
        {
            for (int j = 0; j < userArray.GetLength(0); j++)
            {
                Console.Write("");
                Console.Write(j + 1 == transposedArray.GetLength(1) ? transposedArray[i, j] + "\n" : transposedArray[i, j] + " ");
            }
        }

    }
}