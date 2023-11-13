/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 9/10/23
 *  3. Implementa un algorisme que donat un nombre introduït per teclat:
 *  calculi quants digits té i ho mostri per pantalla
 *  sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
 *  sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla
 *  
 *
 */



using System;
class SumUnits
{
    static void Main()
    {
        const string Msg = "introdueix nombre que vols traballar";
        const string Result = "la suma de tots els digits són {0}, del parells són {1} i dels imparells són {2}";
        int userNum;
        int units = 0;
        int odd=0;
        int even=0;

        Console.WriteLine(Msg);
       
        userNum = Convert.ToInt32(Console.ReadLine());
        
        while (userNum>=1)
        {
            if (userNum %2==0) 
            {
                even += userNum % 10;
            }else
            {
                odd += userNum % 10;
            }
            units = units+userNum%10;
            userNum /=10;
        }
        Console.WriteLine(Result, units, even, odd);
    }
}
