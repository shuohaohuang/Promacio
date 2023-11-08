/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  26. Implementa un programa que demani a 
 *  l’usuari que introdueixi un text i 
 *  retorni la seva longitud.
 * 
*/

using System;

class Msg
{
    static void Main()
    {
        const string Msg = "Introdueix un missatge";

        string textOne;

        Console.WriteLine(Msg);
        textOne = Console.ReadLine();
        Console.WriteLine(textOne.Length);
    }
}