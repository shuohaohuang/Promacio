/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 9/10/23
 *  2. Implementa un algorisme que trobi tots els nombres enters entre 2000 i 3000 
 *  (ambdós inclosos), divisibles per 7 però que no siguin múltiples de 5 i els mostri 
 *  per pantalla, separats per comes (com en una sèrie, i no hi ha d’haver coma al final).
 *
 */



using System;
class IntervalueMultiple
{
    static void Main()
    {
        for (int i = 2000; i <= 3000; i++)
        {
            Console.Write(i % 5 == 0 ? "" : i % 7 == 0 ? 3000-i>=7 ? i+", ": i : "");
        }
    }
}
