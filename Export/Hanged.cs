using System;

namespace Hanged
{
    class Hanged
    {
        static void Main()
        {
            const string Msg = "\t\t**********************************************\n" +
                               "\t\t************Bienvenid@ al AHORCADO************\n" +
                               "\t\t**********************************************";
            const string Selector = "\tEscoje la dificultat:" +
                                "\tA: Fácil\n" +
                                "\tB: Medio\n" +
                                "\tC: Difícil\n" +
                                "\tD: Experto\n";
            const string Selected = "Has escogido el nivel {0}\n";
            const string GetWord = "Introduce unas palabras para continuar";

            string[,] hanged = { {"===================="}, 
                                 { }, 
                                 { }, 
                                 { }, 
                                 { }, 
                                 { }, 
                                 { }, 
                                 { }, 
                                 { },
                                 { }};

            Console.WriteLine(Msg);
        }
    }
}