/*  Author:Shuohao Huang
 *  M03.Programació
 *  v1. 10/10/23
 *  Implementa un programa on l’usuari escrigui un valor
 *  que representarà el dia de la setmana (segons la seva 
 *  posició)  de l'1 al 7. El programa mostrarà el nom del 
 *  dia corresponent: Dilluns, Dimarts, Dimecres, Dijous,...
 */

using System;

class SecretNum
{
    static void Main()
    {
        const string Msg = "introdueix un nombre de 1 al 7";
        int user;
        Console.WriteLine(Msg);
        user = Convert.ToInt32(Console.ReadLine());
        switch (user)
        {
            case 1: Console.WriteLine("Dilluns");
                break;
            case 2: Console.WriteLine("Dimarts");
                break;
            case 3:
                Console.WriteLine("Dimecres");
                break;
            case 4:
                Console.WriteLine("Dijous");
                break;
            case 5:
                Console.WriteLine("Divendres");
                break;
            case 6:
                Console.WriteLine("Dissabte");
                break;
            case 7:
                Console.WriteLine("Diumenge");
                break;
            default:
                Console.WriteLine("No existeix aquest dia");
                break;
        }
    }
}