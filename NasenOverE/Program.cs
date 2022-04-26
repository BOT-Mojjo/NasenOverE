using System;

namespace NasenOverE
{
    class Program
    {
        //TODO All kod hittar du i de andra filerna som denna fil pekar til.
        //TODO Den viktiga biten, skälva koden är markerad med en rad. ///////////////////
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Hello World!");                          //ger instruktioner till användaren
                Console.WriteLine("Näsan över E fusklapp v2.0");
                Console.WriteLine();
                Console.WriteLine("Vill du se Uppgift 1, 2, eller 3?");
                Console.WriteLine("(3 har inte implimenteras än)");
                string str = Console.ReadLine();
                int i;
                int.TryParse(str, out i);
                switch(i){
                    default:
                        Console.WriteLine("Tuvär är " + str + "inte en del av programmet än.");
                        Console.WriteLine("Försök istället med \"1\", \"2\", eller \"3\".");
                    break;

                    case 1:
                        Uppgift1.DelUppgift1();
                        Uppgift1.DelUppgift2();
                        Uppgift1.DelUppgift3();
                        Uppgift1.DelUppgift4();
                        Uppgift1.DelUppgift5();
                        Uppgift1.DelUppgift6();
                        Uppgift1.DelUppgift7();
                    break;

                    case 2:
                        Uppgift2.Steg1();
                        Uppgift2.Steg2();
                        Uppgift2.Steg3();
                        Uppgift2.Steg4();
                        Uppgift2.Steg5();
                        Uppgift2.Steg6();
                        Uppgift2.Steg7();
                        Uppgift2.Steg8();
                    break;
                }
            }
        }
    }
}
