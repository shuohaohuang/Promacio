/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  22. Modifica el programa anterior de manera 
 *  que mostri les notes introduïdes ordenades 
 *  de manera ascendent i descendent (per separat).
 * 
*/

using System;

class ValueSort
{
    static void Main()
    {
        const string Msg = "Introdueix 20 valor de 0 al 10";
        const int Length = 4;
        int[] userArray = new int[Length];
        int auxiliaryNum;
        Console.WriteLine(Msg);
        for (int i = 0; i < userArray.GetLength(0); i++) {
            do
            {
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            } while (userArray[i] < 0 || userArray[i] > 10);
            
        }
        for (int i = 0;i < userArray.GetLength(0); i++) {
            for (int j = i+1; j < userArray.GetLength(0); j++)
            {
                if (userArray[i] > userArray[j])
                {
                    auxiliaryNum = userArray[i];
                    userArray[i] = userArray[j];
                    userArray[j]= auxiliaryNum;
                }
            }
        }
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            Console.Write(i+1==userArray.GetLength(0)? userArray[i]+ "\n" : userArray[i]+" ");
        }
        for (int i = userArray.GetLength(0)-1; i >=0; i--)
        {
            Console.Write(i-1>=0 ? userArray[i] + " " : userArray[i] + "\n");
        }
    }
}