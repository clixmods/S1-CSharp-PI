using System;

namespace Exo_1
{
    /*
        Exo 1

        Creer une enumeration 'Operation' qui definie les 5 operations numeriques :
        +, -, *, /, %
        Creer une fonction 'Calculate' qui prend en entrée un paramètre typé par 
        l'enumeration Operation et deux paramètrs de type numérique.

        Implementer le comportement de la fonction : 
        La fonction doit retourner le resultat de l'operation entre les 
        deux variables numeriques.
        L'operation est choisie en fonction du paramètre de 
        type enum 'Operation' (Conseil Utiliser un switch)

    */
 
    class Program
    {
        

        public enum Operation : int
        {
            Addition = 1,
            Soustraction = 9+5,
            Multiplication = 5+5,
            Division = 9,
            Modulo = 15
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Operation.Addition);
        }
       
    }
}
