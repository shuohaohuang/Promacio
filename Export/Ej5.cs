/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 10/10/23
 *  5. Implementa un programa que mostri les opcions jugar o sortir. 
 *  Si l'usuari vol jugar, el programa emmagatzemarà en una constant 
 *  un número secret entre 1 i 100 (recorda declarar-la abans de 
 *  mostrar les opcions). L’usuari disposarà de 10 intents per 
 *  endevinar el número, i en cada error el programa li indicarà si
 *  el número introduït és més gran o més petit que el número secret 
 *  a endevinar.
 *  
 *
 */

using System;

class SecretNum
{
    static void Main()
    {
        const string Msg = "Prem \"1\" per jugar o \"0\" per sortir";
        const string MsgLose = "Has perdut";
        const string MsgWin = "Has guanyat";
        const string MsgRules = "Has de introduir un nombre entre 0 i 100 i tens 10 oportunitats";
        const string remain = "Encatra tens {0} oportunitas";

        int secret = 90;
        int user;
        int loop=0;
        bool cont = true;
        Console.WriteLine(Msg);
        user = Convert.ToInt32(Console.ReadLine());
        switch (user)
        {
            case 0: break;
            case 1:
                Console.WriteLine(MsgRules);
               
                do
                {
                    loop++;
                    user = Convert.ToInt32(Console.ReadLine()); 
                    
                    cont =user == secret ? false : true ;

                   if (cont&&loop==10)
                    {
                        Console.WriteLine(MsgLose);
                    }
                   else if(cont)
                    {
                        Console.WriteLine(remain, 10 - loop);
                    }
                    else
                    {
                        cont = false;
                        Console.WriteLine(MsgWin);
                    }
                    
                } while (loop < 10&& cont);
            break;
        }
    }
}