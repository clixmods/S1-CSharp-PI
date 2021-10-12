using System;
/*

Exo 6 : Creer un nouveau projet Visual Code "AgeDisplay" et Ecire un programme qui :
(Note : utiliser Console.ReadLine() et int.Parse(string) pour transformer une string en int.)

- Affiche : "Bienvenue sur notre programme, tapez votre nom :"
- Récupère le nom tapé par l'utilisateur
- Affiche : "Bonjour nomUtilisateur !"
- Affiche ensuite : "Tapez votre age svp : "
- Récupère l'age tapé par l'utilisateur dans une variable.
- Calcule l'année de sa naissance à partir de l'age.
- Affiche ensuite : "Vous êtes né l'année : anneeCalculee et vous avez ageUtilisateur."



*/
namespace AgeDisplay
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenue sur notre programme, tapez votre nom :");
             string nomUtilisateur = Console.ReadLine() ;
             Console.WriteLine("Bonjour "+nomUtilisateur+" !\nTapez votre age svp :");
            string age = Console.ReadLine();
            while(true)
            {
                if(int.TryParse(age,out int cool))
                {
                    int BirthYear = DateTime.Now.Year - int.Parse(age);
                     Console.WriteLine("Vous êtes né l'année : "+BirthYear+" et vous avez "+age+" ans" ); 
                     break;
                }
                else
                {
                    Console.WriteLine("La valeur que vous avez donné, n'est pas un int. \nRetapez votre age svp :");
                    age = Console.ReadLine();
                }

            }
           
        }
    }
}
