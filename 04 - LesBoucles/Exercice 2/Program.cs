using System;

namespace Exercice_2
{
    class Program
    {
        /*
        Exo 2
        Creer une fonction 'DisplayAllCharacter' qui prend en paramètre un int.
        La fonction doit afficher les caractères de valeur 33 à la valeur numerique + 33 du paramètre.
        (33 étant le premier caractère affichable dans la table ASCII, '!')

        */
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayAllCharacter(1));
        }
        static string DisplayAllCharacter(int number)
        {
            string message = "";
            for(int i = 33 ; i < number+33;i++)
            {
                message += Convert.ToChar(i);
            }
            return message;

        }

    }
}
