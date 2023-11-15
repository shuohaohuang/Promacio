/*  Autor: Shuohao Huang
*  M03 Programació
*  V1 Data: 25 / 10 / 23
* 3. Implementa un programa que, donada 
* la següent llista, retorni l’element
* més gran i el més petit.llista= [5,10,
* 15,2,25,30,35,40]
* 
*/

using System;

namespace Ej3
{
    class Ej3
    {
        static void Main()
        {
            const string Msg = "El més gran és {0} i el més petit és {1}";
            const int Zero = 0;
            const int One = 1;
            int[] nums = { 5, 10, 15, 2, 25, 30, 35, 40 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+One; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
            Console.WriteLine(Msg, nums[Zero], nums[nums.Length - One]);
        }
    }
}