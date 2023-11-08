/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  23. Implementa un programa en el que s’introdueixin 
 *  20 notes per terminal (valors entre el 0 i el 10 
 *  inclosos). Un cop emmagatzemats, cal demanar a l’usuari 
 *  si vol mostrar els valors ordenats de manera 
 *  ascendent o descendent i mostrar-ho per pantalla.
 * 
*/

using System;

class ValueSort
{
    static void Main()
    {
        const string Msg = "Introdueix 20 valor de 0 al 10";
        const string MsgSortConst = "Com les vols ordenar?" +
            "\n Prem 1 per ordenar-les de forma ascendent" +
            "\n Prem qualsevol per ordenar-les de forma descendent";
        const int Length = 20;
        

        int auxiliaryNum;
        int[] userArray = new int[Length];

        Console.WriteLine(Msg);
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            userArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            for (int j = i + 1; j < userArray.GetLength(0); j++)
            {
                if (userArray[i] < userArray[j])
                {
                    auxiliaryNum = userArray[i];
                    userArray[i] = userArray[j];
                    userArray[j] = auxiliaryNum;
                }
            }
        }
        Console.WriteLine(MsgSortConst);
        switch (Console.ReadLine())
        {
            case "1":
                for (int i = 0; i < userArray.GetLength(0); i++)
                {
                    for (int j = i + 1; j < userArray.GetLength(0); j++)
                    {
                        if (userArray[i] > userArray[j])
                        {
                            auxiliaryNum = userArray[i];
                            userArray[i] = userArray[j];
                            userArray[j] = auxiliaryNum;
                        }
                    }
                }
                for (int i = 0; i < userArray.GetLength(0); i++)
                {
                    Console.Write(i + 1 == userArray.GetLength(0) ? userArray[i] + "\n" : userArray[i] + " ");
                }
                break;

            default:
                for (int i = 0; i < userArray.GetLength(0); i++)
                {
                    for (int j = i + 1; j < userArray.GetLength(0); j++)
                    {
                        if (userArray[i] < userArray[j])
                        {
                            auxiliaryNum = userArray[i];
                            userArray[i] = userArray[j];
                            userArray[j] = auxiliaryNum;
                        }
                    }
                }
                for (int i = 0; i < userArray.GetLength(0); i++)
                {
                    Console.Write(i + 1 == userArray.GetLength(0) ? userArray[i] + "\n" : userArray[i] + " ");
                }
                break;

        }
        
       
    }
}