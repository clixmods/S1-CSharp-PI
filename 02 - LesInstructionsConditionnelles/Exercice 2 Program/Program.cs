using System;

namespace Exercice_2_Program
{
    /*
        Exo 2
        Ecrire un programme qui teste si un nombre entier est pair, demander à l’utilisateur de saisir le nombre.
        Dans le cas où le chiffre est pair, vous afficherez un message du
        type ”Le chiffre X est pair”, et s'il est impair vous afficherez "Le chiffre X est pair"
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tape un nombre entier stp");
            string userValue = Console.ReadLine();
            int result;
            if(int.TryParse(userValue, out result))
            {
                if(result % 2 == 0)
                {
                    Console.WriteLine("pair");
                }
                else
                {
                    Console.WriteLine("Impair");
                }

            }   
            else
            {
                Console.WriteLine("Value incorrect, veuillez réessayer avec un nombre entier");
            }    
        }
    }
}
