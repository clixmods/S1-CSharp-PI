class MathFunc
{
     /*
        Exo 2 : Créer un projet "UseReturn". Pour chaque fonction, faire deux utilisations dans la fonction Main.
        Afficher le retour de la fonction après l'avoir récupéré dans une variable.

        - Faire une fonction qui calcule la moyenne et retourne le resultat (total , nombreElement).
        - Faire une fonction qui calcule la surface d'un rectangle (largeur * hauteur).
        - Faire une fonction qui retourne un pourcentage en fonction d'une valeur et d'une valeur maximum representant 100%.
    */
    static public float CalculMoyenne(float total , float nombreElement)
    {
        return nombreElement/total;
    }
    static public float CalculSurface(float largeur , float hauteur)
    {
        return largeur*hauteur;

    }
    static public float CalculPourcentage(float valeur , float valeurMax)
    {
        return valeurMax/valeur;
    }

    
    
}