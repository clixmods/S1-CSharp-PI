using System;

namespace Exercice_5
{
    /*
    Exo 5
Creer une fonction 'DisplayDiamond' qui prend en paramètre un int et affiche une figure comme suit :
Exemple le programme prend en paramètre 5 et affiche :
    *     
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
	
Exemple le programme prend en paramètre 4 et affiche :
   *     
  ***
 *****
*******
 *****
  ***
   *
   
   */
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            String[] array = new String[max];

            // Genere la partie du haut du diamant.
            for(int i = 0; i< max ;i++)
            {
                string message = "";
                // On rajoute le nombre d'espace au message
                for(int j = 1; j < max-i ; j++ )
                    message += " ";
                // après les espaces il a toujours une *
                message += "*";
                // A chaque i, rajoute deux * en plus, du coup on refait un for
                for(int k = 0; k < i; k++ )
                    message += "**";
                // Pour la dernière ligne, vue que je ne veux pas la réecrire pour dessiner la partie du bas, 
                // je rajoute le message à larray jusqua l'avant derniere itération afin de pas rajouter la derniere 
                if( i+1 < max)
                    array[i] = message;
                
                Console.WriteLine(message);
            }
            // Genere la partie bas du diamant
            // Vue que j'ai stocker tout mes précedents messages dans mon array string[], j'ai juste à les réafficher dans l'ordre décroissant par le for
            for(int i = array.Length-2; i >= 0 ;i--)
                Console.WriteLine(array[i]);
    
        }
    }
}
