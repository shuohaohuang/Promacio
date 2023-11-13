/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 10 / 10 / 23
 *  Implementa un programa on l’usuari escrigui un valor 
 *  que representarà una nota (en format decimal). El 
 *  programa haurà de retornar el valor qualitatiu 
 *  corresponent: "Excel·lent", "Notable", "Bé", "Suficient", 
 *  "Suspès", "Nota invàlida".
 *  
 *
 */

using System;

class SecretNum
{
    static void Main()
    {
        const string Msg = "Prem \"1\" per introduir nota o \"0\" per sortir";
        const string MsgMark = "introdueix la nota";
        const string MsgError = "nota invàlida";
        const string MsgFaile = "suspès";
        const string MsgEnough = "suficient";
        const string MsgGood = "bé";
        const string MsgNotable = "notable";
        const string MsgExelent = "exel·lent";
        const string MsgContinue = "Prem \"1\" per continuear o \"0\" per sortir";
        int user;

        Console.WriteLine(Msg);
        user = Convert.ToInt32(Console.ReadLine());
        while (user != 0)
        {
            Console.WriteLine(MsgMark);
            user = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(user<0 ? MsgError : user < 5 
                ? MsgFaile : user == 5 
                ? MsgEnough : user < 7 
                ? MsgGood : user < 9 
                ? MsgNotable : user > 10 
                ? MsgError:MsgExelent);

            Console.WriteLine(MsgContinue);
            user = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}