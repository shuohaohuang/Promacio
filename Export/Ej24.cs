/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 * 24. Fent servir la interpolació, implementa un 
 * programa en el que es demani a l’usuari el seu 
 * nom, cognoms i edat i retorni un missatge 
 * informatiu, com a l’exemple:
 * 
*/

using System;
class UserDates
{
    static void Main()
    {
        
        const string MsgName = "introdueix el teu nom";
        const string MsgSurname = "introduexi el teu cognom";
        const string MsgAge = "introdueix la teva edat";
        string name="0";
        string surname="0";
        string age="0";

        Console.WriteLine(MsgName);
        name=Console.ReadLine();
        Console.WriteLine(MsgSurname);
        surname = Console.ReadLine();
        Console.WriteLine(MsgAge);
        age = Console.ReadLine();

        Console.WriteLine($"La {name} {surname} té {age} anys");
    }
}
