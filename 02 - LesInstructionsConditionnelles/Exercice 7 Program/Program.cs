using System;

namespace Exercice_7_Program
{
    /*
        Exo 7 : switch
    Ecrire un programme qui demande à l’utilisateur de taper un chiffre et qui l’écrit ensuite en toute lettre à l’écran. Par
    exemple, si l’utilisateur tape le chiffre 9, le programme affichera neuf.
    Note : on ne s’occupera que des chiffres et pas de nombres en dehors de l’intervalle [0 − 9].
    
    */
    class Program
    {
        static string[] chiffreLetter = {
            "Zéro",
            "Un",
            "Deux",
            "Trois",
            "Quatre",
            "Cinq",
            "Six",
            "Sept",
            "Huit",
            "Neuf"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Tape un chiffre stp");
            ConsoleKeyInfo chiffre = Console.ReadKey(true);
            switch(chiffre.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Vous avez tapé le chiffre "+chiffreLetter[int.Parse(chiffre.KeyChar.ToString())]);
                break;
                default : 
                    Console.WriteLine("Valeur incorrect");
                break;
            }
            
        }
    }
}
