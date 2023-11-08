/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 7 / 11 / 23
 *  30. Cada cas conté la llista de membres d'un grup 
 *  musical. Un grup musical té un mínim de dos membres 
 *  i un màxim de quinze (si fossin més no tocarien a 
 *  res a l'hora de repartir-se els guanys...) La 
 *  llista es compon pel nom de cadascú dels membres 
 *  separats per comes a excepció de l'últim membre, que 
 *  en comptes d'una coma té la conjunció "i".
 * 
*/

using System;

namespace Band
{
    class Band
    {
        static void Main()
        {
            const string Msg = "Introdueix els noms del membres";


            
            Console.WriteLine(Msg);
            char[] members = Console.ReadLine().ToUpper().ToCharArray();
            for (int i = 0; i < members.Length; i++)
            {
                switch (members[i])
                {
                    case 'Á':
                    case 'À':
                        members[i] = 'A';
                        break;
                    case 'É':
                    case 'È':
                        members[i] = 'E';
                        break;
                    case 'Í':
                    case 'Ì':
                        members[i] = 'I';
                        break;
                    case 'Ò':
                    case 'Ó':
                        members[i] = 'O';
                        break;
                    case 'Ú':
                    case 'Ù':
                        members[i] = 'U';
                        break;
                }
            }
            
            for (int i = 0; i < members.Length; i++)
            {
  
                if(i == 0)
                {
                    Console.Write(members[i]);
                }
                else{
                    if (members[i].Equals('I') && members[i - 1].Equals(' ') && members[i + 1].Equals(' '))
                    {
                        Console.Write(members[i + 2]);
                    }
                    if (members[i].Equals(' ') && members[i - 1].Equals(','))
                    {
                        Console.Write(members[i + 1]);
                    }


                }

            }
        }
    }
}