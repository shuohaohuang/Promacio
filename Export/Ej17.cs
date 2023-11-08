/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 *  17. Implementa un programa que demani a l’usuari 
 *  quants valors vol emmagatzemar (en una llista). A 
 *  continuació l’usuari els haurà d’introduir i el 
 *  programa haurà de validar si és un nombre natural 
 *  o no. En cas que no ho sigui, informarà a l’usuari 
 *  i aquest disposarà de dos intents més per a introduir 
 *  el nombre correctament. Aquesta restricció és per a 
 *  tots els nombres que l’usuari introdueixi. En 
 *  finalitzar, el programa haurà de retornar:
 *  
 *  Total de nombres introduïts
 *  Total de nombres més petits de 15
 *  Total de nombres més grans de 30
 * 
*/

using System;

class SplitClass
{

    static void Main()
    {
        const string Msg = "Introdueix quants nombre vols operar";
        const string MsgInsert = "introdueix el nombre que vols classificar";
        const string MsgTotal = "hi ha {0} numeros";
        const string MsgTotalMajor = ";Hi ha {0} numeros major que 30";
        const string MsgTotalMinor = ";Hi ha {0} numeros menor que 15";
        int userlenth;
        int minorCount = 0;
        int majorCount = 0;
        
        Console.WriteLine(Msg);
        userlenth = Convert.ToInt32(Console.ReadLine());
        int[] userArrey = new int[userlenth];
        int[] minor15 = new int[userlenth];
        int[] major30 = new int[userlenth];

        for (int i = 0; i < userlenth; i++)
        {
            minor15[i] = 17;
            major30[i] = 17;
        }
        for (int i = 0;i < userlenth; i++)
        {
            Console.WriteLine(MsgInsert);
            userArrey[i] = Convert.ToInt32(Console.ReadLine());
            if (userArrey[i]>30) 
            {
                major30[majorCount] = userArrey[i];
                majorCount++;
            }
            else
            {
                minor15[minorCount] = userArrey[i];
                minorCount++;
            }
        }
        for(int i = 0;i<userlenth; i++)
        {
            Console.Write(userArrey[i]+" ");
        }
        Console.WriteLine(MsgTotal, userlenth);
        for (int i = 0; i < userlenth; i++)
        {
            Console.Write(minor15[i]==17 ? "" : minor15[i] +" ");
        }
        Console.WriteLine(MsgTotalMinor, minorCount);
        for (int i = 0; i < userlenth; i++)
        {
            Console.Write(major30[i] == 17 ? "" : major30[i] + " ");
        }
        Console.WriteLine(MsgTotalMajor, majorCount);

    }
}