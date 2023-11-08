/*Autor: Shuohao Huang
 * M03 Programació
 * V1 Data: 30/10/23
 * 19. Implementa un programa que reculli les següents dades per 10 persones:
 * edat (enter)
 * sexe (H/D, caràcter)
 * salari (decimal)
 * becari (cert/fals, booleà)
 * Un cop recollits tots els valors, cal mostrar-los per pantalla en forma de taula.
 * 
 */
using System;

class Data
{
    static void Main(string[] args)
    {
        const string Msg = "introdueix la informació de les 10 persones ";
        const string MsgAge = "introdueix l'edat del personatge {0} ";
        const string MsgSex = "introdueix el sexe del personatge {0}, \"H\" o \"D\"";
        const string MsgWage = "introdueix el sou mensual del personatge {0} ";
        const string MsgHolder = "introdueix si el personatge {0} és un becari";
        const int Person = 10;
        const int Data = 4;
        const int StatsCount = 3;
        int[,] statsValue = new int[,]{
            { 1, 1000 },
            { 100, 500},
            { 20, 50 } };
        int[,] charaA = new int[Person, Data];

    }
}