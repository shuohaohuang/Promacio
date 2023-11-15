/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  15. Implementa un programa que demani a l’usuari quants 
 *  valors vol introduir i generi una llista a partir d’aquest 
 *  valors introduïts per teclat, retornant la suma de tots 
 *  els elements d’aquesta.
 * 
*/
using System;

class ListSum
{
    static void Main()
    {
        const string Msg = "Introdueix quants nombre vols operar";
        const string MsgInsert = "introdueix el nombre que vols sumar";
      
        int userlenth;
        int sum = 0;
        
        Console.WriteLine(Msg);
        userlenth = Convert.ToInt32(Console.ReadLine());
        int[] userArrey = new int[userlenth];

        for (int i = 0; i < userlenth; i++)
        {
            Console.WriteLine(MsgInsert);
            userArrey[i] = Convert.ToInt32(Console.ReadLine());
            sum += userArrey[i];
            
        }

        Console.WriteLine(sum);
    }

}