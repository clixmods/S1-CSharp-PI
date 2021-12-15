using System;

namespace DM3_EnumEtStructure
{
      public enum TypeForme
      {
            TriangleRectangle,
            TriangleIsocele,
            Diamant,
            FauxCarre,
            VraiCarre,
            DiamondSquare
      }
      public struct Forme
      {
          TypeForme typeForm;
          int taille;
          public Forme(TypeForme typeForm, int taille)
          {
                this.typeForm = typeForm;
                this.taille = taille;
          }

          public override string ToString()
          {
                switch(this.typeForm)
                {
                      case TypeForme.TriangleRectangle:
                      return  DisplayTriangleRectangle();
                      case TypeForme.TriangleIsocele:
                      return  DisplayTriangleIsocele();
                      case TypeForme.Diamant:
                      return  DisplayDiamant();
                      case TypeForme.FauxCarre:
                      return  DisplayFauxCarre();
                      case TypeForme.VraiCarre:
                      return  DisplayVraiCarre();
                      case TypeForme.DiamondSquare:
                      return  DisplayDiamondSquare();
                }
                return "Forme est mal setup"; // on retourne ca si jamais la forme est mal défini
          }

            string DisplayTriangleRectangle(){
                  string str = "*\n";
                  for(int i = 1 ; i < taille-1; i++)
                  {
                        string line = "*";
                        for(int j = 1; j < i ; j++ )
                              line += " ";
                        
                        str += line+"*\n";
                  }
                  string lineFinal = "*";
                  for(int i = 1 ; i < taille; i++)
                  {
                        lineFinal += "*";
                  }
                  str += lineFinal;
                  return str;

            }
            string DisplayTriangleIsocele()
            {
                  string str = "";
                  String[] array = new String[taille];
                  // Genere la partie du haut du diamant.
                  for(int i = 0; i< taille-1 ;i++)
                  {
                        string line = "";
                        
                        for(int j = 1; j < taille-i ; j++ )
                              line += " ";
                        
                        line += "*";
                        
                        for(int k = 0; k < i-1; k++ )
                              line += "  ";
                        if(i > 0)
                              line += " *";
                        str += line+"\n";
                  }
                  string message = "";
                  for(int i = 1; i< taille*2 ;i++)
                        message += "*";

                   str += message;

                  return str;
            }

            string DisplayDiamant(){
                  
                  string str = "";
                  String[] array = new String[taille];
                  for(int i = 0; i< taille ;i++)
                  {
                        string message = "";
                        for(int j = 1; j < taille-i ; j++ )
                              message += " ";
                       
                        message += "*";
                         for(int k = 0; k < i-1; k++ )
                              message += "  ";
                        if(i > 0)
                              message += " *";

                        message +="\n";
                        if( i+1 < taille)
                              array[i] = message;
                        
                        str += message;
                  }


                  for(int i = array.Length-2; i >= 0 ;i--)
                  str += array[i];
            
                  return str;
            }
            string DrawBottowLine()
            {
                  string str = "*";
                   for(int i = 0; i< taille; i++)
                  {
                        str += "*";
                  }
                  str += "*\n";
                  return str;
            }
            string DisplayFauxCarre(){

                  string str = "";
                  str += DrawBottowLine();

                  for(int i = 0; i< taille; i++)
                  {
                        str += "*";
                        for(int k = 0; k< taille; k++)
                              str += " ";
                        str += "*\n";
                  }
                   str += DrawBottowLine();
                  return str;
            }
                  //
                  string DrawBottowLineVraiCarre()
                  {
                        string str = "*";
                        for(int i = 0; i< taille; i++)
                        {
                              str += " *";
                        }
                        str += " *\n";
                        return str;
                  }
            string DisplayVraiCarre(){
                  string str = "";
                  str += DrawBottowLineVraiCarre();

                  for(int i = 0; i< taille; i++)
                  {
                        str += "*";
                        for(int k = 0; k< taille; k++)
                              str += "  ";
                        str += " *\n";
                  }
                   str += DrawBottowLineVraiCarre();
                  return str;
            }
            string DisplayDiamondSquare(){
                   string str = "";
                  String[] array = new String[taille];
                  for(int i = 0; i< taille ;i++)
                  {
                        string message = "*";
                        for(int j = 2; j < taille-i ; j++ )
                        {
                              if(i == 0)
                                    message += "**";
                              else
                                    message += " ";
                        }      
                        if(i+1 < taille)   
                        message += "*";

                        for(int k = 0; k < i-1; k++ )
                        {
                             if(i == 0)
                                    message += "**";
                              else
                                    message += "  ";

                        }    
                        if(i > 0)
                              message += " *";

                        for(int j = 2; j < taille-i ; j++ )
                        {
                              if(i != 0)
                                    message += " ";
                        }
                              
                              
                        if(i+1 < taille)     
                        message += "*";      

                        message +="\n";
                        if( i+1 < taille)
                              array[i] = message;
                        
                        str += message;
                  }

                  for(int i = array.Length-2; i >= 0 ;i--)
                   str += array[i];
            
                  return str;
            }

      }
    /*



4 - Surcharger et Implementer la fonction ToString()
La fonction doit afficher la forme dans la console en fonction de typeForm. (override de ToString()).

Il ya donc 6 versions de l'affichage à faire, une par valeur de l'enum TypeForm.
Voir la fin du fichier pour l'affichage à suivre pour chaque forme.

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
