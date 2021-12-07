using System;

namespace Exercice_1
{
    class Program
    {
        /*
        Exo 1
        Creer une fonction 'DisplayAllNumber' qui prend en paramètre un int.
        La fonction doit afficher tous les nombres de 0 à la valeur du paramètre sans aller à la ligne.
        Ex : 4 est passé en paramètre. Le programme affiche : 
        01234

        */

        static void Main(string[] args)
        {
            Console.WriteLine(DisplayAllNumber(4));
            //Console.WriteLine("Hello World!");
        }

        static string DisplayAllNumber(int number)
        {
            string message = "";
            for(int i = 0 ; i <= number; i++)
                message += i;
                
            return message;

        }
    }
}
