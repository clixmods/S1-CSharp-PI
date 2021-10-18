using System;

namespace Exo_switch
{

    /*
    Ecrire un programme qui demande une lettre de A à K.
    Ensuite avec un switch afficher une note correspondante, en sachant que A = 10 et K = 0; (Votre lettre est A, votre note est 10).
    Dans tous les autres cas on affiche "Lettre invalide".
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleKeyInfo letter = Console.ReadKey(true);
            switch(Char.ToUpper(letter.KeyChar))
            {
                case 'A':
                    Result(letter.KeyChar,10);
                break;
                case 'B':
                    Result(letter.KeyChar,9);
                break;
                case 'C':
                    Result(letter.KeyChar,8);
                break;
                case 'D':
                    Result(letter.KeyChar,7);
                break;
                case 'E':
                    Result(letter.KeyChar,6);
                break;
                case 'F':
                    Result(letter.KeyChar,5);
                break;
                case 'G':
                    Result(letter.KeyChar,4);
                break;
                case 'H':
                    Result(letter.KeyChar,3);
                break;
                case 'I':
                    Result(letter.KeyChar,2);
                break;
                case 'J':
                    Result(letter.KeyChar,1);
                break;
                case 'K':
                    Result(letter.KeyChar,0);
                    break;
                default:
                    Console.WriteLine("Votre lettre est invalide");
                break;


            }
            //Console.WriteLine("Hello World!");
        }
        static void Result(char letter,int note){
            Console.WriteLine("Votre lettre "+letter+ " a une note de "+note);
        }
    }
}
