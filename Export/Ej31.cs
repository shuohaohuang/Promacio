/*  Autor: Shuohao Huang
 *  M03 Programació
 *  V1 Data: 25 / 10 / 23
 * 31. El següent tipus de dades emmagatzema les quantitats
 * mitjanes de pluja per cada mes de l’any:
 * float[] arrayPluges = {15.5f, 10f, 3.2f, 1.25f, 
 * 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f};
 * Implementa un programa perquè faci el següent:
 * a)Mostri tot el contingut de l'array, mostrant les 
 * mitjanes de cada mes de manera descendent. Un exemple de 
 * sortida seria aquest:
 * 
*/

using System;

namespace MonthlyRainFall
{
    class MonsthlyRainFall
    {
        static void Main()

        {
            string msg = "La mitjana és de ";
            int[] month = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; 
            float[] arrayPluges = {15.5f, 10f, 3.2f, 1.25f,
            1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f};
            float average=0;
            for (int i = 0; i < arrayPluges.Length; i++)
            {
                for (int j = 0; j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[i] > arrayPluges[j])
                    {
                        float aux = arrayPluges[i];
                        arrayPluges[i] = arrayPluges[j];
                        arrayPluges[j] = aux;
                    }
                }

            }

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                average= arrayPluges[i]+average;
                 string monthRain = $"Mes {month[i]}: {arrayPluges[i]}";
                Console.WriteLine(monthRain);
            }
            Console.WriteLine(msg + average/arrayPluges.Length);
        }
    }
}