namespace DM3_EnumEtStructure
{
    /*
    
================== Exo 4 ================== - Creer un projet 'LesFormes'
Creer un fichier Formes.cs 
Pour que le fichier soit detecté par le projet, ne pas oublier de faire de :
- soit fermer/reouvrir le projet
- soit Shift+Ctrl+P -> Reload Window

1 - Dans Forme.cs, declarer une enumeration 'TypeForme' representant les différentes formes possibles :
TriangleRectangle
TriangleIsocele
Diamant
FauxCarre
VraiCarre
DiamondSquare

2 - Dans Forme.cs, Declarer une structure 'Forme'.
Ajouter les propriétés private suivantes :
- une propriété 'typeForm' de type TypeForme.
- une propriété 'taille' de type int.

3 - Declarer et implementer le constructeur de la structure 'Forme'.
Le constructeur prend en entrée le type et la taille et initialise les propriétés de la structure.

4 - Surcharger et Implementer la fonction ToString()
La fonction doit afficher la forme dans la console en fonction de typeForm. (override de ToString()).

Il ya donc 6 versions de l'affichage à faire, une par valeur de l'enum TypeForm.
Voir la fin du fichier pour l'affichage à suivre pour chaque forme.

Conseil : faire un switch ou un if sur le type de la forme. 
À partir de chaque cas appeler la fonction correspondante. 
Exemple : cas ou typeForm est egal à TriangleRectangle alors on appelle DisplayTriangleRectangle.

5- Dans la fonction Main du fichier Program :
Declarer et initialiser des variables de type Forme pour chaque type de forme et avec des tailles differentes.
Afficher toutes les variables.

Exemple pour une forme de taille 7 l'affichage sera (en fonction de typeForm) :

TriangleRectangle
*
**
* *
*  *
*   *
*    *
*******

TriangleIsocele
      *
     * *
    *   *
   *     *
  *       *
 *         *
*************

Diamant
      *
     * *
    *   *
   *     *
  *       *
 *         *
*           *
 *         *
  *       *
   *     *
    *   *
     * *
      *
	  
FauxCarre
*********
*       *
*       *
*       *
*       *
*       *
*       *
*       *
*********

VraiCarre
* * * * * * * *
*             *
*             *
*             *
*             *
*             *
*             *
*             *
* * * * * * * *
 
Diamond Square
*************
*    * *    *
*   *   *   *
*  *     *  *
* *       * *
**         **
*           *
**         **
* *       * *
*  *     *  *
*   *   *   *
*    * *    *
*************
*/


}
