using System;

namespace UseReturn
{
    /*
        Exo 2 : Créer un projet "UseReturn". Pour chaque fonction, faire deux utilisations dans la fonction Main.
        Afficher le retour de la fonction après l'avoir récupéré dans une variable.

        - Faire une fonction qui calcule la moyenne et retourne le resultat (total , nombreElement).
        - Faire une fonction qui calcule la surface d'un rectangle (largeur * hauteur).
        - Faire une fonction qui retourne un pourcentage en fonction d'une valeur et d'une valeur maximum representant 100%.
    */

    class Program
    {
        static void Main(string[] args)
        {
            string result = "Resultat : Vide car aucune function n'a été executer";
            bool userChoice = int.TryParse(Console.ReadLine() , out int oof );

            switch(oof)
            {
                case 1:
                bool nombreElementValid = int.TryParse(Console.ReadLine(),out int nombreElement);
                bool totalValid = int.TryParse(Console.ReadLine(),out int total);
                if(nombreElementValid && totalValid) result = MathFunc.CalculMoyenne(total,nombreElement).ToString();
                break;
                case 2:
                bool largeurValid = int.TryParse(Console.ReadLine(),out int largeur);
                bool hauteurValid = int.TryParse(Console.ReadLine(),out int hauteur);
                if(largeurValid && hauteurValid) result = MathFunc.CalculSurface(largeur,hauteur).ToString();
                break;
                case 3:
                bool valueValid = int.TryParse(Console.ReadLine(),out int value);
                bool maxValueValid = int.TryParse(Console.ReadLine(),out int maxValue);
                if(valueValid && maxValueValid) result = MathFunc.CalculPourcentage(value,maxValue).ToString();
                break;
                default:
                result = "La function choisi n'est pas correct";
                break;
            }
           
            Console.WriteLine(result);
            
        }
    }

}
