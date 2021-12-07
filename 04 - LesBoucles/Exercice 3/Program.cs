using System;

namespace Exercice_3
{
    class Program
    {
        /*
            Exo 3
            Creer une fonction 'DisplayAllPairNumber' qui prend en paramètre un int.
            La fonction doit afficher tous les nombres de 0 à la valeur du paramètre et si les nombres sont multiple de 2 et sans aller à la ligne.
            Ex : 11 est passé en paramètre. Le programme affiche : 
            0246810
        */
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayAllPairNumber(50));
        }
        static string DisplayAllPairNumber(int number)
        {
            string message = "";
            for(int i = 0 ; i< number; i+=2)
            {
                message += i;
            }
            return message;
        }
    }
}
