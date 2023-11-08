/*
 * Author: Shuohao Huang
 * M03. Programació UF1
 * 2. Donada la següent llista:
 * a = [10,20,30,20,10,50,60,40,80,50,40]
 * implementa un programa que retorni una 
 * llista sense els elements duplicats.
 *
 */
using System;

namespace Exercicis
{
    class Exercicis
    {

        static void Main()
        {
            int index = 0;

            int[] numArray = { 10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40 };

            float[] nonRepeat = new float[numArray.Length];

            bool repeat = false;
            

            for(int i=0; i<numArray.Length; i++)
            {
                for(int j=0;j<nonRepeat.Length&& !repeat; j++)
                {
                    if(numArray[i] == nonRepeat[j])
                    {
                        repeat = true;
                    }
                }
                if(!repeat) 
                {
                   nonRepeat[index] = numArray[i];
                    index++;
                }
                repeat = false;
            }
            foreach (int i in nonRepeat)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}