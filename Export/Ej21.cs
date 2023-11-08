/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  21. Implementa un programa en el que s’introdueixin 
 *  20 notes per terminal (valors entre el 0 i el 10 
 *  inclosos). Un cop emmagatzemats, cal demanar a l’usuari 
 *  quin valor vol cercar i el programa retornarà si aquest 
 *  valor es troba entre els introduïts o no.
 * 
*/

using System;

class SearchValue
{
    static void Main()
    {
        const string Msg = "Introdueix 20 valor de 0 al 10";
        const string MsgSearch = "introdueix quin valor vols saber si esta";
        const string MsgFound = "si hi es";
        const string MsgNotFound = "No hi es";

        const int ArrayLength = 20;


        int[] userArray= new int[ArrayLength];
        int search;
        bool found=false;

        Console.WriteLine(Msg);
        for (int i = 0; i < userArray.GetLength(0); i++)
        {   
            userArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(MsgSearch);
        search = Convert.ToInt32(Console.ReadLine());
        for(int i = 0;i < userArray.GetLength(0) && !found; i++) 
        {
           if (userArray[i] == search)
            {
                found = true;
            }
        }
        Console.WriteLine(found?MsgFound:MsgNotFound);
    }
}