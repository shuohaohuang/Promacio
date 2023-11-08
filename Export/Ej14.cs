/*Autor: Shuohao Huang
 * M03 Programació
 * V1 Data: 24/10/23
 * 14. Especifica un algorisme que demani 20 nombres enters (compresos entre 1 i 9 inclosos) 
 * per teclat. Cal que l’algorisme imprimeixi els valors de dreta a esquerra i després d’esquerra a dreta.
 * 
 */

using System;
class OddEven
{
    static void Main()
    {
        const string Msg = "Introdueix 20 nombre i te'ls tornaré invertits";
        const string MsgCont = "Et falta {0} nombres";

        const int lenth = 20;

        int[] userArray = new int[lenth];

        Console.WriteLine(Msg);
        for (int i = 0; i < lenth; i++)
        {
            userArray[i] = Convert.ToInt32(Console.ReadLine());
            if(19-i!=0)
            {
                Console.WriteLine(MsgCont, 19 - i);
            }
            

        }
        Console.WriteLine("\n");
        for (int i = 0; i<lenth ; i++)
        {
            Console.Write(userArray[i] + " ");
        }
        Console.WriteLine("\n");
        for (int i = lenth-1; i >= 0; i--)
        {
            Console.Write(userArray[i] + " ");
        }

    }
}