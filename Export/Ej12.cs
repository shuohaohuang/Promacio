/*Autor: Shuohao Huang
 * M03 Programació
 * V1 Data: 24/10/23
 * 12. Implementa un programa que demani 20 nombres enters per teclat 
 * i retorni els valors separats en dues files: parell i senars.
 * 
 */

using System;
class Nums
{
    static void Main()
    {
        const string Msg = "Introdueix 20 nombre i te'ls tornaré per parell i senars";
        const string MsgCont = "Et falta {0} nombres";
        const string MsgOdd = "Els senar són:";
        const string MsgEven = "Els parells són:";
        const int Lenth = 20;

        float[] userArray= new float[Lenth];
        float[] oddArray= new float[Lenth];
        float[] evenArray= new float[Lenth];
        int countEvenIndex = 0;
        int countOddIndex = 0;

        Console.WriteLine(Msg);
        for (int i = 0; i < Lenth; i++)
        {
            userArray[i] = Convert.ToInt32(Console.ReadLine());
            if (userArray[i] % 2 == 0)
            {
                evenArray[countOddIndex] = userArray[i];
                countOddIndex++;
            }
            else
            {
                oddArray[countEvenIndex] = userArray[i];
                countEvenIndex++;
            }
            Console.WriteLine(MsgCont,19-i);

        }
        Console.WriteLine(MsgEven);
        for (int i = 0;i < Lenth; i++)
        {
            Console.Write(evenArray[i]+" ");
        }
        Console.WriteLine("\n"+MsgOdd);
        for (int i = 0; i < Lenth; i++)
        {
            Console.WriteLine(oddArray[i]+" ");
        }

    }
}