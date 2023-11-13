/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 11/10/23
 *  8. Implementa un programa que demani per teclat un nombre natural i retorni si aquest és un nombre primer o no.
 *  Aclariment: Els números 0 i 1 no són primers.
 *  
 *
 */

using System;

class PrimeNumber
{
    static void Main()
    {
        const string Msg = "introdueix un nombre";
        const string MsgPrime = "el nombre és primer";
        const string MsgNoPrime = "el nombre no és primer";
        
        Console.WriteLine(Msg);
        int user =Convert.ToInt32(Console.ReadLine());
        int prime = 0;

        for (int i =2;  i <= user; i++)
        {
            prime = user%i==0 ? prime+1 : prime;
        }
        Console.WriteLine(prime>1? MsgNoPrime: MsgPrime);
    }
}