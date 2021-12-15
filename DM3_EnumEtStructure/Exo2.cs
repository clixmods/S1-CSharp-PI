
using System;
/*

================== Exo 2 ================== Creer un projet 'ValidInput'

- Creer une fonction qui prend en entrée un parametre de type ConsoleKey (enumeration de system)
- La fonction doit demander de taper sur 4 touches differentes (exemple ArrowLeft, ArrowRight, ArrowUp, ArrowDown)
- La fonction retourne true si l'input est bien egal à une des 4 touches, sinon false
- Appeler la fonction dans main et la rappeler tant que l'input n'est pas valide, sinon afficher : "Bravo vous savez appuyer sur les touches autorisées :)!"

*/

namespace DM3_EnumEtStructure
{
    
    public class Exo2
    {
       public static bool ValidInput(ConsoleKey input)
       {
           // on check le input de l'user, si il entre dans aucune case , on retourne FAUX.
           switch(input)
           {
               case ConsoleKey.LeftArrow :
               case ConsoleKey.RightArrow :
               case ConsoleKey.UpArrow :
               case ConsoleKey.DownArrow :
                return true;
           }
           return false;
       }
    }
}