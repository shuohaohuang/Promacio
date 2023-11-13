/*
* Author: Shuohao Huang
* M03. Programació UF1
* 4. Implementa un programa que generi 
* un array, indicant la seva mida per 
* teclat. L’usuari haurà d’indicar 
* un número per teclat, de manera que 
* els valors de cada posició seran 
* nombres múltiples consecutius del valor
* introduït per teclat. Per exemple, si 
* es defineix un array de grandària 5 i 
* s’indica un 3 com a valor, l’array 
* contindrà els valors 3, 6, 9, 12, 15.
*
*/
using System;

namespace Ej4
{
    class Ej4
    {
        static void Main()
        {
            const string Msg = "introdueix la grandaria de la lista";
            const string MsgValue = "introdueix el primer valor de la lista";
            const int One = 1;
            Console.WriteLine(Msg);
            int[] userArray= new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine(MsgValue);
            
            int value= Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < userArray.Length; i++)
            {

                if (i == 0)
                {
                    userArray[i] = value;
                }
                else
                {
                    userArray[i] = ( i + One)*value;
                }

                Console.Write(userArray[i]+" ");
            }
        }
    }
}