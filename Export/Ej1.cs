/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 9/10/23
 *  1. Implementa un programa que demani tres nombres enters:
 *       min i max: valors mínim i màxim
 *       num
 *
 */



using System;
class IntervalueMaxMin
{
    static void Main()
    {
        const string Msg = "introdueix el limit del interval i el nombre que vol saber si pertany a l'interval";
        const string Result = "no, el nombre no es troba en l'interval";
        int userNum;
        int min;
        int max;

        Console.WriteLine(Msg);
        min = Convert.ToInt32(Console.ReadLine());
        max = Convert.ToInt32(Console.ReadLine());
        userNum = Convert.ToInt32(Console.ReadLine());

        if(min<userNum && max > userNum)
        {

        }
        else
        {
            Console.WriteLine(Result);
        }


    }
}
