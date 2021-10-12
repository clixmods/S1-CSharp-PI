using System;
/*
Exo 5 : Creer un nouveau projet Visual Code "CharacterValue" et Ecrire un programme 
(Note : utiliser Console.ReadKey() et le retour de cette fonction ConsoleKeyInfo.)

- Qui demande à l'utilisateur de taper un caractère
- Qui affiche ensuite le caractère tapé est dit sa valeur en numérique.
Ex : 
- le programme affiche "Appuyer sur une touche : "
- l'utilisateur appuye sur 'k'
- le programme affiche : "Vous avez appuyé sur la touche k sa valeur numérique est de 75."

*/
namespace CharacterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Appuyer sur une ECHAP pour quitter \nAppuyer sur une touche :");
                ConsoleKeyInfo Hello = Console.ReadKey();
                if((byte)Hello.KeyChar == 27)
                    break;

                Console.WriteLine("\nVous avez appuyé sur la touche "+Hello.Key+" sa valeur numérique est de "+((byte)Hello.Key)+".");
            }
            
        }
    }
}
