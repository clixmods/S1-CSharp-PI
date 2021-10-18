using System;

namespace Exercice_4_Program
{
    /*
        Exo 4 : 
        Declarer une variable life et et demander à l’utilisateur de saisir la valeur.
        ensuite afficher une couleur en mot en fonction de sa valeur :
        0 ou inferieur : NOIR
        entre 1 et 20 : ROUGE
        entre 21 et 40 : ORANGE
        entre 41 et 60 : JAUNE
        entre 61 et 100 ou superieur à 100 : VERT
    */
    class Program
    {
        static int life;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indiquez la vie que vous souhaitez, tapez autre chose qu'un nombre pour éteindre le programme");
                string userLife = Console.ReadLine();
                if(int.TryParse(userLife, out life))
                {
                    if(life <= 0) Console.WriteLine("NOIR");
                    else if(life >= 1 && life <= 20 ) Console.WriteLine("ROUGE");
                    else if(life >= 21 && life <= 40 ) Console.WriteLine("ORANGE");
                    else if(life >= 41 && life <= 60 ) Console.WriteLine("JAUNE");
                    else if(life >= 61 ) Console.WriteLine("VERT");
                }
                else 
                {
                    Console.WriteLine("Good bye world!");
                    break;
                }

            }
            
        }
    }
}
