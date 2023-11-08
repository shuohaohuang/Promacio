/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 * 25. Implementa un programa que emmagatzemi 
 * una frase introduïda per teclat en la 
 * variable textOne. Demana un altre text i 
 * emmagatzema’l en la variable textTwo. 
 * Afegeix textTwo a textOne i mostra-la per 
 * pantalla. És correcte? Què pots observar a 
 * les variables textOne i textTwo?
 * 
*/

using System;

class Msg
{
    static void Main()
    {
        const string Msg = "Introdueix un missatge";

        string textOne;
        string textTwo;

        Console.WriteLine(Msg);
        textOne = Console.ReadLine();
        Console.WriteLine(Msg);
        textTwo = Console.ReadLine();
        textOne += textTwo;
        Console.WriteLine(textOne);
    }
}