/*Autor: Shuohao Huang
 * M03 Programació
 * V1 Data: 24/10/23
 *13. Implementa un programa que demani 20 nombres enters per teclat i retorni els valors de les posicions senars.
 * 
 */

using System;
class OddEven
{
    static void Main()
    {
        const string Msg = "Introdueix 20 nombre i et tornaré només el nombres en posició senar";
        const string MsgCont = "Et falta {0} nombres";
        const string MsgOddPosition = "Els senar es troben en les posicions senars són:";
        const int lenth = 20;
        int[] userArray = new int[lenth];

        Console.WriteLine(Msg);
        for (int i = 0; i < lenth; i++)
        {
            userArray[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgCont, 19 - i);
        }
        Console.WriteLine(MsgOddPosition);
        for (int i = 0; i < lenth; i++)
        {   
            if(i%2==1)
            {
                Console.Write(userArray[i] + " ");
            }
        }
        

    }
}