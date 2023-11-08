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
            
            int[] nonRepeat = new int[numArray.Length];

            bool repeat= false;
            foreach(int num in numArray) 
            {  
                foreach(int num2 in nonRepeat{
                    repeat = num == num2;
                }
                if (repeat==false) 
                {
                    nonRepeat[index] = num;
                    index++;
                }
            }
            foreach (int i in nonRepeat)
            {
                Console.WriteLine(i);
            }
        }
    }
}