using System;

namespace AreYouMajor
{
    class Program
    {
        /*
        Exo 3 : Créer un projet "AreYouMajor"
        Saisir l'année de naissance d'une personne.
        Afficher ensuite si la personne est mineure ou majeure suivant son année de naissance avec la fonction DetermineMajorité.
        Vous devez utiliser pour vous aider la fonction CalculAge qui calcule l'âge d'une personne en fonction de son année de naissance.
        L'appel et l'affichage se font dans la fonction Main.
        */
        static void Main(string[] args)
        {
            Console.WriteLine(IsMajority(CalculeAge()));
        }
        static bool IsMajority(int age)
        {
            return age >= 18;
        }
        static int CalculeAge()
        {
            Console.WriteLine("Bonjour "+Environment.UserName+" !\nTapez votre année de naissance svp :");
            string BirthYear = Console.ReadLine();
            while(true)
            {
                if(int.TryParse(BirthYear,out int cool))
                {
                    if(cool <= 0)
                    {
                        Console.WriteLine("La valeur que vous avez donné, est négatif. \nRetapez votre année de naissance svp :");
                        BirthYear = Console.ReadLine();
                        continue;
                    }
                    int age = DateTime.Now.Year - cool;
                     return age;
                }
                else
                {
                    Console.WriteLine("La valeur que vous avez donné, n'est pas un int. \nRetapez votre année de naissance svp :");
                    BirthYear = Console.ReadLine();
                }

            }
        }
    }
}
