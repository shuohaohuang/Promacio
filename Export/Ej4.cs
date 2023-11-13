/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 9/10/23
 *  4. Implementa un programa que demani l’any i aquest retorni 
 *  si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 */

/*  La regla “oficial” per a saber si un any és de traspàs és mirar la seva divisibilitat per 4. Seran de traspàs quan...
 *
 *  l'any sigui divisible per 4, excepte si és un final de segle (acaba en 00).
 *  l'anys sigui un final de segle i les dos primeres xifres de l'any també siguin 
 *  divisibles per 4 (així el 1900 o el 2100 no són de traspàs però el 2000 si perquè la divisió 20/4 és exacta).
*/



using System;
class LeapYear
{
    static void Main()
    {
        const string Msg = "introdueix l'any";
        const string LeapYear = "Sí, és any de traspàs.";
        const string NoLeapYear= "No, no és any de traspàs.";
        int userNum;

        Console.WriteLine(Msg);
       
        userNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(userNum % 4 == 0 ? userNum % 100 == 0 ? (userNum/100)%4==0 ? LeapYear:NoLeapYear:LeapYear:NoLeapYear) ;
    }
}
