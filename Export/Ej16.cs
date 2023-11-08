/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  16. Implementa un programa que demani  a l’usuari 
 *  10 enters per teclat i els mostri en sentit contrari 
 *  al que s’ha introduït.
 * 
*/

using System;

class ReverseEx16
{

    static void Main(string[] args)
    {
        const string Msg = "Introdueix 5 nombre i te'ls mostré invertits";
        const int Lenth = 5;
        Console.WriteLine(Msg);
        int[] userArrey= new int[Lenth];
        for (int i = 0; i < Lenth; i++)
        {
            userArrey[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\n");
        for (int i = Lenth - 1; i >= 0; i--)
        {
            Console.Write(userArrey[i] + " ");
        }
    }
}