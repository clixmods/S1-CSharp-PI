
using System;
/*

================== Exo 3 ================== Creer un projet 'Vector3'

1 - Declarer une structure 'Vector3' ayant trois propriétés public de type float x, y ,z (les coordonnées du Vecteur).

2 - Creer un constructeur qui prend en entrée les trois coordonnées et qui initialise les propriétés de la structure.

3 - Surcharger la fonction ToString() 
Quand on appelle la fonction ToString() le retour doit être une string qui contient : "{x, y, z}"
"{0, 2, 1}" (exemple pour un vector3 initialisé à x = 0, y = 2 et z = 1).

4 - Declarer 2 variables de type Vector3 dans Main.
Initialiser les en leur donnant des valeurs differentes.
Afficher leur valeur avec WriteLine.

5 - Creer une fonction 'Translate' qui prend en entrée trois coordonnées et les ajoutes aux trois propriétés du vector3.
Utiliser la fonction Translate sur les deux variables déclarées.
Afficher leur valeur avec WriteLine.

5 - Creer une fonction 'Longueur' qui retourne la longeur du vecteur.
Formule longueur = Math.Sqrt(x² + y² + z²)
Utiliser la fonction Longueur sur les deux variables déclarées.
Afficher la longeur de chacune avec WriteLine.

6 - Creer une fonction static 'Distance' qui retourne la distance entre 2 Vector3.
Formule distance = Math.Sqrt((x2 - x1)² + (y2 - y1)² + (z2 - z1)²)
Utiliser la fonction Distance sur les deux variables déclarées.
Afficher la distance entre les deux variables avec WriteLine.

*/

namespace DM3_EnumEtStructure
{
    public struct Vector3
    {
        float x,y,z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // 1ère surcharge, on peut directement donner les coordonnées, séparement
        public void Translate(float x, float y , float z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }
        // Deuxieme surcharge avec directement le vector pris en compte
        public void Translate(Vector3 addPosition) 
        {
            Translate(addPosition.x,addPosition.y, addPosition.z);
        }

        float Longueur(float x, float y , float z)
        {
            double oof = x*x + y*y + z*z;
            return (float)Math.Sqrt(oof);
        } 
        // On calcule la longueur de l'instance, du coup j'envoi pas les coordonnées en parametres mais directement recup avec this 
        public float Longueur()
        {
            return Longueur(this.x, this.y , this.z);
        } 
        // note: Je sais plus comment on fait les puissances de 2 , du coup c'est peu long
        public static float Distance(Vector3 vectorA, Vector3 vectorB)
        {
            return (float)Math.Sqrt( (vectorB.x - vectorA.x)*(vectorB.x - vectorA.x) + (vectorB.y - vectorA.y)*(vectorB.y - vectorA.y) + (vectorB.z - vectorA.z)*(vectorB.z - vectorA.z) );
        } 

        public override string ToString()
        {
            return "{"+x+","+y+","+z+"}";
        }
    }
    

}