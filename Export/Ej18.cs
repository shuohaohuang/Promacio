/*Autor: Shuohao Huang
 * M03 Programació
 * V1 Data: 25/10/23
 *18. Implementa un programa que reculli els valors dels següents 
 *atributs per a 4 personatges:
 *vida [1-1000]
 *poder[100-500]
 *força [20-50]
 *Caldrà fer les validacions corresponents als atributs i 
 *mostrar les dades introduïdes en format de taula.
 */
using System;

class CharacterStats
{
    static void Main()
    {
        const string Msg = "introdueix els stats dels personatge ";
        const string MsgHp = "introdueix la vida del personatge {0} comprès entre {1} i {2}";
        const string MsgPower = "introdueix el poder del personatge {0} comprès entre {1} i {2}";
        const string MsgStrenght = "introdueix la força del personatge {0} comprès entre {1} i {2}";
        const int MaxValue = 1;
        const int Chara = 4;
        const int StatsCount = 3;
        int[,] statsValue = new int[,]{
            { 1, 1000 },
            { 100, 500},
            { 20, 50 } };
        int[,] charaA = new int[Chara, StatsCount];
        /*      x x x 
         *      x x x
         *      x x x
         *      x x x
         */

        Console.WriteLine(Msg);
        for (int i = 0; i < Chara; i++)
        {
            for (int j = 0; j < StatsCount; j++)
            {
                for (int k = 0; k < MaxValue; k++)
                {
                    switch (j)
                    {
                        case 0:
                            
                            do
                            {
                                Console.WriteLine(MsgHp, i + 1, statsValue[j, k], statsValue[j, k + 1]);
                                charaA[i, j] = Convert.ToInt32(Console.ReadLine());
                                
                            } while (charaA[i, j] < statsValue[j, k] || charaA[i, j] > statsValue[j, k + 1]);
                            break;

                        case 1:
                            
                            do
                            {
                                Console.WriteLine(MsgPower, i + 1, statsValue[j, k], statsValue[j, k + 1]);
                                charaA[i, j] = Convert.ToInt32(Console.ReadLine());
                                
                            } while ((charaA[i, j] < statsValue[j, k] || charaA[i, j] > statsValue[j, k]));
                            break;
                        case 2:
                            
                            do
                            {
                                Console.WriteLine(MsgStrenght, i + 1, statsValue[j, k], statsValue[j, k + 1]);
                                charaA[i, j] = Convert.ToInt32(Console.ReadLine());
                                
                            } while ((charaA[i, j] < statsValue[j, k] || charaA[i, j] > statsValue[j, k]));
                            break;
                    }

                }
            }
        }
        Console.WriteLine("         VIDA        PODER       FORÇA");

        for (int i = 1; i < Chara+1; i++)
        {
            for (int j = 0; j < StatsCount + 1; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.Write("P{0}         ", i);
                        break;

                    case 1:
                        Console.Write("{0}          ", charaA[i, j-1]);
                        break;

                    case 2:
                        Console.Write("{0}          ", charaA[i, j-1]);
                        break;

                    case 3:
                        Console.WriteLine("{0}", charaA[i, j-1]);
                        break;
                }

            }

        }
    }
}