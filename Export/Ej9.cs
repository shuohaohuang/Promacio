/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 11/10/23
 *  9. Implementa un programa que demani 
 *  un nombre i aquest retorni el seu factorial.
 *  
 *
 */

using System;

class PrimeNumber
{
    static void Main()
    {
        const string Msg = "introdueix un nombre";
        const string MsgFactorial = "el factorial és ";

        Console.WriteLine(Msg);
        double user = Convert.ToDouble(Console.ReadLine());
        for (double i = user-1; i >0; i--)
        {
            user *= i;
        }
        Console.WriteLine(MsgFactorial+user);
    }
}